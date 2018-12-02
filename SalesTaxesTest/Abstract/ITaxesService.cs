using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalesTaxesTest.Models;

namespace SalesTaxesTest.Abstract
{
    public interface ITaxesService
    {
        BasketModel GetBasketModel(OrderEntryRequest orderEntry);
    }
}