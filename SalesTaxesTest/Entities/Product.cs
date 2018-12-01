namespace SalesTaxesTest.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public decimal Price { get; set; }
        public bool Imported { get; set; }
    }
}