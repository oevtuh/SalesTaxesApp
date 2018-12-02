using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesTaxesTest.Models
{
    public class OrderEntryRequest
    {
        public List<OrderEntryModel> Products { get; set; }
    }
}