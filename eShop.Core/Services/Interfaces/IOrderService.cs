using eShop.Core.Models;

namespace eShop.Core.Services.Interfaces;

public interface IOrderService
{
    bool ValidatecustomerInformation(
        string name,
        string address,
        string city,
        string province,
        string country);

    bool ValidateCreateOrder(Order order);
    bool ValidateUpdateOrder(Order order);
    bool ValidateProcessOrder(Order order);
}