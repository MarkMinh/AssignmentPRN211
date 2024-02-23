using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int OrderId)
        {
            throw new NotImplementedException();
        }

        public OrderObject GetOrderByID(int OrderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderObject> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(OrderObject Order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(OrderObject Order)
        {
            throw new NotImplementedException();
        }
    }
}
