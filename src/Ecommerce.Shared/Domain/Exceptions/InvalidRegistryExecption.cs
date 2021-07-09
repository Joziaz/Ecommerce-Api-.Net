using System;

namespace Ecommerce.Shared.Domain.Exeptions
{
    public class InvalidRegistryExecption : Exception
    {
        public InvalidRegistryExecption(string message) : base(message)
        {
        }
    }
}