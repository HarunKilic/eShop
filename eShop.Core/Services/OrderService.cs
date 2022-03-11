using eShop.Core.Models;
using eShop.Core.Services.Interfaces;

namespace eShop.Core.Services;

public class OrderService : IOrderService
{
    public bool ValidatecustomerInformation(
        string name,
        string address,
        string city,
        string province,
        string country)
    {
        return !string.IsNullOrWhiteSpace(name) &&
               !string.IsNullOrWhiteSpace(address) &&
               !string.IsNullOrWhiteSpace(city) &&
               !string.IsNullOrWhiteSpace(province) &&
               !string.IsNullOrWhiteSpace(country);
    }

    public bool ValidateCreateOrder(Order order)
    {
        // Order has to exist and order has line items
        if (order is not {LineItems: {Count: > 0}}) return false;

        // Validating line items
        if (order.LineItems.Any(item => item.ProductId <= 0 || item.Price < 0 || item.Quantity <= 0)) return false;

        // Validating customer info
        return ValidatecustomerInformation(order.CustomerName,
            order.CustomerAddress,
            order.CustomerCity,
            order.CustomerStateProvince,
            order.CustomerCountry);
    }

    public bool ValidateUpdateOrder(Order order)
    {
        if (order is not {OrderId: { }, LineItems: {Count: > 0}, DatePlaced: { }}) return false;

        if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

        if (string.IsNullOrWhiteSpace(order.UniqueId)) return false;

        // Validating line items
        if (order.LineItems.Any(item =>
                item.ProductId <= 0 ||
                item.Price < 0 ||
                item.Quantity <= 0 ||
                item.OrderId != order.OrderId
            ))
            return false;

        // Validating customer info
        return ValidatecustomerInformation(order.CustomerName,
            order.CustomerAddress,
            order.CustomerCity,
            order.CustomerStateProvince,
            order.CustomerCountry);
    }

    public bool ValidateProcessOrder(Order order)
    {
        return order.DateProcessed.HasValue && !string.IsNullOrWhiteSpace(order.AdminUser);
    }
}