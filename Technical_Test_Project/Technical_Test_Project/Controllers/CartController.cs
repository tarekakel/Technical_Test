using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Test_Project.Data;
using Technical_Test_Project.Repository;

namespace Technical_Test_Project.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;


        public CartController(ICartRepository cartRepository, IProductRepository productRepository)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index(int productId)
        {
            var product = _productRepository.productById(productId);
            return View(product.Result);
        }
        [HttpPost]
        public IActionResult AddToCart(CartItem viewModel)
        {
            return View();
        }
    }
}
