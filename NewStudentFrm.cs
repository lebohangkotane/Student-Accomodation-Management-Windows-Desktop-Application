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
    public partial class NewStudentFrm : Form
    {
        function fn = new function();
        String query;
        public NewStudentFrm()
        {
            InitializeComponent();
        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxMNo.Text != "" && txtbxN.Text != "" && txtbxFN.Text != "" && txtbxMN.Text != "" && txtbxEm.Text != "" && txtbxPhyAdd.Text != "" && txtbxUni.Text != "" && cbxRN.SelectedIndex != -1 )
            {
                Int64 mobile = Int64.Parse(txtbxMNo.Text);
                String name = txtbxN.Text;
                String fname = txtbxFN.Text;
                String mname = txtbxMN.Text;
                String email = txtbxEm.Text;
                String address = txtbxPhyAdd.Text;
                String university = txtbxUni.Text;
                String id = txtbxIDNo.Text;
                Int64 roomNo = Int64.Parse(cbxRN.Text);

                query = "insert into  newStudent (mobile,name,fName,mName,email,pAddress,university,idNo,roomNo) values (" + mobile + ", '" + name + "', '" + fname + "', '" + mname + "', '" + email + "', '" + address + "', '" + university + "', '" + id + "' , " + roomNo + ") update rooms set Booked = 'Yes' where roomNo =" + roomNo + "";
                fn.setData(query, "Student Registration Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Alert!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudentFrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select roomNo from rooms where roomStatus = 'Yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                cbxRN.Items.Add(room);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtbxMNo.Clear();
            txtbxN.Clear();
            txtbxFN.Clear();
            txtbxMN.Clear();
            txtbxEm.Clear();
            txtbxPhyAdd.Clear();
            txtbxUni.Clear();
            txtbxIDNo.Clear();
            cbxRN.SelectedIndex = -1;

        }
    }
}
