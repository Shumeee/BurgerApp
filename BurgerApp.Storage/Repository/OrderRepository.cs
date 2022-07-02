using BurgerApp.Domain.Entities;
using BurgerApp.Domain.Repositories;
using BurgerApp.Storage.Database;

namespace BurgerApp.Storage.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IReadOnlyList<Order> GetAllOrders()
        {
            return BurgerDatabase.ORDERS;
        }
        public Order GetOrderById(int id)
        {
            return BurgerDatabase.ORDERS.FirstOrDefault(x => x.Id == id);
        }
        public void Remove(Order order)
        {
            BurgerDatabase.ORDERS.Remove(order);
        }

        public void Update(Order order)
        {
            int index = BurgerDatabase.ORDERS.FindIndex(x => x.Id == order.Id);
            BurgerDatabase.ORDERS[index] = order;
        }
        public void Add(Order order)
        {
            BurgerDatabase.ORDERS.Add(order);
        }
    }
}
