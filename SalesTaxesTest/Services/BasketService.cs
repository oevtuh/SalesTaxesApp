using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Services
{
    public class BasketService : IBasketService
    {
        private readonly IProductService _productService;
        private readonly ITaxesService _taxesService;

        public BasketService(IProductService productService, ITaxesService taxesService)
        {
            _productService = productService;
            _taxesService = taxesService;
        }

        public BasketModel GetBasketModel(OrderEntryRequest orderEntry)
        {
            var basketModel = new BasketModel();

            if (orderEntry != null && orderEntry.Products.Count > 0)
            {
                foreach (var order in orderEntry.Products)
                {
                    var product = _productService.GetById(order.Id);
                    if (product != null)
                    {
                        decimal productsPrice = product.Price * order.Quantity;
                        decimal taxes = _taxesService.GetTaxes(product, order.Quantity);
                        var basketEntry = new BasketEntryModel()
                        {
                            Id = product.Id,
                            Quantity = order.Quantity,
                            Amount = productsPrice + taxes,
                            Name = product.Name
                        };
                        basketModel.Products.Add(basketEntry);
                        basketModel.Taxes += taxes;
                        basketModel.Total += productsPrice + taxes;
                    }
                }
            }

            return basketModel;
        }
    }
}