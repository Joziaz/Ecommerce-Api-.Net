using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.ShoppingCarts.Infrastucture;
using Ecommerce.Shop.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shop.ShoppingCarts.Application
{
    public class ShoppingCartService
    {
        private readonly UnitOfShoppingCart Unit;

        public ShoppingCartService(UnitOfShoppingCart unit)
        {
            Unit = unit;
        }

        public IEnumerable<CartItem> GetCartItems(User user) => Unit.CartItemRepository.GetUserCartItems(user);

        public async Task AddItemAsync(User user, Product product, uint quantity)
        {
            var item = await Unit.CartItemRepository.GetCartItemAsync(user, product);
            if (item == null)
            {
                var newItem = new CartItem(user, product, quantity);
                await Unit.CartItemRepository.Create(newItem);
            }
            else
            {
                item.AddQuantity(quantity);
                await Unit.CartItemRepository.Update(item);
            }
        }

        public async Task RemoveItem(User user, Product product)
        {
            var item = await Unit.CartItemRepository.GetCartItemAsync(user, product);

            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the cart");

            await Unit.CartItemRepository.Delete(item.Id);
        }

        public async Task UpdateItemAsync(User user, Product product, uint quantity)
        {
            var item = await Unit.CartItemRepository.GetCartItemAsync(user, product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the cart");

            item.UpdateQuantity(quantity);
            await Unit.CartItemRepository.Update(item);
        }

        public void DeleteItems(User user)
        {
            Unit.CartItemRepository.DeleteUserCartItems(user);
        }
    }
}
