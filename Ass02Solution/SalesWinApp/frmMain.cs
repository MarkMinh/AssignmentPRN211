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
        public bool isMember { get; set; }
        public MemberObject MemberInfo { get; set; }
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
            frmOrders frmOrders = new frmOrders();
            frmOrders.MdiParent = this;
            frmOrders.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.MdiParent = this;
            frmProducts.Show();
        }
    }
}
