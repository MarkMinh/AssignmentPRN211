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
    public partial class frmBuy : Form
    {
        public frmBuy()
        {
            InitializeComponent();
        }
        public MemberObject MemberInfo { get; set; }
        public ProductObject ProductInfo { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public OrderDetailObject OrderDetailInfo { get; set; }
        public OrderObject OrderInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                int requiredDays = 0;
                try
                {
                    requiredDays = int.Parse(txtRequiredDays.Text);
                }catch (Exception ex)
                {
                    MessageBox.Show("Please input an integer!!");
                }

                result = MessageBox.Show("Do you really want to buy this product?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    OrderInfo.OrderDate = DateTime.Now;
                    OrderInfo.RequiredDate = DateTime.Now.AddDays(requiredDays);
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a new member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
