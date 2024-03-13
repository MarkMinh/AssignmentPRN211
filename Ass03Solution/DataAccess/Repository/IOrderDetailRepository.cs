using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetOrderDetails();
        OrderDetailObject GetOrderDetailByID(int OrderDetailId);
        void InsertOrderDetail(OrderDetailObject OrderDetail);
        void DeleteOrderDetail(int OrderDetailId);
        void UpdateOrderDetail(OrderDetailObject OrderDetail);
    }
}
