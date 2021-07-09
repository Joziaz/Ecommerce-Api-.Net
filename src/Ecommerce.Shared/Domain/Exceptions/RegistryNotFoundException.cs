using System;

namespace Ecommerce.Shared.Domain.Exeptions
{
    public class RegistryNotFoundException : Exception
    {

        public RegistryNotFoundException(string message) : base(message)
        {
        }
    }
}