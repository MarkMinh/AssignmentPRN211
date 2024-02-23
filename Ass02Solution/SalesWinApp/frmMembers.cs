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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            IEnumerable<MemberObject> members = memberRepository.GetMembers();
            LoadMemberList(members);
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {

            //txtMemberId.Enabled = !InsertOrUpdate;
            //if (InsertOrUpdate == true)
            //{
            //    txtMemberId.Text = MemberInfo.MemberId.ToString().Trim();           
            //    txtEmail.Text = MemberInfo.Email.ToString().Trim();
            //    txtCompany.Text = MemberInfo.CompanyName.ToString().Trim();
            //    txtPassword.Text = MemberInfo.Password.ToString().Trim();
            //    txtCity.Text = MemberInfo.City.ToString().Trim();
            //    txtCountry.Text = MemberInfo.Country.ToString().Trim();
            //}
            btnDelete.Enabled = false;
            dgvMembers.CellDoubleClick += DgvMembers_CellDoubleClick;

        }

        private void DgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<MemberObject> members = memberRepository.GetMembers();
                LoadMemberList(members);
                source.Position = source.Count - 1;
            }
        }

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompany.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberObject;
        }

        public void LoadMemberList(IEnumerable<MemberObject> members)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberId.DataBindings.Clear();
                txtCompany.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtCompany.DataBindings.Add("Text", source, "CompanyName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMembers.DataSource = null;
                dgvMembers.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<MemberObject> members = memberRepository.GetMembers();
                LoadMemberList(members);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this member?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    IEnumerable<MemberObject> members = memberRepository.GetMembers();
                    var member = GetMemberObject();
                    memberRepository.DeleteMember(member.MemberId);
                    LoadMemberList(members);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }
    }
}
