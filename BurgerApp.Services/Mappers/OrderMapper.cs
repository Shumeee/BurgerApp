using BurgerApp.Contracts.ViewModels;
using BurgerApp.Domain.Entities;

namespace BurgerApp.Services.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelievered = order.IsDelievered,
                Burgers = order.Burgers,
                Location = order.Location
            };
        }
        public static OrderListViewModel ToOrderListViewModel(this List<Order> orders)
        {
            return new OrderListViewModel
            {
                Orders = orders.Select(x => x.ToOrderViewModel()).ToList()
            };
        }
    }
}
