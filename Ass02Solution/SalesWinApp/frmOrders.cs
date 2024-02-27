using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IProductRepository productRepository = new ProductRepository();
        public bool isMember {  get; set; }
        public bool ViewOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!isMember)
            {
                IEnumerable<OrderObject> orderObjects = orderRepository.GetOrders();
                LoadOrderList(orderObjects);
            }
            else
            {
                IEnumerable<OrderObject> orderObjects = orderRepository.GetOrderByMember(MemberInfo.MemberId);
                LoadOrderList(orderObjects);
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddOrder frmAddOrder = new frmAddOrder
            {
                Text = "Add order",
                OrderRepository = orderRepository,
                OrderDetailRepository = orderDetailRepository,
            };
            if (frmAddOrder.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<OrderObject> orders = orderRepository.GetOrders();
                LoadOrderList(orders);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this order?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {


                    var order = GetOrderObject();
                    orderDetailRepository.DeleteOrderDetail(order.OrderId);
                    orderRepository.DeleteOrder(order.OrderId);
                    IEnumerable<OrderObject> orders = orderRepository.GetOrders();
                    LoadOrderList(orders);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order");
            }
        }

        private OrderObject GetOrderObject()
        {
            OrderObject orderObject = null;


            try
            {
                orderObject = new OrderObject
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = int.Parse(txtMemberId.Text)
                };


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return orderObject;
        }



        private void ClearText()
        {
            txtOrderId.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
            txtShippedDate.Text = string.Empty;


        }

        public void LoadOrderList(IEnumerable<OrderObject> orders)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderId.DataBindings.Clear();
                txtMemberId.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();


                txtOrderId.DataBindings.Add("Text", source, "OrderId");
                txtMemberId.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");


                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;
                if (orders.Count() == 0)
                {
                    ClearText();
                    if(!isMember)
                    btnDelete.Enabled = false;
                }
                else
                {
                    if(!isMember)
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void DgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                Text = "Order Detail",
                //InsertOrUpdate = true,
                OrderDetailInfo = orderDetailRepository.GetOrderDetailByID(GetOrderObject().OrderId),
                OrderRepository = orderRepository,
                OrderDetailRepository = orderDetailRepository,
                isMember = isMember
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<OrderObject> orders = orderRepository.GetOrders();
                LoadOrderList(orders);
                source.Position = source.Count - 1;
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = false;
            txtMemberId.Enabled = false;
            txtRequiredDate.Enabled = false;
            txtShippedDate.Enabled = false;
            txtOrderDate.Enabled = false;
            txtFreight.Enabled = false;
            btnDelete.Enabled = false;
            dgvOrders.CellDoubleClick += DgvOrders_CellDoubleClick;
            if (isMember)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateOrder frmUpdateOrder = new frmUpdateOrder
            {
                Text = "Update Order",
                OrderInfo = GetOrderObject(),
                OrderRepository = orderRepository
            };
            if (frmUpdateOrder.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<OrderObject> orders = orderRepository.GetOrders();
                LoadOrderList(orders);
                source.Position = source.Count - 1;
            }
        }
    }
}
