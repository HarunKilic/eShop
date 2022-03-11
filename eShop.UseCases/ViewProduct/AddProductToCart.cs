using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ViewProduct.Interfaces;

namespace eShop.UseCases.ViewProduct;

public class AddProductToCart : IAddProductToCart
{
    private readonly IProductRepository _productRepository;
    private readonly IShoppingCart _shoppingCart;

    public AddProductToCart(IProductRepository productRepository,
        IShoppingCart shoppingCart)
    {
        _productRepository = productRepository;
        _shoppingCart = shoppingCart;
    }

    public async void Execute(int productId)
    {
        var product = _productRepository.GetProduct(productId);
        await _shoppingCart.AddProductAsync(product);
    }
}