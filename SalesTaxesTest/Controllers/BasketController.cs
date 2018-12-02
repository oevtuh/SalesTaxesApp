using System;
using System.Collections.Generic;
using System.Web.Http;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Controllers
{
    public class BasketController : ApiController
    {
        public Object Post(OrderEntryRequest products)
        {
            var basket = new BasketModel()
            {
                Taxes = 6.75m,
                Total = 110,
                Products = new List<BasketEntryModel>()
                {
                    new BasketEntryModel()
                    {
                        Id = 1,
                        Name = "First",
                        Amount = 12,
                        Quantity = 2
                    }
                }
            };

            return new
            {
                content = new
                {
                    cart = basket
                }
            };
        }
    }
}
