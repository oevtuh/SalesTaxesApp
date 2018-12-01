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
        private readonly ModelFactory _modelFactory;

        public ProductController(IProductService productService)
        {
            _productService = productService;
            _modelFactory = new ModelFactory();
        }

        public object Get()
        {
            var products = _productService.GetProducts().Select(x => _modelFactory.Create(x));

            return new
            {
                content = new
                {
                    products = products
                }
            };
        }
    }
}
