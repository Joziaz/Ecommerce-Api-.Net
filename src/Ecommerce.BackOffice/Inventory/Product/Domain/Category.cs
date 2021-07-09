using Ecommerce.Shared.Domain;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
    }
}