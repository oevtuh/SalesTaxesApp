using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Abstract;
using SalesTaxesTest.Entities;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Services
{
    public class TaxesService : ITaxesService
    {
        private const double BASE_IMPORT_RATE = 5;
        private const double BASE_TAX_RATE = 10;

        private readonly IProductService _productService;

        private Dictionary<int, double> CategoryTaxMap
        {
            get
            {
                return new Dictionary<int, double>()
                {
                    {1, 0},
                    {2, 0},
                    {3, 0},
                    {4, 10},
                    {5, 10},
                    {6, 10}
                };
            }
        }

        public TaxesService(IProductService productService)
        {
            _productService = productService;
        }

        public decimal GetTaxes(Product product, int quantity = 1)
        {
            double taxRate = GetTaxRate(product);

            return TaxRound(product.Price * (decimal)(taxRate / 100) * quantity);
        }

        public double GetTaxRate(Product product)
        {
            var taxRate = GetBaseTaxRate(product.Category.Id);
            if (product.Imported)
            {
                taxRate += BASE_IMPORT_RATE;
            }

            return taxRate;
        }

        private double GetBaseTaxRate(int categoryId)
        {
            double value;
            if (!CategoryTaxMap.TryGetValue(categoryId, out value))
            {
                return BASE_TAX_RATE;
            }

            return value;
        }

        public static decimal TaxRound(decimal value)
        {
            return Math.Round(Math.Round(value * 20) / 20, 1);
        }
    }

}