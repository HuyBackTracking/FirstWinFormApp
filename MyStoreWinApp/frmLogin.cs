using DataAcess.Repository;
using Nancy.Json;
using Newtonsoft.Json.Converters;
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
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader("E:\\Kudvenkat_Mastery\\Ass01Solution\\MyStoreWinApp\\appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var obj = jss.Deserialize<dynamic>(json);
            var admin = new BusinessObject.MemberObject
            {
                Email = obj["DefaultAccount"]["Email"],
                PassWord = obj["DefaultAccount"]["password"]
            };
            var members = memberRepository.GetMemberList();
            bool isMem = false;
            foreach (var item in members)
            {
                if (item.Email.Equals(txtUser.Text) && item.PassWord.Equals(txtPass.Text))
                {
                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = false
                    };
                    frm.ShowDialog();
                    isMem = true;
                    this.Close();
                    break;
                }
                else if (admin.Email.Equals(txtUser.Text) && admin.PassWord.Equals(txtPass.Text))
                {

                    frmMemberManagement frm = new frmMemberManagement()
                    {
                        isAdmin = true
                    };
                    frm.ShowDialog();
                    isMem = true;
                    this.Close();
                    break;
                }
            }
            if (isMem == true)
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Login failed, enter email and password again!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
