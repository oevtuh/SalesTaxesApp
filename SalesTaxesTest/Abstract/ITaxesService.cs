using SalesTaxesTest.Entities;

namespace SalesTaxesTest.Abstract
{
    public interface ITaxesService
    {
        decimal GetTaxes(Product product, int quantity = 1);
    }
}