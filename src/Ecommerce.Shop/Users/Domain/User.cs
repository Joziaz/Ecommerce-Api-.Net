using Ecommerce.Shared.Domain;

namespace Ecommerce.Shop.Users.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PassWord { get; private set; }
    }
}
