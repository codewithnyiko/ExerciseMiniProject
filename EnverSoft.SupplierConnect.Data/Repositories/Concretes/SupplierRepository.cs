using EnverSoft.SupplierConnect.Data.Contexts;
using EnverSoft.SupplierConnect.Data.Repositories.Abstracts;
using EnverSoft.SupplierConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnverSoft.SupplierConnect.Data.Repositories.Concretes
{
    public class SupplierRepository : ISupplierRepository
    {

        private readonly ApplicationDBContext _context;

        public SupplierRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Supplier> GetByIdAsync(int id)
        {
            return await _context.Suppliers.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task AddAsync(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task UpdateAsync(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteAsync(int id)
        {
            var supplier = await GetByIdAsync(id);
            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<Supplier> GetByNameAsync(string name)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(m => m.Name.Equals(name));
        }
    }
}
