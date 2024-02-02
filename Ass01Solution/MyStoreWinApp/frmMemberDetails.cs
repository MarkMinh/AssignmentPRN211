using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public MemberObject MemberInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public bool isMember { get; set; }
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
                        MemberID = int.Parse(txtMemberID.Text),
                        MemberName = txtMemberName.Text,
                        Email = txtEmail.Text,
                        Password = txtPass.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    };
                    if (InsertOrUpdate == false)
                    {
                        MemberRepository.AddNewMember(memberObject);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(memberObject);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (isMember)
            {
                btnCancel.Text = "Log Out";
            }
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = MemberInfo.MemberID.ToString();
                txtMemberName.Text = MemberInfo.MemberName;
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPass.Text = MemberInfo.Password.ToString();
                txtCity.Text = MemberInfo.City.Trim();
                txtCountry.Text = MemberInfo.Country.Trim();
            }

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
