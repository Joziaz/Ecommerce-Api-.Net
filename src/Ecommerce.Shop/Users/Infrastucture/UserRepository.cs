﻿using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Users.Infrastucture
{
    public class UserRepository : CRUDRepository<User>, IUserRepository
    {
        public UserRepository(PContext context) : base(context)
        {
        }
    }
}
