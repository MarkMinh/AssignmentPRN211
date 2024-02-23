using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetOrders();
        OrderObject GetOrderByID(int OrderId);
        void InsertOrder(OrderObject Order);
        void DeleteOrder(int OrderId);
        void UpdateOrder(OrderObject Order);
    }
}
