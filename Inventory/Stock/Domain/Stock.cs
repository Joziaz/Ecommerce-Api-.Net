using api.Shared.Domain;

namespace api.Inventory.Domain
{
    public class Stock : BaseEntity
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }

        public Stock(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public void SubstractStock(int quantity)
        {
            if (Quantity < quantity)
                throw new NotEnoughStockException("Not enough in stock to complete you order");

            Quantity -= quantity;
        }

        public void AddToStock(int quantity)
        {
            Quantity += quantity;
        }
    }
}