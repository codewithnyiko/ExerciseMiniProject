using AutoMapper;
using EnverSoft.SupplierConnect.Domain.DTOs;
using EnverSoft.SupplierConnect.Domain.ViewModels;
using EnverSoft.SupplierConnect.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EnverSoft.SupplierConnect.Web.Controllers
{

    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;
        private readonly ILogger<SupplierController> _logger;

        public SupplierController(ISupplierService supplierService, IMapper mapper, ILogger<SupplierController> logger)
        {
            _supplierService = supplierService;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string searchString, int? pageNumber)
        {
            try
            {
                var suppliers = await _supplierService.GetAllSuppliersAsync();
                var suppliersViewModel = _mapper.Map<IEnumerable<SupplierViewModel>>(suppliers);

                if (!string.IsNullOrWhiteSpace(searchString))
                {
                    suppliersViewModel = suppliersViewModel.Where(m =>
                        m.Name.ToLower().Contains(searchString.ToLower())).ToList();
                }

                // Order by descending company code to display the last added company first
                suppliersViewModel = suppliersViewModel
                    .OrderByDescending(m => m.Code);

                // if no page was specified in the querystring, default to the first page (1)
                var page = pageNumber ?? 1; 

                return View(suppliersViewModel.ToPagedList(page, 5));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(SupplierController)}-{nameof(Index)}-{ex.Message}");
                return View("Error");
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SupplierCreateEditViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Check if a supplier with the same company name already exists to avoid duplicates
                    var supplier = await _supplierService.GetSupplierByNameAsync(model.Name.Trim());

                    if (supplier != null)
                    {
                        // Set error message indicating the company name already exists
                        ViewBag.Message = $"A company with the name '{model.Name}' already exists in the database";
                        return View(model);
                    }

                    var supplierDto = _mapper.Map<SupplierDto>(model);
                    await _supplierService.AddSupplierAsync(supplierDto);
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(SupplierController)}-{nameof(Create)}-{ex.Message}");
                return View("Error");
            }
        }

        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return View("NotFound");
                }

                var supplierDto = await _supplierService.GetSupplierByIdAsync(id.Value);

                if (supplierDto == null)
                {
                    return View("NotFound");
                }

                var model = _mapper.Map<SupplierCreateEditViewModel>(supplierDto);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(SupplierController)}-{nameof(Edit)}-{ex.Message}");
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SupplierCreateEditViewModel model)
        {
            try
            {
                if (id != model.Code || model.Code == 0)
                {
                    return View("NotFound");
                }

                if (ModelState.IsValid)
                {
                    var supplierDto = _mapper.Map<SupplierDto>(model);
                    await _supplierService.UpdateSupplierAsync(supplierDto);
                    return RedirectToAction(nameof(Index));
                }

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"{nameof(SupplierController)}-{nameof(Edit)}-{ex.Message}");
                return View("Error");
            }
        }
    }
}
