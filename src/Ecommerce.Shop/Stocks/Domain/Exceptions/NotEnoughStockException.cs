using System;

namespace Ecommerce.Shop.Stocks.Domain
{
    [Serializable]
    internal class NotEnoughStockException : Exception
    {
        public NotEnoughStockException(string message) : base(message)
        {
        }
    }
}