using System;

namespace Ecommerce.Shared.Domain.Exeptions
{
    public class NotFound : Exception
    {

        public NotFound(string message) : base(message)
        {
        }
    }
}