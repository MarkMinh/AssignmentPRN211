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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        IProductRepository productRepository = new ProductRepository();
        public bool isMember { get; set; }
        public MemberObject MemberInfo { get; set; }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if(!isMember)
            {
                IEnumerable<OrderObject> orderStatistics = orderRepository.GetOrderStatistics(dtpFrom.Value, dtpTo.Value);
                LoadOrderList(orderStatistics);
            }
            else
            {
                IEnumerable<OrderObject> orderStatistics = orderRepository.GetOrderStatisticsByMember(dtpFrom.Value, dtpTo.Value, MemberInfo.MemberId);
                LoadOrderList(orderStatistics);
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

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void DgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                Text = "Order Detail",
                //InsertOrUpdate = true,
                OrderDetailInfo = orderDetailRepository.GetOrderDetailByID(GetOrderObject().OrderId),
                OrderRepository = orderRepository,
                OrderDetailRepository = orderDetailRepository,
                isMember = isMember,
                isRedirect = true
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<OrderObject> orders = orderRepository.GetOrders();
                LoadOrderList(orders);
                source.Position = source.Count - 1;
            }
        }



        private void frmStatistic_Load(object sender, EventArgs e)
        {
            dgvOrders.CellDoubleClick += DgvOrder_CellDoubleClick;
            IEnumerable<OrderObject> orderObjects = orderRepository.GetOrders();
            LoadOrderList(orderObjects);
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (!isMember)
            {
                IEnumerable<OrderObject> orderStatistics = orderRepository.GetOrderStatistics(dtpFrom.Value, dtpTo.Value);
                LoadOrderList(orderStatistics);
            }
            else
            {
                IEnumerable<OrderObject> orderStatistics = orderRepository.GetOrderStatisticsByMember(dtpFrom.Value, dtpTo.Value, MemberInfo.MemberId);
                LoadOrderList(orderStatistics);
            }
            
        }
    }
}
