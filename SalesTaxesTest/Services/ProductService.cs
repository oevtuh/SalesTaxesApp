using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "First",
                    Price = 5,
                    Category = new ProductCategory()
                    {
                        Id= 1,
                        Name = "Food",

                    }
                }
            };
        }
    }
}