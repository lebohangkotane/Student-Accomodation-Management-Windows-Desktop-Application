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
    public partial class ForgotPasswordfrm : Form
    {
        function fn = new function();
        String query;
        public ForgotPasswordfrm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordfrm_Load(object sender, EventArgs e)
        {
            txtbxPassword.Visible = false;
            txtbxPsd2.Visible = false;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Loginfrm li = new Loginfrm();
            li.Show();
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpfrm sup = new SignUpfrm();
            sup.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String username = txtbxUsername.Text;
            String email = txtbxEmail.Text;
            query = "select * from users where username ='" +username+ "' and email =" +email+ "";
            DataSet ds = fn.getData(query);

            //query = "update rooms set roomStatus='" + status + "' where roomNo =" + txtbxUpDelRoomNumber.Text + "";
            //fn.setData(query, "Details Updated.");
            //frmAddNewRoom_Load(this, null);

            if (ds.Tables[0].Rows.Count == 1)
            {
                // New Password Textboxes show
                txtbxPassword.Visible = true;
                txtbxPsd2.Visible = true;

                String password = txtbxPassword.Text;
                String password2 = txtbxPsd2.Text;

                if (password == password2)
                {
                    query = "update users set pssword='" + password + " where=username";
                    fn.setData(query, "Passwords Updated successfully.");
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please Check again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Username and/or password is not found or is Incorrect. Please Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
