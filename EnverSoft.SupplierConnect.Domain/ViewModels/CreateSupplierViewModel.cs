using System.ComponentModel.DataAnnotations;

namespace EnverSoft.SupplierConnect.Domain.ViewModels
{
    /// <summary>
    /// Represents a view model for creating or editing a supplier.
    /// </summary>
    public class SupplierCreateEditViewModel
    {
        /// <summary>
        /// The company code.
        /// </summary>
        [Display(Name = "Company Code")]
        public int Code { get; set; }

        /// <summary>
        /// The company name.
        /// </summary>
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company name is required.")]
        public string Name { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [Required(ErrorMessage = "Telephone number is required.")]
        [Display(Name = "Telephone Number")]
        [RegularExpression(@"^(?:\+27|0)(\d{9})$", ErrorMessage = "Please enter a valid South African phone number.")]
        public string TelephoneNo { get; set; }
    }

}
