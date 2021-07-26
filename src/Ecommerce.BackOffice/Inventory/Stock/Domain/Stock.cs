using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class Stock : BaseEntity
    {
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }

        public Stock(Product product, uint quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public void SubstractStock(uint quantity)
        {
            if (Quantity < quantity)
                throw new NotEnoughStockException("Not enough in stock");

            Quantity -= quantity;
        }

        public void AddToStock(uint quantity)
        {
            Quantity += quantity;
        }
    }
}