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
    public partial class StudentFeesfrm : Form
    {
        function fn = new function();
        String query;

        public StudentFeesfrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtbxRN.Clear();
            dgrid.DataSource = 0;
            txtbxAmountD.Clear();
        }

        private void StudentFeesfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
            dtePickMonth.Format = DateTimePickerFormat.Custom;
            dtePickMonth.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtbxIDNo.Text !="")
            {
                query = "select name, email, roomNo from newStudent where idNo = "+ txtbxIDNo.Text+"";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtbxN.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtbxEm.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtbxRN.Text = ds.Tables[0].Rows[0][2].ToString();
                    SetdataGrid(Int64.Parse(txtbxIDNo.Text));
                }
                else
                {
                    MessageBox.Show("No Record Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        public void SetdataGrid(Int64 idNo)
        {
            query = "select * from fees where idNo =" + idNo + "";
            DataSet ds1 = fn.getData(query);
            dgrid.DataSource = ds1.Tables[0];

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtbxIDNo.Text != "" && txtbxAmountD.Text != "")
            {
                query = "select * from fees where idNo = " + Int64.Parse(txtbxIDNo.Text) + " and fmonth= '"+dtePickMonth.Text+"'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count==0)
                {
                    Int64 idNo = Int64.Parse(txtbxIDNo.Text);
                    String month = dtePickMonth.Text;
                    Int64 amount = Int64.Parse(txtbxAmountD.Text);

                    query = "insert into fees values(" + idNo + ", '" + month + "', " + amount + ")";
                    fn.setData(query, "Fees Successfully Paid.");
                    ClearAll();

                }
                else
                {
                    MessageBox.Show("Month Already paid Fully for the month of " + dtePickMonth.Text + ".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearAll();
                }
            }
        }
    }
}
