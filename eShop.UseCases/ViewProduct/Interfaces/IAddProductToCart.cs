namespace eShop.UseCases.ViewProduct.Interfaces;

public interface IAddProductToCart
{
    void Execute(int productId);
}