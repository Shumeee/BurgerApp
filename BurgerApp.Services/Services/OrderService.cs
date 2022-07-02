using BurgerApp.Contracts.Services;
using BurgerApp.Contracts.ViewModels;
using BurgerApp.Domain.Entities;
using BurgerApp.Domain.Repositories;
using BurgerApp.Services.Mappers;

namespace BurgerApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IReadOnlyList<OrderViewModel> GetAllOrders()
        {
            IReadOnlyList<Order> orders = _orderRepository.GetAllOrders();
            return orders.Select(x => x.ToOrderViewModel()).ToArray();
        }

        public Order GetOrderById(int id)
        {
            IReadOnlyList<Order> orders = _orderRepository.GetAllOrders();
            return orders.FirstOrDefault(x => x.Id == id);
        }

        public void EditOrder(OrderViewModel order)
        {
            Order orderToUpdate = _orderRepository.GetOrderById(order.Id);

            orderToUpdate.FullName = order.FullName;
            orderToUpdate.Address = order.Address;
            orderToUpdate.Location = order.Location;
            orderToUpdate.IsDelievered = order.IsDelievered;

            _orderRepository.Update(orderToUpdate);
        }

        public void DeleteOrder(int id)
        {
            Order order = _orderRepository.GetOrderById(id);

            _orderRepository.Remove(order);
        }

        public void AddOrder(OrderViewModel order)
        {
            int index = _orderRepository.GetAllOrders().Count() + 1;
            Order newOrder = new Order(index, order.FullName, order.Address, order.IsDelievered, order.Burgers, order.Location);

            _orderRepository.Add(newOrder);
        }
    }
}
