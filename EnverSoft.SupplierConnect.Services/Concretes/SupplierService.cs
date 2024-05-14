using AutoMapper;
using EnverSoft.SupplierConnect.Data.Repositories.Abstracts;
using EnverSoft.SupplierConnect.Domain.DTOs;
using EnverSoft.SupplierConnect.Domain.Entities;
using EnverSoft.SupplierConnect.Services.Abstracts;

namespace EnverSoft.SupplierConnect.Services.Concretes
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;
        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync()
        {
            var suppliers = await _supplierRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<SupplierDto>>(suppliers);
        }

        /// <inheritdoc />
        public async Task<SupplierDto> GetSupplierByIdAsync(int id)
        {
            var supplier = await _supplierRepository.GetByIdAsync(id);
            return _mapper.Map<SupplierDto>(supplier);
        }

        /// <inheritdoc />
        public async Task AddSupplierAsync(SupplierDto supplier)
        {
            var supplierEntity = _mapper.Map<Supplier>(supplier);
            await _supplierRepository.AddAsync(supplierEntity);
        }

        /// <inheritdoc />
        public async Task UpdateSupplierAsync(SupplierDto supplier)
        {
            var supplierEntity = _mapper.Map<Supplier>(supplier);
            await _supplierRepository.UpdateAsync(supplierEntity);
        }

        /// <inheritdoc />
        public async Task DeleteSupplierAsync(int id)
        {
            await _supplierRepository.DeleteAsync(id);
        }

        /// <inheritdoc />
        public async Task<SupplierDto> GetSupplierByNameAsync(string name)
        {
            var supplier = await _supplierRepository.GetByNameAsync(name);
            return _mapper.Map<SupplierDto>(supplier);
        }
    }
}