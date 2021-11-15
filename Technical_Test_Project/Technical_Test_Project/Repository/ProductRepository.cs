using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Data;

namespace Technical_Test_Project.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly TestDbContext _context;

        public ProductRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<Product> productById(int id)
        {
            var product = await _context.products.FirstOrDefaultAsync(x => x.ID == id);
            return product;
        }

        public async Task<IEnumerable<Product>> products()
        {
            var result = await _context.products.ToListAsync();
            return (result);
        }
    }
}
