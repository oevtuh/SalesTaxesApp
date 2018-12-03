using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Http;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Models;
using SalesTaxesTest.Shared.Attributes;

namespace SalesTaxesTest.Controllers
{
    [EnableCors]
    public class BasketController : ApiController
    {
        private readonly ITaxesService _taxesService;
        private readonly IBasketService _basketService;

        public BasketController(ITaxesService taxesService, IBasketService basketService)
        {
            _taxesService = taxesService;
            _basketService = basketService;
        }
        public Object Post(OrderEntryRequest order)
        {
            var basket = _basketService.GetBasketModel(order);

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
