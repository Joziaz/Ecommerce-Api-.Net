using System;

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