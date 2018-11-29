using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts();
        }
    }
}
