﻿using BurgerApp.Domain.Entities;

namespace BurgerApp.Domain.Repositories
{
    public interface IOrderRepository
    {
        IReadOnlyList<Order> GetAllOrders();
        Order GetOrderById (int id);
        void Remove (Order order);
        void Update (Order order);
        void Add (Order order);
    }
}
