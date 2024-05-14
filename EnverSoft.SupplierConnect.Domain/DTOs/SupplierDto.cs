namespace EnverSoft.SupplierConnect.Domain.DTOs
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a supplier.
    /// </summary>
    public class SupplierDto
    {
        /// <summary>
        ///The code of the supplier.
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        ///The name of the supplier.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The telephone number of the supplier.
        /// </summary>
        public string TelephoneNo { get; set; }
    }

}
