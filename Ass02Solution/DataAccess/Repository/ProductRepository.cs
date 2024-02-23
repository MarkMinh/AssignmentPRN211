using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public ProductObject GetProductByID(int ProductId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductObject> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(ProductObject Product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductObject Product)
        {
            throw new NotImplementedException();
        }
    }
}
