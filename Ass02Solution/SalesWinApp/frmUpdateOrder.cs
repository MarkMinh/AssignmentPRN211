using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmUpdateOrder : Form
    {
        public frmUpdateOrder()
        {
            InitializeComponent();
        }

        public OrderObject OrderInfo { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public bool isMember {  get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;    
                result = MessageBox.Show("Do you really want to update this order?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    var orderObject = new OrderObject
                    {
                        OrderId = int.Parse(txtOrderId.Text),
                        MemberId = int.Parse(txtMemberId.Text),
                        OrderDate = DateTime.Parse(txtOrderDate.Text),
                        RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    
                    OrderRepository.UpdateOrder(orderObject);
                 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update a order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = OrderInfo.OrderId.ToString();
            txtMemberId.Text = OrderInfo.MemberId.ToString();
            txtOrderDate.Text = OrderInfo.OrderDate.ToString();
            txtRequiredDate.Text = OrderInfo.RequiredDate.ToString();
            txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
            txtFreight.Text = OrderInfo.Freight.ToString();
        }
    }
}
