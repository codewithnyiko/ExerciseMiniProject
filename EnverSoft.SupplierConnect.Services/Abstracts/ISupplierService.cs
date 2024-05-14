
using EnverSoft.SupplierConnect.Domain.DTOs;

namespace EnverSoft.SupplierConnect.Services.Abstracts
{
    /// <summary>
    /// Represents a service for managing supplier-related operations.
    /// </summary>
    public interface ISupplierService
    {
        /// <summary>
        /// Retrieves all suppliers asynchronously.
        /// </summary>
        /// <returns>An enumerable collection of <see cref="SupplierDto"/>.</returns>
        Task<IEnumerable<SupplierDto>> GetAllSuppliersAsync();

        /// <summary>
        /// Retrieves a supplier by its identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier of the supplier.</param>
        /// <returns>The <see cref="SupplierDto"/> with the specified identifier.</returns>
        Task<SupplierDto> GetSupplierByIdAsync(int id);

        /// <summary>
        /// Adds a new supplier asynchronously.
        /// </summary>
        /// <param name="supplier">The <see cref="SupplierDto"/> to add.</param>
        Task AddSupplierAsync(SupplierDto supplier);

        /// <summary>
        /// Updates an existing supplier asynchronously.
        /// </summary>
        /// <param name="supplier">The <see cref="SupplierDto"/> to update.</param>
        Task UpdateSupplierAsync(SupplierDto supplier);

        /// <summary>
        /// Deletes a supplier by its identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier of the supplier to delete.</param>
        Task DeleteSupplierAsync(int id);

        /// <summary>
        /// Retrieves a supplier by its name asynchronously.
        /// </summary>
        /// <param name="name">The name of the supplier.</param>
        /// <returns>The <see cref="SupplierDto"/> with the specified name.</returns>
        Task<SupplierDto> GetSupplierByNameAsync(string name);
    }

}
