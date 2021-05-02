using api.Shared.Domain;

namespace api.Inventory.Domain
{
    public class Product : BaseEntity
    {
        private float _price;

        public string Name { get; private set; }
        public string Description { get; set; }
        public float DiscountPrice { get; private set; }
        public Category Category { get; set; }
        public float Price { get; private set; }

        public Product(string name, float price)
        {
            Name = name;
            _price = price;
        }

        public void SetDiscountPrice(float discount) => DiscountPrice = discount;
    }
}