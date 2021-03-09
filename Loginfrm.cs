using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class Loginfrm : Form
    {
        function fn = new function();
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (txtbxUsername.Text.Length>0 && txtbxPassword.Text.Length>0)
            {
                String success = "Access Granted";
                String uname = txtbxUsername.Text;
                String pword = txtbxPassword.Text;
                String access = userCheck(uname,pword );

                if (access == success)
                {
                    this.Hide();
                    Dashboardfrm f = new Dashboardfrm();
                    f.Show();
                }
                else
                {
                    MessageBox.Show(access);
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordfrm fp = new ForgotPasswordfrm();
            fp.Show();
        }

        private void lblForgotPassword_Click_1(object sender, EventArgs e)
        {
            ForgotPasswordfrm fp = new ForgotPasswordfrm();
            fp.Show();
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpfrm su = new SignUpfrm();
            su.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public String userCheck(String a, String b)
        {
            String success = "Access Granted";
            String failed = "Accesss Denied";

            String query1 = "select * from users where username = '" + a + "' and pssword = '" + b + "'";
            DataSet ds = fn.getData(query1);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return failed;
            }
            else
            {
                return success;
            }
        }
    }
}
