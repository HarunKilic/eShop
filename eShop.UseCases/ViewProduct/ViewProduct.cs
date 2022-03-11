using eShop.Core.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.ViewProduct.Interfaces;

namespace eShop.UseCases.ViewProduct;

public class ViewProduct : IViewProduct
{
    private readonly IProductRepository _productRepository;

    public ViewProduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product Execute(int id)
    {
        return _productRepository.GetProduct(id);
    }
}