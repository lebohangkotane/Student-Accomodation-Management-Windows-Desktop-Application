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
    public partial class UpDelEmplfrm : Form
    {
        function fn = new function();
        String query;
        public UpDelEmplfrm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
            cbxWstatus.SelectedIndex = -1;
        }

        private void UpDelEmplfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350,170);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where idNo = " + txtbxIDNo.Text + "";
                fn.setData(query, "Employee Records Deleted.");
                clearAll();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where idNo="+txtbxIDNo.Text+"";
            DataSet ds = fn.getData(query);


           if (ds.Tables[0].Rows.Count!=0)
            {
                txtbxN.Text = ds.Tables[0].Rows[0][1].ToString();
                txtbxSur.Text = ds.Tables[0].Rows[0][2].ToString();
                txtbxMNo.Text = ds.Tables[0].Rows[0][3].ToString();
                txtbxEm.Text = ds.Tables[0].Rows[0][4].ToString();
                txtbxPhyAdd.Text = ds.Tables[0].Rows[0][5].ToString();
                txtbxEmpID.Text = ds.Tables[0].Rows[0][7].ToString();
                cbxjobDescrip.Text = ds.Tables[0].Rows[0][8].ToString();
                cbxWstatus.Text= ds.Tables[0].Rows[0][9].ToString();

            }
            else
            {
                MessageBox.Show("No Record Exists. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String name = txtbxN.Text;
            String surname = txtbxSur.Text;
            Int64 mobile = Int64.Parse(txtbxMNo.Text);
            String email = txtbxEm.Text;
            String address = txtbxPhyAdd.Text;
            Int64 idNo = Int64.Parse(txtbxIDNo.Text);
            Int64 emplID = Int64.Parse(txtbxEmpID.Text);
            String jobDescrip = cbxjobDescrip.Text;
            String working = cbxWstatus.Text;

            query = "update newEmployee set name='" + name + "',surname='" + surname + "',mobileNo='" + mobile + "',email= '" + email + "',phyAddress='" + address + "',employeeId= '" + emplID + "',jobDescrip='" + jobDescrip + "',working= '" + working + "'where idNo =" + idNo + "";
            fn.setData(query, "Data Updated successfully.");        
        }
    }
}
