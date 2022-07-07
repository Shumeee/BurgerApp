using BurgerApp.Contracts.Services;
using BurgerApp.Domain.Repositories;
using BurgerApp.Services;
using BurgerApp.Storage.Database.Context;
using BurgerApp.Storage.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// EntityFramework Database
string databaseConnectionString = builder.Configuration.GetConnectionString("Database"); // Getting the connection string

builder.Services.AddScoped<IOrderService, OrderService>() // This is the dependency injection
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IBurgerService, BurgerService>()
                .AddScoped<IBurgerRepository, BurgerRepository>()
                .AddDbContext<BurgerDbContext>(options =>
                {
                    options.UseSqlServer(databaseConnectionString); // Passing the connection string
                })
                .AddScoped<IBurgerDbContext, BurgerDbContext>();

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
