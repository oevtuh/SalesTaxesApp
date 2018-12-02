using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesTaxesTest.Models
{
    public class BasketModel
    {
        public BasketModel()
        {
            Products = new List<BasketEntryModel>();
        }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
        public List<BasketEntryModel> Products { get; set; }
    }
}