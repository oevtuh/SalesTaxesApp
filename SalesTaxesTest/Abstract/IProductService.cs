using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Abstract
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}