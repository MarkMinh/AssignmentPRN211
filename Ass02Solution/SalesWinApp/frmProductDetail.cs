using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        public ProductObject ProductInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public bool isMember { get; set; }
        public IProductRepository ProductRepository { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                if (InsertOrUpdate == true)
                {
                    result = MessageBox.Show("Do you really want to update this product?", "Confirmation", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Do you really want to add new product?", "Confirmation", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    var productObject = new ProductObject
                    {
                        ProductId = int.Parse(txtProductId.Text),
                        CategoryId = int.Parse(txtCategoryId.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text)
                    };
                    if (InsertOrUpdate == false)
                    {
                        ProductRepository.InsertProduct(productObject);
                    }
                    else
                    {
                        ProductRepository.UpdateProduct(productObject);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (isMember)
            {
                txtProductId.Enabled = false;
                txtProductName.Enabled = false;
                txtCategoryId.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitsInStock.Enabled = false;
                txtWeight.Enabled = false;
                btnSave.Enabled = false;
            }
            
            if (InsertOrUpdate == true)
            {
               
                txtProductId.Text = ProductInfo.ProductId.ToString();
                txtCategoryId.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName.ToString();
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
                txtWeight.Text = ProductInfo.Weight.ToString();
                txtProductId.Enabled = false;
            }
        }
    }
}
