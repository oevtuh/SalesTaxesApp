using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Http;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Controllers
{
    public class BasketController : ApiController
    {
        private readonly ITaxesService _taxesService;

        public BasketController(ITaxesService taxesService)
        {
            _taxesService = taxesService;
        }
        public Object Post(OrderEntryRequest order)
        {
            var basket = _taxesService.GetBasketModel(order);

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
