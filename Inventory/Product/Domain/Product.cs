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
        public float Price { get => GetPrice(); }

        public Product(string name, float price)
        {
            Name = name;
            _price = price;
        }
        private float GetPrice()
        {
            if (DiscountPrice > 0)
                return DiscountPrice;

            return _price;
        }


        public void SetDiscountPrice(float discount) => DiscountPrice = discount;
    }
}