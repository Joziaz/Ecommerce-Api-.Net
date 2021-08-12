namespace Ecommerce.Shop.Products.Domain
{
    public class Category
    {
        public string Name { get; private set; }

        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }
    }
}