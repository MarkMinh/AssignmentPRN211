using BusinessObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public OrderDAO orderDAO = OrderDAO.Instance;
        public void DeleteOrder(int OrderId) => orderDAO.Remove(OrderId);

        public OrderObject GetLatestOrder() => orderDAO.GetLatestOrder();
        

        public OrderObject GetOrderByID(int OrderId) => orderDAO.GetOrderByID(OrderId);

        public IEnumerable<OrderObject> GetOrderByMember(int memberId) => orderDAO.GetOrderByMember(memberId);
       

        public IEnumerable<Hashtable> GetOrderHashtableEnumerable() => orderDAO.GetOrderHashtableEnumerable();



        public IEnumerable<OrderObject> GetOrders() => orderDAO.GetOrderList();

        public IEnumerable<OrderObject> GetOrderStatistics(DateTime startDate, DateTime endDate)
         => orderDAO.GetOrderStatistic(startDate, endDate);

        public IEnumerable<OrderObject> GetOrderStatisticsByMember(DateTime startDate, DateTime endDate, int memberId)
        => orderDAO.GetOrderStatisticByMember(startDate, endDate, memberId);

        public void InsertOrder(OrderObject Order) => orderDAO.insertOrder(Order);
        

        public void UpdateOrder(OrderObject Order) => orderDAO.Update(Order);
        
    }
}
