using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class Product : BaseEntity
    {

        public string Name { get; private set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        private decimal _price { get; set; }
        public decimal Price { get => GetPrice(); }
        public decimal DiscountPrice { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            _price = price;
        }

        private decimal GetPrice()
        {
            if (DiscountPrice != 0)
                return DiscountPrice;

            return _price;
        }
        public void SetDiscountPrice(decimal discount)
        {
            if (discount >= _price)
                throw new DiscountPriceInvalid("the discount price can't be gather or equal to the normal price");

            DiscountPrice = discount;
        }
    }
}