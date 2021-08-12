using Ecommerce.Shared.Domain;

namespace Ecommerce.Shop.Products.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; private set; }
        public decimal DiscountPrice { get; private set; }

        public Product()
        {
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
