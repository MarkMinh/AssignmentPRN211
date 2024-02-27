using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public ProductObject ProductInfo { get; set; }
        public bool isMember { get; set; }
        private ProductObject GetProductObject()
        {
            ProductObject productObject = null;
            try
            {
                productObject = new ProductObject
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return productObject;
        }

        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        public void LoadProductList(IEnumerable<ProductObject> products)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductId.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = source;
                if (products.Count() == 0)
                {
                    ClearText();
                    if (!isMember)
                        btnDelete.Enabled = false;
                }
                else
                {
                    if (!isMember)
                        btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Product Detail",
                ProductInfo = GetProductObject(),
                ProductRepository = productRepository,
                InsertOrUpdate = true,
                isMember = isMember
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<ProductObject> products = productRepository.GetProducts();
                LoadProductList(products);
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            IEnumerable<ProductObject> products = productRepository.GetProducts();
            LoadProductList(products);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<ProductObject> products = productRepository.GetProducts();
                LoadProductList(products);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this product?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    var product = GetProductObject();
                    productRepository.DeleteProduct(product.ProductId);
                    IEnumerable<ProductObject> products = productRepository.GetProducts();
                    LoadProductList(products);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;
            if (isMember)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSearchId.Text.Trim()) <= 0)
                {
                    throw new Exception("Please input a positive integer");
                }
                try
                {
                    IEnumerable<ProductObject> products = productRepository.GetSearchProductById(int.Parse(txtSearchId.Text.Trim()));
                    LoadProductList(products);
                    if (products.Count() == 0)
                    {
                        throw new Exception("There's no product");
                    }
                }
                catch
                {
                    MessageBox.Show("There's no product", "Search Product");
                }

            }
            catch
            {
                MessageBox.Show("Please input a positive integer", "Search Product");
            }

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            IEnumerable<ProductObject> products = productRepository.GetSearchProductByName(txtSearchName.Text.Trim());
            if (products.Count() == 0)
            {
                MessageBox.Show("There's no product");
            }
            LoadProductList(products);
        }

        private void btnSearchUnitPrice_Click(object sender, EventArgs e)
        {
            IEnumerable<ProductObject> products = new List<ProductObject>();
            switch (cbUnitPrice.SelectedIndex)
            {
                case 0:  products = productRepository.GetSearchProductByUnitPrice(0, 100);
                break;
                case 1:  products = productRepository.GetSearchProductByUnitPrice(100, 1000);
                break;
                case 2:  products = productRepository.GetSearchProductByUnitPrice(1000, 10000);
                break;
                case 3:  products = productRepository.GetSearchProductByUnitPrice(10000);
                break;
                default:
                    throw new Exception("There's no product");
            }
            LoadProductList(products);
        }

        private void btnSearchUnitsInStock_Click(object sender, EventArgs e)
        {
            IEnumerable<ProductObject> products = new List<ProductObject>();
            switch (cbUnitsInStock.SelectedIndex)
            {
                case 0:
                    products = productRepository.GetSearchProductByUnitsInStock(0, 10);
                    break;
                case 1:
                    products = productRepository.GetSearchProductByUnitsInStock(10, 100);
                    break;
                case 2:
                    products = productRepository.GetSearchProductByUnitsInStock(100, 1000);
                    break;
                case 3:
                    products = productRepository.GetSearchProductByUnitsInStock(1000, 10000);
                    break;
                case 4:
                    products = productRepository.GetSearchProductByUnitsInStock(10000);
                    break;
                default:
                    throw new Exception("There's no product");
                  
            }
            LoadProductList(products);
        }
    }
}
