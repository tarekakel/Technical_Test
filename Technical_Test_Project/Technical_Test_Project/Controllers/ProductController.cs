using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Repository;

namespace Technical_Test_Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }
        public IActionResult Index()
        {
            var result = _ProductRepository.products();
            return View(result.Result);
        }
 

    }
}
