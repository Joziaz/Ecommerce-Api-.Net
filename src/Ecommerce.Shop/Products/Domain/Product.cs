using Ecommerce.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Products.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public float Price { get; private set; }
        public float DiscountPrice { get; private set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
