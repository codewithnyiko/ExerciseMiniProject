using EnverSoft.SupplierConnect.Domain.Entities;

namespace EnverSoft.SupplierConnect.Data.Repositories.Abstracts
{
    /// <summary>
    /// Represents a repository interface for managing supplier data.
    /// </summary>
    public interface ISupplierRepository
    {
        /// <summary>
        /// Retrieves all suppliers asynchronously.
        /// </summary>
        /// <returns>An enumerable collection of suppliers.</returns>
        Task<IEnumerable<Supplier>> GetAllAsync();

        /// <summary>
        /// Retrieves a supplier by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier of the supplier to retrieve.</param>
        /// <returns>The supplier with the specified identifier.</returns>
        Task<Supplier> GetByIdAsync(int id);

        /// <summary>
        /// Adds a new supplier asynchronously.
        /// </summary>
        /// <param name="supplier">The supplier to add.</param>
        Task AddAsync(Supplier supplier);

        /// <summary>
        /// Updates an existing supplier asynchronously.
        /// </summary>
        /// <param name="supplier">The supplier to update.</param>
        Task UpdateAsync(Supplier supplier);

        /// <summary>
        /// Deletes a supplier by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The identifier of the supplier to delete.</param>
        Task DeleteAsync(int id);

        /// <summary>
        /// Retrieves a supplier by its name asynchronously.
        /// </summary>
        /// <param name="name">The name of the supplier to retrieve.</param>
        /// <returns>The supplier with the specified name.</returns>
        Task<Supplier> GetByNameAsync(string name);
    }

}
