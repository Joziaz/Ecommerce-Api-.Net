using System;
using System.Runtime.Serialization;

namespace api.Inventory.Application
{
    [Serializable]
    internal class ProductCreationFailed : Exception
    {
        public ProductCreationFailed()
        {
        }

        public ProductCreationFailed(string message) : base(message)
        {
        }

        public ProductCreationFailed(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductCreationFailed(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}