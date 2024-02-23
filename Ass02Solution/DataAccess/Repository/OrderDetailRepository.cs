using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int OrderDetailId)
        {
            throw new NotImplementedException();
        }

        public OrderDetailObject GetOrderDetailByID(int OrderDetailId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetailObject> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public void InsertOrderDetail(OrderDetailObject OrderDetail)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderDetail(OrderDetailObject OrderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
