using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Configuration;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
            

        }
        string adminEmail;
        string adminPass;

        MemberObject memberInfo = new MemberObject();


        private void btnLogin_Click(object sender, EventArgs e)
        {  
            var email = txtEmail.Text;
            var pass = txtPass.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter Email and Password!!");
                return;
            }
            if (email.Equals(adminEmail) && pass.Equals(adminPass))
            {
                MessageBox.Show("Login by admin account successfully !!");
                Hide();
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.Show();
            }
                else if(memberRepository.GetMemberByEmailAndPassword(email,pass)!=null)
                {
                    memberInfo = memberRepository.GetMemberByEmailAndPassword(email, pass);
                    MessageBox.Show("Login by member account successfully !!");
                    frmMemberDetails frmMemberDetails = new frmMemberDetails
                    {
                        Text = "Update member",
                        InsertOrUpdate = true,
                        MemberRepository = memberRepository,
                        MemberInfo = memberInfo,
                        isMember = true
                    };
                    frmMemberDetails.Show();
                    
            }
            else
            {
                MessageBox.Show("Login failed !!!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {       
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            adminEmail = config["adminEmail"];
            adminPass = config["adminPassword"];     
        }
    }
}
