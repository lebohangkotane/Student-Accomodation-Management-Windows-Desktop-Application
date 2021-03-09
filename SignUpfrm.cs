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
    public partial class SignUpfrm : Form
    {
        function fn = new function();
        String query; 
        public SignUpfrm()
        {
            InitializeComponent();
        }

        private void SignUpfrm_Load(object sender, EventArgs e)
        {
            if (true)
            {

            }
        }

        private void btnSignInCreate_Click(object sender, EventArgs e)
        {
            if (txtbxName.Text!="" && txtbxSurname.Text!="" && txtbxEmail.Text!="" && txtbxPassword.Text !="" && txtbxPsd2.Text!="")
            {
                
                if (txtbxPassword.Text==txtbxPsd2.Text)
                {
                    String name = txtbxName.Text;
                    String surname = txtbxSurname.Text;
                    String email = txtbxEmail.Text;
                    String username = txtbxUsername.Text;
                    String password = txtbxPsd2.Text;

                    query = "insert into users(names, surname, email,username, pssword) values (  '" + name + "', '" + surname + "','" + email + "', '"+username+"','" + password + "' )";
                    fn.setData(query, "Sign up successfully Completed");
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please chech again.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Fill all Required Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loginfrm l = new Loginfrm();
            l.Show();
        }
    }
}
