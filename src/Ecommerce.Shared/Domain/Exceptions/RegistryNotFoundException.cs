using System.Runtime.ExceptionServices;
using System;
using System.Runtime.Serialization;

namespace Ecommerce.Shared.Domain.Exeptions
{
    public class RegistryNotFoundException : Exception
    {

        public RegistryNotFoundException(string message) : base(message)
        {
        }
    }
}