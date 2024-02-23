using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
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
            var pass = txtPassword.Text;
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
                frmMain frmMain = new frmMain() 
                {
                    Text = "Main",
                    isMember = false,
                    MemberRepository = memberRepository
                };

                frmMain.Show();
            }
            else if (memberRepository.GetMemberByEmailAndPassword(email, pass) != null)
            {
                memberInfo = memberRepository.GetMemberByEmailAndPassword(email, pass);
                MessageBox.Show("Login by member account successfully !!");
                Hide();
                frmMain frmMain = new frmMain()
                {
                    Text = "Main",
                    isMember = true,
                    MemberInfo = memberInfo,
                    MemberRepository = memberRepository
                };

                frmMain.Show();

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
