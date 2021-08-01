using System;

namespace Ecommerce.Shop.Stocks.Domain.Exceptions
{
    [Serializable]
    internal class QuantityInvalid : Exception
    {
        public QuantityInvalid(string message) : base(message)
        {
        }
    }
}