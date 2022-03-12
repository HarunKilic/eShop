using eShop.Core.Models;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCart.Interfaces;

namespace eShop.UseCases.ShoppingCart;
public class ViewShoppingCart : IViewShoppingCart
{
    private readonly IShoppingCart shoppingCart;

    public ViewShoppingCart(IShoppingCart shoppingCart)
    {
        this.shoppingCart = shoppingCart;
    }

    public Task<Order> Execute()
    {
        return shoppingCart.GetOrderAsync();
    }
}
