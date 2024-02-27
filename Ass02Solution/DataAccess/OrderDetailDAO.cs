using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public OrderDetailDAO() { }

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }

                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetailObject> GetOrderDetailList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from OrderDetail";
            var OrderDetails = new List<OrderDetailObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    OrderDetails.Add(new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDecimal(4)
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
            return OrderDetails;
        }

        public OrderDetailObject GetOrderDetailByID(int OrderId)
        {
            OrderDetailObject OrderDetail = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * " +
                "from OrderDetail where OrderId = @OrderId";
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, OrderId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    OrderDetail = new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDecimal(4)
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
            return OrderDetail;
        }
        public void insertOrderDetail(OrderDetailObject OrderDetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByID(OrderDetail.OrderId);
                if (pro == null)
                {
                    string SQLInsert = "Insert OrderDetail values(@OrderId,@ProductId,@UnitPrice,@Quantity,@Discount)";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@OrderId", 4, OrderDetail.OrderId, DbType.Int32),
                        dataProvider.CreateParameter("@ProductId", 50, OrderDetail.ProductId, DbType.Int32),
                        dataProvider.CreateParameter("@UnitPrice", 50, OrderDetail.UnitPrice, DbType.String),
                        dataProvider.CreateParameter("@Quantity", 50, OrderDetail.Quantity, DbType.String),
                        dataProvider.CreateParameter("@Discount", 50, OrderDetail.Discount, DbType.Decimal)         
                    };
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
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

        public void Update(OrderDetailObject OrderDetail)
        {
            try
            {
                OrderDetailObject pro = GetOrderDetailByID(OrderDetail.OrderId);
                if (pro != null)
                {
                    string SQLUpdate = "Update OrderDetail set ProductId = @ProductId,UnitPrice = @UnitPrice," +
                        "Quantity = @Quantity,Discount=@Discount where OrderId=@OrderId";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@OrderId", 4, OrderDetail.OrderId, DbType.Int32),
                        dataProvider.CreateParameter("@ProductId", 50, OrderDetail.ProductId, DbType.Int32),
                        dataProvider.CreateParameter("@UnitPrice", 50, OrderDetail.UnitPrice, DbType.String),
                        dataProvider.CreateParameter("@Quantity", 50, OrderDetail.Quantity, DbType.String),
                        dataProvider.CreateParameter("@Discount", 50, OrderDetail.Discount, DbType.Decimal)
                    };
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The OrderDetail does not exist.");
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
                OrderDetailObject OrderDetail = GetOrderDetailByID(OrderId);
                if (OrderDetail != null)
                {
                    string SQLDelete = "Delete OrderDetail where OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, OrderDetail.OrderId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
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

