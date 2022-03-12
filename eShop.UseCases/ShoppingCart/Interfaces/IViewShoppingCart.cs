using eShop.Core.Models;

namespace eShop.UseCases.ShoppingCart.Interfaces;

public interface IViewShoppingCart
{
    Task<Order> Execute();
}