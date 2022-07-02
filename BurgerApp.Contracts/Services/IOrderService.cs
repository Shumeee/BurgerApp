using BurgerApp.Contracts.ViewModels;
using BurgerApp.Domain.Entities;

namespace BurgerApp.Contracts.Services
{
    public interface IOrderService
    {
        IReadOnlyList<OrderViewModel> GetAllOrders();
        Order GetOrderById(int id);
        void EditOrder(OrderViewModel order);
        void DeleteOrder(int id);
        void AddOrder(OrderViewModel order);
    }
}
