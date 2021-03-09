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
    public partial class AddNewRoomfrm : Form
    {
        function fn = new function();
        String query;

        public AddNewRoomfrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            query = " select * from rooms where roomNo=" + txtbxAddnewRoomNumber.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                String status;
                if (chckbxYesANR.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                lblRoomExists.Visible = false;
                query = "insert into rooms (roomNo,roomStatus) values("+txtbxAddnewRoomNumber.Text+",'"+status+"')";
                fn.setData(query, "Room Added.");
                frmAddNewRoom_Load(this, null);
            }
            else
            {
                lblRoomExists.Text = "Room ALREADY Exists.";
                lblRoomExists.Visible = true;
            }
        }

        private void frmAddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350,170);
            lblRoomUpDel.Visible = false;
            lblRoomExists.Visible = false;

            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridViewALLRooms.DataSource = ds.Tables[0];
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtbxUpDelRoomNumber.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                lblRoomUpDel.Text = "Room does NOT Exist.";
                lblRoomUpDel.Visible = true;
                ChckbxYesUpDelRoom.Checked = false;
            }
            else
            {
                lblRoomUpDel.Text = "Room Found.";
                lblRoomUpDel.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    ChckbxYesUpDelRoom.Checked = true;
                }
                else
                {
                    ChckbxYesUpDelRoom.Checked = false;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataDridViewALLRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            String status;
            if (ChckbxYesUpDelRoom.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update rooms set roomStatus='" + status + "' where roomNo ="+txtbxUpDelRoomNumber.Text+"";
            fn.setData(query, "Details Updated.");
            frmAddNewRoom_Load(this, null);
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (lblRoomUpDel.Text=="Room Found.")
            {
                query = "delete from rooms where roomNo=" + txtbxUpDelRoomNumber.Text + "";
                fn.setData(query, "Room Deleted Successfully.");
                frmAddNewRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to Delete room which does Not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChckbxYesUpDelRoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
