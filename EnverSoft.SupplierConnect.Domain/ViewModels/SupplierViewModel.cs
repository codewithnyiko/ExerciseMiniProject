namespace EnverSoft.SupplierConnect.Domain.ViewModels
{
    /// <summary>
    /// Represents a view model for displaying supplier information.
    /// </summary>
    public class SupplierViewModel
    {
        /// <summary>
        /// The supplier code.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The supplier name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The supplier telephone number.
        /// </summary>
        public string TelephoneNo { get; set; }
    }

}
