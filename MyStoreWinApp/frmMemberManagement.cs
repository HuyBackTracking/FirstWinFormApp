using BusinessObject;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public bool isAdmin { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                cbCity.Enabled = false;
                cbCountry.Enabled = false;
                txtEmail.Enabled = false;
                txtMemberID.Enabled = false;
                txtPass.Enabled = false;
                txtSearch.Enabled = false;
                dataGridView1.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
                dataGridView1.CellDoubleClick += DgvMemberList;
            }
        }

        private void DgvMemberList(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Update",
                InsertOrUpdate = true,
                MemberObject = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
                source.Position = source.Count - 1;
            }
        }

        public MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtName.Text,
                    PassWord = txtPass.Text,
                    City = cbCity.Text,
                    Country = cbCountry.Text,
                    Email = txtEmail.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return memberObject;
        }

        private void button6_Click(object sender, EventArgs e) => this.Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMember();
        }

        public void LoadMember()
        {
            var members = memberRepository.GetMemberList();
            try
            {
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.MemberName);
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtName.DataBindings.Clear();
                cbCountry.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                cbCity.DataBindings.Clear();


                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtPass.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                cbCity.DataBindings.Add("Text", source, "City");
                cbCountry.DataBindings.Add("Text", source, "Country");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                if (isAdmin == false)
                {
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
                else
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            cbCountry.Text = string.Empty;
            txtPass.Text = string.Empty;
            cbCity.Text = string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "New member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMember();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                try
                {
                    var member = GetMemberObject();
                    DialogResult result = MessageBox.Show("Do you want really to delete", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        memberRepository.DeleteMember(member.MemberID);
                        LoadMember();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void LoadSearch()
        {
            MemberObject member = new MemberObject();
            var members = memberRepository.GetMemberList();
            try
            {
                foreach (var item in members)
                {
                    if (item.MemberName.ToLower().Equals(txtSearch.Text.ToLower()))
                    {
                        source = new BindingSource();
                        source.DataSource = memberRepository.GetMemberbyID(item.MemberID);
                        txtMemberID.DataBindings.Clear();
                        txtEmail.DataBindings.Clear();
                        txtName.DataBindings.Clear();
                        cbCountry.DataBindings.Clear();
                        txtPass.DataBindings.Clear();
                        cbCity.DataBindings.Clear();


                        txtMemberID.DataBindings.Add("Text", source, "MemberID");
                        txtName.DataBindings.Add("Text", source, "MemberName");
                        txtPass.DataBindings.Add("Text", source, "Password");
                        txtEmail.DataBindings.Add("Text", source, "Email");
                        cbCity.DataBindings.Add("Text", source, "City");
                        cbCountry.DataBindings.Add("Text", source, "Country");

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = source;
                        break;
                    }
                    else if (item.MemberID.ToString().Equals(txtSearch.Text))
                    {
                        source = new BindingSource();
                        source.DataSource = memberRepository.GetMemberbyID(item.MemberID);
                        txtMemberID.DataBindings.Clear();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
