using System.Collections.Generic;
using KitapDuragi.entity;

namespace KitapDuragi.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}