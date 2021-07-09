using System;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    [Serializable]
    internal class QuantityInvalid : Exception
    {
        public QuantityInvalid(string message) : base(message)
        {
        }
    }
}