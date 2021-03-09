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
    public partial class UpDelStudentfrm : Form
    {
        function fn = new function();
        String query; 

        public UpDelStudentfrm()
        {
            InitializeComponent();
        }

        private void UpDelStudentfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtbxMNo.Clear();
            txtbxN.Clear();
            txtbxFN.Clear();
            txtbxMN.Clear();
            txtbxEm.Clear();
            txtbxPhyAdd.Clear();
            txtbxUni.Clear();
            txtbxIDNo.Clear();
            txtbxRN.Clear();
            cbxLSts.SelectedIndex = -1;

        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            query = "select * from newStudent where idNo=" + txtbxIDNo.Text + " ";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count!=0)
            {
                txtbxMNo.Text = ds.Tables[0].Rows[0][1].ToString();
                txtbxN.Text = ds.Tables[0].Rows[0][2].ToString();
                txtbxFN.Text = ds.Tables[0].Rows[0][3].ToString();
                txtbxMN.Text = ds.Tables[0].Rows[0][4].ToString();
                txtbxEm.Text = ds.Tables[0].Rows[0][5].ToString();
                txtbxPhyAdd.Text = ds.Tables[0].Rows[0][6].ToString();
                txtbxUni.Text = ds.Tables[0].Rows[0][7].ToString();
                txtbxRN.Text = ds.Tables[0].Rows[0][9].ToString();
                cbxLSts.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtbxMNo.Text);
            String name = txtbxN.Text;
            String fname = txtbxFN.Text;
            String mname = txtbxMN.Text;
            String email = txtbxEm.Text;
            String address = txtbxPhyAdd.Text;
            String university = txtbxUni.Text;
            Int64 idNo = Int64.Parse(txtbxIDNo.Text);
            Int64 roomNo = Int64.Parse(txtbxRN.Text);
            String livingSt = cbxLSts.Text;

            query = "update newStudent set name='" + name + "',fname='"+fname+ "',mname='" + mname+"',email= '"+email+"',pAddress='"+address+"',university= '"+university+"',mobile= '"+mobile+"',roomNo='"+roomNo+"',living= '"+livingSt+"'where idNo ="+idNo+" update rooms set Booked ='"+livingSt+"' where roomNo= "+roomNo+"";
            fn.setData(query, "Data Succefully Updated."); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                 query = "delete from newStudent where idNo = " + txtbxIDNo.Text + "";
                 fn.setData(query, "Student Records Deleted.");
                 clearAll();
            }
         }
    }
}
