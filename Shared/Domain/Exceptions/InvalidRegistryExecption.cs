using System;
using System.Runtime.Serialization;

namespace api.Shared.Domain.Exeptions
{
    public class InvalidRegistryExecption : Exception
    {
                
        public InvalidRegistryExecption()
        {
        }

        public InvalidRegistryExecption(string message) : base(message)
        {
        }

        public InvalidRegistryExecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidRegistryExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}