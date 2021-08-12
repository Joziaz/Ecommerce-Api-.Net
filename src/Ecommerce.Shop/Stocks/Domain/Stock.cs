using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;

namespace Ecommerce.Shop.Stocks.Domain
{
    public class Stock : BaseEntity
    {
        public Product Product { get; private set; }
        public uint Quantity { get; private set; }

        public Stock()
        {
        }

        public Stock(Product product, uint quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public void SubtractStock(uint quantity)
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