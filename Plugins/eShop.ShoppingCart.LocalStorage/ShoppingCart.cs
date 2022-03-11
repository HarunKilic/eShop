using eShop.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace eShop.ShoppingCart.LocalStorage;

public class ShoppingCart : IShoppingCart
{
    private const string cstrShoppingCart = "eShop.ShoppingCart";
    private readonly IJSRuntime _jsRuntime;
    private readonly IProductRepository _productRepository;

    public ShoppingCart(IJSRuntime jsRuntime,
        IProductRepository productRepository)
    {
        _jsRuntime = jsRuntime;
        _productRepository = productRepository;
    }

    public async Task<Order> GetOrderAsync()
    {
        return await GetOrder();
    }

    public async Task<Order> AddProductAsync(Product product)
    {
        var order = await GetOrder();
        order.AddProduct(product.ProductId, 1, product.Price);
        await SetOrder(order);

        return order;
    }

    public async Task<Order> UpdateQuantityAsync(int productId,
        int quantity)
    {
        var order = await GetOrder();
        switch (quantity)
        {
            case < 0:
                return order;
            case 0:
                return await DeleteProductAsync(productId);
        }

        var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
        if (lineItem != null) lineItem.Quantity = quantity;

        await SetOrder(order);

        return order;
    }

    public async Task<Order> UpdateOrderAsync(Order order)
    {
        await SetOrder(order);
        return order;
    }

    public async Task<Order> DeleteProductAsync(int productId)
    {
        var order = await GetOrder();
        order.RemoveProduct(productId);
        await SetOrder(order);

        return order;
    }

    public async Task<Order> PlaceOrderAsync()
    {
        throw new NotImplementedException();
    }

    public async Task EmptyAsync()
    {
        await SetOrder(null);
    }

    private async Task<Order> GetOrder()
    {
        Order order = null;

        var strOder = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);

        if (!string.IsNullOrWhiteSpace(strOder) && strOder.ToLower() != "null")
        {
            order = JsonConvert.DeserializeObject<Order>(strOder);
        }
        else
        {
            order = new Order();
            await SetOrder(order);
        }

        foreach (var item in order.LineItems) item.Product = _productRepository.GetProduct(item.ProductId);

        return order;
    }

    private async Task SetOrder(Order order)
    {
        await _jsRuntime.InvokeVoidAsync(
            "localStorage.setItem",
            cstrShoppingCart,
            JsonConvert.SerializeObject(order));
    }
}