using Ecommerce.Shared.Domain.Enums;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shop.Orders.Domain;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.ShoppingCarts.Domain;
using Ecommerce.Shop.ShoppingCarts.Infrastucture;
using Ecommerce.Shop.Stocks.Application;
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
        private readonly UnitOfShoppingCart _unit;
        private readonly StockService _stockService;

        public ShoppingCartService(UnitOfShoppingCart unit, StockService stockService)
        {
            _unit = unit;
            _stockService = stockService;
        }

        public IEnumerable<CartItem> GetCartItems(User user) => _unit.CartItemRepository.GetUserCartItems(user);

        public async Task AddItem(User user, Product product, uint quantity)
        {
            var item = await _unit.CartItemRepository.GetCartItem(user, product);
            if (item == null)
            {
                var newItem = new CartItem(user, product, quantity);
                await _unit.CartItemRepository.Create(newItem);
            }
            else
            {
                item.AddQuantity(quantity);
                await _unit.CartItemRepository.Update(item);
            }
        }

        public async Task RemoveItem(User user, Product product)
        {
            var item = await _unit.CartItemRepository.GetCartItem(user, product);

            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the cart");

            await _unit.CartItemRepository.Delete(item.Id);
        }

        public async Task UpdateItem(User user, Product product, uint quantity)
        {
            var item = await _unit.CartItemRepository.GetCartItem(user, product);
            if (item == null)
                throw new RegistryNotFoundException("Product don't found in the cart");

            item.UpdateQuantity(quantity);
            await _unit.CartItemRepository.Update(item);
        }

        public async Task DeleteItems(User user)
        {
            await _unit.CartItemRepository.DeleteUserCartItems(user);
        }

        public async Task CheckOut(User user)
        {

            using var transaction = await _unit.BeginTransaction();
            var Tasks = new List<Task>();

            try
            {
                var items = GetCartItems(user);
                var order = new Order(user, OrderStatus.InProcess);

                foreach (var item in items)
                {
                    order.AddItem(item.Product, item.Quantity);
                    Tasks.Add(_stockService.SubstractStock(item.Product, item.Quantity));
                }

                await Task.WhenAll(Tasks);
                await _unit.OrderRepository.Create(order);
                await DeleteItems(user);

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }

        }
    }
}
