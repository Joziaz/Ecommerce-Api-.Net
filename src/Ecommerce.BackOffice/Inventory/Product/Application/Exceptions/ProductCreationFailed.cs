using System;
using System.Runtime.Serialization;

namespace Ecommerce.BackOffice.Inventory.Application
{
    [Serializable]
    internal class ProductCreationFailed : Exception
    {
        public ProductCreationFailed(string message) : base(message)
        {
        }
    }
}