using eShop.Core.Models;

namespace eShop.UseCases.SearchProduct;

public interface ISearchProduct
{
    IEnumerable<Product> Execute(string filter);
}