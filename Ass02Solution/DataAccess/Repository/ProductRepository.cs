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
        public ProductDAO productDAO = ProductDAO.Instance;
        public void DeleteProduct(int ProductId) => productDAO.Remove(ProductId);
        

        public ProductObject GetProductByID(int ProductId) => productDAO.GetProductByID(ProductId);
        

        public IEnumerable<ProductObject> GetProducts() => productDAO.GetProductList();

        public IEnumerable<ProductObject> GetSearchProductById(int id) => productDAO.GetSearchProductById(id);
        

        public IEnumerable<ProductObject> GetSearchProductByName(string name) => productDAO.GetSearchProductByName(name);

        public IEnumerable<ProductObject> GetSearchProductByUnitPrice(decimal unitPrice)
        => productDAO.GetSearchProductByUnitPrice(unitPrice);

        public IEnumerable<ProductObject> GetSearchProductByUnitPrice(decimal unitPriceStart, decimal unitPriceEnd)
        => productDAO.GetSearchProductByUnitPrice(unitPriceStart, unitPriceEnd);

        public IEnumerable<ProductObject> GetSearchProductByUnitsInStock(int unitsInStock)
        => productDAO.GetSearchProductByUnitsInStock(unitsInStock);

        public IEnumerable<ProductObject> GetSearchProductByUnitsInStock(int unitsInStockStart, int unitsInStockEnd)
        => productDAO.GetSearchProductByUnitsInStock(unitsInStockStart, unitsInStockEnd);

        public void InsertProduct(ProductObject Product) => productDAO.insertProduct(Product);


        public void UpdateProduct(ProductObject Product) => productDAO.Update(Product);
        
    }
}
