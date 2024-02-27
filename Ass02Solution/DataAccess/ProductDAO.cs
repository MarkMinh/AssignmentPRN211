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
    public class ProductDAO : BaseDAL
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public ProductDAO() { }

        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }

                    return instance;
                }
            }
        }

        public IEnumerable<ProductObject> GetProductList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }



        public IEnumerable<ProductObject> GetSearchProductById(int productId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where ProductId = @ProductId";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public IEnumerable<ProductObject> GetSearchProductByUnitPrice(decimal unitPrice)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where UnitPrice > @UnitPrice ";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@UnitPrice", 4, unitPrice, DbType.Decimal);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public IEnumerable<ProductObject> GetSearchProductByUnitPrice(decimal unitPriceStart, decimal unitPriceEnd)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where UnitPrice > @UnitPrice1 and UnitPrice < @UnitPrice2";
            var products = new List<ProductObject>();
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@UnitPrice1", 50, unitPriceStart, DbType.Decimal),
                        dataProvider.CreateParameter("@UnitPrice2", 50, unitPriceEnd, DbType.Decimal)
                     };
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public IEnumerable<ProductObject> GetSearchProductByUnitsInStock(int unitsInStockStart, int unitsInStockEnd)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where UnitsInStock > @UnitsInStock1 and UnitsInStock < @UnitsInStock2";
            var products = new List<ProductObject>();
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@UnitsInStock1", 50, unitsInStockStart, DbType.Int32),
                        dataProvider.CreateParameter("@UnitsInStock2", 50, unitsInStockEnd, DbType.Int32)
                     };
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public IEnumerable<ProductObject> GetSearchProductByUnitsInStock(int unitsInStock)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where UnitsInStock > @UnitsInStock";
            var products = new List<ProductObject>();
            try
            {
                var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@UnitsInStock", 50, unitsInStock, DbType.Int32),
                     };
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public IEnumerable<ProductObject> GetSearchProductByName(string name)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Product where ProductName LIKE @SearchName";
            var products = new List<ProductObject>();
            try
            {
                var param = dataProvider.CreateParameter("@SearchName", 50,string.Concat("%",name,"%"), DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return products;
        }

        public ProductObject GetProductByID(int ProductId)
        {
            ProductObject Product = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * " +
                "from Product where ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, ProductId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    Product = new ProductObject
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
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
            return Product;
        }
        public void insertProduct(ProductObject Product)
        {
            try
            {
                ProductObject pro = GetProductByID(Product.ProductId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Product values(@ProductId,@CategoryId,@ProductName,@Weight,@UnitPrice,@UnitsInStock)";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@ProductId", 4, Product.ProductId, DbType.Int32),
                        dataProvider.CreateParameter("@CategoryId", 50, Product.CategoryId, DbType.Int32),
                        dataProvider.CreateParameter("@ProductName", 50, Product.ProductName, DbType.String),
                        dataProvider.CreateParameter("@Weight", 50, Product.Weight, DbType.String),
                        dataProvider.CreateParameter("@UnitPrice", 50, Product.UnitPrice, DbType.Decimal),
                        dataProvider.CreateParameter("@UnitsInStock", 50, Product.UnitsInStock, DbType.Int32)
                    };
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("The Product is already exist.");
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

        public void Update(ProductObject Product)
        {
            try
            {
                ProductObject pro = GetProductByID(Product.ProductId);
                if (pro != null)
                {
                    string SQLUpdate = "Update Product set CategoryId = @CategoryId,ProductName = @ProductName," +
                        "Weight = @Weight,UnitPrice=@UnitPrice,UnitsInStock=@UnitsInStock where ProductId=@ProductId";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@ProductId", 4, Product.ProductId, DbType.Int32),
                        dataProvider.CreateParameter("@CategoryId", 50, Product.CategoryId, DbType.Int32),
                        dataProvider.CreateParameter("@ProductName", 50, Product.ProductName, DbType.String),
                        dataProvider.CreateParameter("@Weight", 50, Product.Weight, DbType.String),
                        dataProvider.CreateParameter("@UnitPrice", 50, Product.UnitPrice, DbType.Decimal),
                        dataProvider.CreateParameter("@UnitsInStock", 50, Product.UnitsInStock, DbType.Int32)
                    };
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The Product does not exist.");
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

        public void Remove(int ProductId)
        {
            try
            {
                ProductObject Product = GetProductByID(ProductId);
                if (Product != null)
                {
                    string SQLDelete = "Delete Product where ProductId = @ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 4, Product.ProductId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The Product does not already exist.");
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
