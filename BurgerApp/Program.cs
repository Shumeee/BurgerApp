using BurgerApp.Contracts.Services;
using BurgerApp.Domain.Repositories;
using BurgerApp.Services;
using BurgerApp.Storage.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IOrderService, OrderService>() // This is the dependency injection
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IBurgerService, BurgerService>()
                .AddScoped<IBurgerRepository, BurgerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
