using System.Runtime.ExceptionServices;
using System;
using System.Runtime.Serialization;

namespace api.Shared.Domain.Exeptions
{
    public class RegistryNotFoundException : Exception
    {
                
        public RegistryNotFoundException()
        {
        }

        public RegistryNotFoundException(string message) : base(message)
        {
        }

        public RegistryNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RegistryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}