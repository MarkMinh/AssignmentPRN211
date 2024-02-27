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
    public partial class frmOrderDetails : Form
    {
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        public OrderDetailObject OrderDetailInfo { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public bool ViewOrUpdate { get; set; }
        public bool isMember { get; set; }
        public bool isRedirect { get; set; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result; 
                result = MessageBox.Show("Do you really want to update this order detail?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var orderDetailObject = new OrderDetailObject
                    {
                        OrderId = int.Parse(txtOrderId.Text),
                        ProductId = int.Parse(txtProductId.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Discount = decimal.Parse(txtDiscount.Text),
                    };
                    
                    OrderDetailRepository.UpdateOrderDetail(orderDetailObject);
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update a order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = OrderDetailInfo.OrderId.ToString();
            txtProductId.Text = OrderDetailInfo.ProductId.ToString();
            txtUnitPrice.Text = OrderDetailInfo.UnitPrice.ToString();
            txtQuantity.Text = OrderDetailInfo.Quantity.ToString();
            txtDiscount.Text = OrderDetailInfo.Discount.ToString();

            txtUnitPrice.Enabled = false;
            txtQuantity.Enabled = false;
            txtDiscount.Enabled = false;
            if (isMember)
            {
                btnUpdate.Enabled = false;
                cUpdate.Visible = false;
            }
            if(isRedirect)
            {
                cUpdate.Visible = false;
            }
        }

        private void cUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (!isMember)
            {
                btnUpdate.Enabled = cUpdate.Checked;
            }
            
            
            if (!isMember)
            {
                if (cUpdate.Checked)
                {
                    txtUnitPrice.Enabled = true;
                    txtQuantity.Enabled = true;
                    txtDiscount.Enabled = true;
                }
                else
                {
                    txtUnitPrice.Enabled = false;
                    txtQuantity.Enabled = false;
                    txtDiscount.Enabled = false;
                }
            }
            
        }
    }
}
