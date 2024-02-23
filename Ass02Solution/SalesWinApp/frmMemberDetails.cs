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
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        public MemberObject MemberInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public bool isMember {  get; set; }
        public IMemberRepository MemberRepository { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                if (InsertOrUpdate == true)
                {
                    result = MessageBox.Show("Do you really want to update your profile?", "Confirmation", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Do you really want to add new member?", "Confirmation", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    var memberObject = new MemberObject
                    {
                        MemberId = int.Parse(txtMemberId.Text),
                        CompanyName = txtCompany.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    };
                    if (InsertOrUpdate == false)
                    {
                        MemberRepository.InsertMember(memberObject);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(memberObject);
                    }
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
            
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {

            txtMemberId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberId.Text = MemberInfo.MemberId.ToString();
                txtCompany.Text = MemberInfo.CompanyName.ToString();
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPassword.Text = MemberInfo.Password.ToString();
                txtCity.Text = MemberInfo.City.Trim();
                txtCountry.Text = MemberInfo.Country.Trim();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
