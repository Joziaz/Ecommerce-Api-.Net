using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class Product : BaseEntity
    {

        public string Name { get; private set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public float Price { get; private set; }
        public float DiscountPrice { get; private set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public void SetDiscountPrice(float discount)
        {
            if (discount >= Price)
                throw new DiscountPriceInvalid("the discount price can't be gather or equal to the normal price");

            DiscountPrice = discount;
        }
    }
}