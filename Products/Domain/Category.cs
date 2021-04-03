using api.Shared.Domain;

namespace api.Products.Domain
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