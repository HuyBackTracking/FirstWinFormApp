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
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberObject { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            //cbCity.SelectedIndex = 0;
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = MemberObject.MemberID.ToString();
                txtName.Text = MemberObject.MemberName;
                cbCity.Text = MemberObject.City;
                cbCountry.Text = MemberObject.Country;
                txtEmail.Text = MemberObject.Email;
                txtPass.Text = MemberObject.PassWord;
            }
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject()
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    PassWord = txtPass.Text,
                    City = cbCity.Text,
                    Country = cbCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.InsertMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
