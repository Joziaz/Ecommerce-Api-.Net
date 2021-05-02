using System;
using System.Runtime.Serialization;

namespace api.Inventory.Domain
{
    [Serializable]
    internal class QuantityInvalid : Exception
    {
        public QuantityInvalid()
        {
        }

        public QuantityInvalid(string message) : base(message)
        {
        }

        public QuantityInvalid(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QuantityInvalid(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}