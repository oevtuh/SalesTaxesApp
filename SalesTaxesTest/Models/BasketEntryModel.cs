using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesTaxesTest.Models
{
    public class BasketEntryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
    }
}