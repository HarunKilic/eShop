using eShop.DataStore;
using eShop.ShoppingCart.LocalStorage;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.SearchProduct;
using eShop.UseCases.ShoppingCart;
using eShop.UseCases.ShoppingCart.Interfaces;
using eShop.UseCases.ViewProduct;
using eShop.UseCases.ViewProduct.Interfaces;
using eShop.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>();

builder.Services.AddTransient<IViewProduct, ViewProduct>();
builder.Services.AddTransient<ISearchProduct, SearchProduct>();
builder.Services.AddTransient<IAddProductToCart, AddProductToCart>();
builder.Services.AddTransient<IViewShoppingCart, ViewShoppingCart>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();