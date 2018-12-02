using SalesTaxesTest.Models;

namespace SalesTaxesTest.Abstract
{
    public interface IBasketService
    {
        BasketModel GetBasketModel(OrderEntryRequest orderEntry);
    }
}