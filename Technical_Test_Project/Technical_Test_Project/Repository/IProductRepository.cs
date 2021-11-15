using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Data;

namespace Technical_Test_Project.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> products();
        Task<Product> productById(int id);

    }
}
