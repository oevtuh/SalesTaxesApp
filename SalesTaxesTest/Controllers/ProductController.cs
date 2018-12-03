using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Entities;
using SalesTaxesTest.Models;
using SalesTaxesTest.Shared.Attributes;

namespace SalesTaxesTest.Controllers
{
    [EnableCustomCors]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public object Get()
        {
            var products = _productService.GetProducts().Select(Mapper.Map<Product, ProductModel>);

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
