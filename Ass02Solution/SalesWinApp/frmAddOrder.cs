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
    public partial class frmAddOrder : Form
    {
        public frmAddOrder()
        {
            InitializeComponent();
        }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IMemberRepository memberRepository = new MemberRepository(); 
        public IProductRepository productRepository = new ProductRepository();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Do you really want to add new order?", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    if (memberRepository.GetMemberByID(int.Parse(txtMemberId.Text)) == null)
                    {
                        throw new Exception("Member ID is not existed");

                    }
                    if(productRepository.GetProductByID(int.Parse(txtProductId.Text)) == null)
                    {
                        throw new Exception("Product ID is not existed");
                    }

                    
                    var orderObject = new OrderObject
                    {
                        
                        MemberId = int.Parse(txtMemberId.Text),
                        OrderDate = dtpOrderDate.Value,
                        RequiredDate = dtpRequiredDate.Value,
                        ShippedDate = dtpShippedDate.Value,
                        Freight = decimal.Parse(txtMemberId.Text)
                    };

                    OrderRepository.InsertOrder(orderObject);

                    OrderObject latestOrder = OrderRepository.GetLatestOrder();
                    var orderDetailObject = new OrderDetailObject
                    {
                        OrderId = latestOrder.OrderId, 
                        ProductId = int.Parse(txtProductId.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Discount = decimal.Parse(txtDiscount.Text)
                    };
                    
                    OrderDetailRepository.InsertOrderDetail(orderDetailObject);
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Add a new order" );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
