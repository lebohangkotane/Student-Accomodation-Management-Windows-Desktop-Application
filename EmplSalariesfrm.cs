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
    public partial class EmplSalariesfrm : Form
    {
        function fn = new function();
        String query;
        public EmplSalariesfrm()
        {
            InitializeComponent();
        }

        private void dtePickMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmplSalariesfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
            dtePickMonth.Format = DateTimePickerFormat.Custom;
            dtePickMonth.CustomFormat = "MMMM yyyy";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void ClearAll()
        {
            txtbxIDNo.Clear();
            txtbxN.Clear();
            txtbxEm.Clear();
            cbxjobDescrip.SelectedIndex = -1;
            dgrid.DataSource = 0;
            txtbxSalaryPay.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtbxIDNo.Text != "" && txtbxSalaryPay.Text != "")
            {
                query = "select * from employeeSalary where idNo = " + Int64.Parse(txtbxIDNo.Text) + " and sMonth= '" + dtePickMonth.Text + "'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 idNo = Int64.Parse(txtbxIDNo.Text);
                    String month = dtePickMonth.Text;
                    Int64 amount = Int64.Parse(txtbxSalaryPay.Text);

                    query = "insert into employeeSalary values(" + idNo + ", '" + month + "', " + amount + ")";
                    fn.setData(query, "Salary Successfully Paid for month of "+month+".");
                    SetdataGrid(idNo);
                }
                else
                {
                    MessageBox.Show("Month Salary Already paid Fully for the month of " + dtePickMonth.Text + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearAll();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtbxIDNo.Text != "")
            {
                query = "select name, email, jobDescrip from NewEmployee where idNo = " + txtbxIDNo.Text + "";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtbxN.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtbxEm.Text = ds.Tables[0].Rows[0][1].ToString();
                    cbxjobDescrip.Text = ds.Tables[0].Rows[0][2].ToString();
                    
                    SetdataGrid(Int64.Parse(txtbxIDNo.Text));
                }
                else
                {
                    MessageBox.Show("No Record Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All Revelent information needed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SetdataGrid(Int64 idNo)
        {
            query = "select * from employeeSalary where idNo =" + idNo + "";
            DataSet ds1 = fn.getData(query);
            dgrid.DataSource = ds1.Tables[0];

        }
    }
}
