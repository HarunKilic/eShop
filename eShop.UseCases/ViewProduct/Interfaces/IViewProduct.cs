using eShop.Core.Models;

namespace eShop.UseCases.ViewProduct.Interfaces;

public interface IViewProduct
{
    Product Execute(int id);
}