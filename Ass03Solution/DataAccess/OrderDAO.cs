using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO : BaseDAL
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }

                    return instance;
                }
            }
        }

        public IEnumerable<OrderObject> GetOrderList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from [Order]";
            var Orders = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    Orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Orders;
        }

        public IEnumerable<Hashtable> GetOrderHashtableEnumerable()
        {
            IEnumerable<OrderObject> orderList = GetOrderList();

            foreach (OrderObject orderObject in orderList)
            {
                // Tạo một Hashtable mới cho mỗi đơn hàng
                Hashtable orderHashtable = new Hashtable();

                // Thêm OrderObject vào Hashtable với khóa "Order"
                orderHashtable.Add("Order", orderObject);

                // Lấy OrderDetailObject tương ứng với đơn hàng từ OrderDetailRepository hoặc từ nguồn dữ liệu khác
                OrderDetailObject orderDetailObject = orderDetailRepository.GetOrderDetailByID(orderObject.OrderId);

                // Thêm OrderDetailObject vào Hashtable với khóa "OrderDetail"
                orderHashtable.Add("OrderDetail", orderDetailObject);

                // Sử dụng yield return để trả về từng Hashtable một cách tuần tự
                yield return orderHashtable;
            }
        }

        public OrderObject GetLatestOrder()
        {
            OrderObject Order = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select top 1* from [Order] order by OrderId desc";
            try
            {
                
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                if (dataReader.Read())
                {
                    Order = new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Order;
        }

        public IEnumerable<OrderObject> GetOrderStatistic(DateTime startDate, DateTime endDate)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM [Order] where OrderDate > @StartDate and OrderDate < @EndDate order by OrderDate desc";
            var Orders = new List<OrderObject>();
            try
            {
                var parameters = new List<SqlParameter>
                {
                    dataProvider.CreateParameter("@StartDate", 50, startDate, DbType.DateTime),
                    dataProvider.CreateParameter("@EndDate", 50, endDate, DbType.DateTime)
                };
                
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
            
                while (dataReader.Read())
                {
                    Orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Orders;
        }

        public IEnumerable<OrderObject> GetOrderStatisticByMember(DateTime startDate, DateTime endDate, int memberId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM [Order] where OrderDate > @StartDate and OrderDate < @EndDate and memberId = @MemberId order by OrderDate desc";
            var Orders = new List<OrderObject>();
            try
            {
                var parameters = new List<SqlParameter>
                {
                    dataProvider.CreateParameter("@StartDate", 50, startDate, DbType.DateTime),
                    dataProvider.CreateParameter("@EndDate", 50, endDate, DbType.DateTime),
                    dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32)
                };

                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());

                while (dataReader.Read())
                {
                    Orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Orders;
        }

        public IEnumerable<OrderObject> GetOrderByMember(int memberId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT * FROM [Order] where MemberId = @MemberId";
            var Orders = new List<OrderObject>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);

                while (dataReader.Read())
                {
                    Orders.Add(new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Orders;
        }

        public OrderObject GetOrderByID(int OrderId)
        {
            OrderObject Order = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * " +
                "from [Order] where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    Order = new OrderObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Order;
        }
        public void insertOrder(OrderObject Order)
        {
            try
            {
                OrderObject pro = GetOrderByID(Order.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "Insert [Order] values(@MemberId,@OrderDate,@RequiredDate,@ShippedDate,@Freight)";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@MemberId", 50, Order.MemberId, DbType.Int32),
                        dataProvider.CreateParameter("@OrderDate", 50, Order.OrderDate, DbType.DateTime),
                        dataProvider.CreateParameter("@RequiredDate", 50, Order.RequiredDate, DbType.DateTime),
                        dataProvider.CreateParameter("@ShippedDate", 50, Order.ShippedDate, DbType.DateTime),
                        dataProvider.CreateParameter("@Freight", 50, Order.Freight, DbType.Decimal)
                    };
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("The Order is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(OrderObject Order)
        {
            try
            {
                OrderObject pro = GetOrderByID(Order.OrderId);
                if (pro != null)
                {
                    string SQLUpdate = "Update [Order] set MemberId = @MemberId,OrderDate = @OrderDate," +
                        "RequiredDate = @RequiredDate,ShippedDate=@ShippedDate,Freight=@Freight where OrderId=@OrderId";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@OrderId", 4, Order.OrderId, DbType.Int32),
                        dataProvider.CreateParameter("@MemberId", 50, Order.MemberId, DbType.Int32),
                        dataProvider.CreateParameter("@OrderDate", 50, Order.OrderDate, DbType.DateTime),
                        dataProvider.CreateParameter("@RequiredDate", 50, Order.RequiredDate, DbType.DateTime),
                        dataProvider.CreateParameter("@ShippedDate", 50, Order.ShippedDate, DbType.DateTime),
                        dataProvider.CreateParameter("@Freight", 50, Order.Freight, DbType.Decimal)
                    };
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Order does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int OrderId)
        {
            try
            {
                OrderObject Order = GetOrderByID(OrderId);
                if (Order != null)
                {
                    string SQLDelete = "Delete [Order] where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, Order.OrderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

