using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductByID(int ProductId);
        void InsertProduct(ProductObject Product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(ProductObject Product);
    }
}
