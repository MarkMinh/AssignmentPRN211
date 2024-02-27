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
        public OrderDetailDAO orderDetailDAO = OrderDetailDAO.Instance;
        public void DeleteOrderDetail(int OrderDetailId) => orderDetailDAO.Remove(OrderDetailId);
        

        public OrderDetailObject GetOrderDetailByID(int OrderId) => orderDetailDAO.GetOrderDetailByID(OrderId);
        

        public IEnumerable<OrderDetailObject> GetOrderDetails() => orderDetailDAO.GetOrderDetailList();
        

        public void InsertOrderDetail(OrderDetailObject OrderDetail) => orderDetailDAO.insertOrderDetail(OrderDetail);
        

        public void UpdateOrderDetail(OrderDetailObject OrderDetail) => orderDetailDAO.Update(OrderDetail);
        
    }
}
