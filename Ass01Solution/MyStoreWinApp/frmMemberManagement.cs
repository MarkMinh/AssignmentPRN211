using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        int modeFilter = 0;
        
        public frmMemberManagement()
        {
            InitializeComponent();

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbCity_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<MemberObject> members = memberRepository.GetAllMembers();
            LoadMemberList(members);
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
                List<MemberObject> members = memberRepository.GetAllMembers();
                LoadMemberList(members);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this member?", "Confirmation", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    List<MemberObject> members = memberRepository.GetAllMembers();
                    var member = GetMemberObject();
                    memberRepository.DeleteMember(member.MemberID);
                    LoadMemberList(members);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a car");
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPass.Text,
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

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        public void LoadMemberList(List<MemberObject> members)
        {

            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPass.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
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

        private void DgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmCarDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                List<MemberObject> members = memberRepository.GetAllMembers();
                LoadMemberList(members);
                source.Position = source.Count - 1;
            }
        }



        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvMember.CellDoubleClick += DgvMember_CellDoubleClick;
            LoadCountries(modeFilter);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            List<MemberObject> membersSort = memberRepository.SortMemberListDescendingName();
            LoadMemberList(membersSort);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberObject> membersSearch = memberRepository.SearchMembersByName(txtSearchID.Text);
            LoadMemberList(membersSearch);
        }

        public void LoadCountries(int mode)
        {
            if (mode == 0)
            {
                return;
            }
            List<string> countryLists = memberRepository.GetDistinctCountriesOfMembers();
            cbCountry.DataSource = countryLists;
        }

        public void LoadCities(int mode)
        {
            if (mode == 0) { return; }
            List<string> cityLists = memberRepository.GetCity(txtCountry.Text);
            cbCity.DataSource = cityLists;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem as string != null)
            {
                string country = cb.SelectedItem as string;
                List<MemberObject> membersFilter = memberRepository.FilterListByCountry(country);
                LoadMemberList(membersFilter);
            }
        }

        private void cbCountry_Click(object sender, EventArgs e)
        {

        }

        private void cbCountry_DropDown(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MemberObject member = null;
            try
            {
                member = memberRepository.GetMemberByID(int.Parse(txtSearchID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a number");
            }
            if (member != null)
            {
                List<MemberObject> membersSearch = new List<MemberObject> { member };
                LoadMemberList(membersSearch);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<MemberObject> membersSearch = memberRepository.SearchMembersByName(txtSearchName.Text);
            

            LoadMemberList(membersSearch);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadCountries(1);
        }

        private void cbCity_DropDown(object sender, EventArgs e)
        {
            LoadCities(1);
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem as string != null)
            {
                string city = cb.SelectedItem as string;
                List<MemberObject> membersFilter = memberRepository.FilterListByCity(txtCountry.Text,city);
                LoadMemberList(membersFilter);
            }
        }
    }
}
