using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Infrastucture
{
    public class ShoppingCartRepository : CRUDRepository<ShoppingCart>
    {
        public ShoppingCartRepository(PContext context) : base(context)
        {
        }
    }
}
