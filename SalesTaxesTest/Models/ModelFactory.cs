using SalesTaxesTest.Entities;

namespace SalesTaxesTest.Models
{
    public class ModelFactory
    {
        public ProductModel Create(Product product)
        {
            return new ProductModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}