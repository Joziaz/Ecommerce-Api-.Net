using System;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    [Serializable]
    internal class NotEnoughStockException : Exception
    {
        public NotEnoughStockException(string message) : base(message)
        {
        }
    }
}