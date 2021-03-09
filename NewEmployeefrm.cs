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
    public partial class NewEmployeefrm : Form
    {
        function fn = new function();
        String query;
        public NewEmployeefrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployeefrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxN.Text !="" && txtbxSur.Text != "" && txtbxPhyAdd.Text != "" && txtbxMNo.Text != "" && txtbxEmpID.Text != "" && txtbxEm.Text != "" && txtbxIDNo.Text != "" && cbxjobDescrip.Text != "" )
            {
                String name = txtbxN.Text;
                String surname = txtbxSur.Text;
                Int64 mobile = Int64.Parse(txtbxMNo.Text);
                String email = txtbxEm.Text;
                String address = txtbxPhyAdd.Text;
                Int64 idNo = Int64.Parse(txtbxIDNo.Text);
                Int64 employId = Int64.Parse(txtbxEmpID.Text);
                String jobD = cbxjobDescrip.Text;

                query = "insert into newEmployee(name, surname, mobileNo, email, phyAddress, idNo, employeeId, jobDescrip) values (  '" + name+"', '"+surname+"', '"+mobile+"', '"+email+"', '"+address+"', "+idNo+", "+employId+", '"+jobD+"' )";
                fn.setData(query, "Employee Successfully Registered");
                                       
            }
            else
            {
                MessageBox.Show("Fill all Required Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtbxMNo.Clear();
            txtbxN.Clear();
            txtbxEm.Clear();
            txtbxEmpID.Clear();
            txtbxPhyAdd.Clear();
            txtbxSur.Clear();
            txtbxIDNo.Clear();
            cbxjobDescrip.SelectedIndex = -1;

        }

        private void txtbxIDNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

                

        }
    }
}
