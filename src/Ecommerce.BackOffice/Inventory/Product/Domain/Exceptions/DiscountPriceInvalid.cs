using System;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class DiscountPriceInvalid : Exception
    {
        public DiscountPriceInvalid(string message) : base(message)
        {
        }
    }
}