using System;
using System.Runtime.Serialization;

namespace Ecommerce.Shop.Orders.Domain
{
    public class NotEnoughQuantity : Exception
    {
        public NotEnoughQuantity(string message) : base(message)
        {
        }
    }
}