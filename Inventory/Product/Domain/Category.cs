using api.Shared.Domain;

namespace api.Inventory.Domain
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