using System;
using System.Runtime.Serialization;

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