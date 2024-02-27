using BusinessObject;
using DataAccess.Repository;
using System.Reflection;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public bool isMember { get; set; }
        public MemberObject MemberInfo { get; set; }
        public ProductObject ProductInfo { get; set; }
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isMember)
            {
                frmMembers frmMembers = new frmMembers();
                frmMembers.MdiParent = this;
                frmMembers.Show();
            }
            else
            {
                frmMemberDetails frmMemberDetails = new frmMemberDetails
                {
                    Text = "Update member",
                    InsertOrUpdate = true,
                    MemberRepository = MemberRepository,
                    MemberInfo = MemberRepository.GetMemberByID(MemberInfo.MemberId),
                    isMember = true
                };
                frmMemberDetails.MdiParent = this;
                frmMemberDetails.Show();

            }

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isMember)
            {
                frmOrders frmOrders = new frmOrders()
                {
                    isMember = false
                };
                frmOrders.MdiParent = this;
                frmOrders.Show();
            }
            else
            {
                frmOrders frmOrders = new frmOrders()
                {
                    isMember = true,
                    MemberInfo = MemberInfo
                };
                frmOrders.MdiParent = this;
                frmOrders.Show();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isMember)
            {
                frmProducts frmProducts = new frmProducts()
                {
                    isMember = false
                };
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            else
            {
                frmProducts frmProducts = new frmProducts()
                {
                    isMember = true
                };
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }

        }



        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void statisticsToolStripMenuItem_EnabledChanged(object sender, EventArgs e)
        {
            frmStatistic frmStatistic = new frmStatistic();
            frmStatistic.MdiParent = this;
            frmStatistic.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatistic frmStatistic = new frmStatistic()
            {
                isMember = isMember,
                MemberInfo = MemberInfo
            };
            frmStatistic.MdiParent = this;
            frmStatistic.Show();

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
