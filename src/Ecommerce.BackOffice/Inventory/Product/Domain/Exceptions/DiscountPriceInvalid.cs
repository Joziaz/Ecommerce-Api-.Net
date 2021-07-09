using System;
using System.Runtime.Serialization;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class DiscountPriceInvalid : Exception
    {
        public DiscountPriceInvalid(string message) : base(message)
        {
        }
    }
}