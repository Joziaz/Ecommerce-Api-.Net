using Ecommerce.Shared.Domain;

namespace BackOffice.Inventory.User.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PassWord { get; private set; }
    }
}
