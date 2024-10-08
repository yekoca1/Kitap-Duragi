using System.Collections.Generic;
using KitapDuragi.entity;

namespace KitapDuragi.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}