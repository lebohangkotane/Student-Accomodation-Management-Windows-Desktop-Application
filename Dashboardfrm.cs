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
    public partial class Dashboardfrm : Form
    {
        public Dashboardfrm()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AllStudentsLiving asl = new AllStudentsLiving();
            asl.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loginfrm f2 = new Loginfrm();
            f2.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Boolean labelVisible = true;
        private void timr1_Tick(object sender, EventArgs e)
        {
            if (labelVisible==true)
            {
                lblSAS.Visible = true;
                labelVisible = false;
            }
            else
            {

                lblSAS.Visible = false;
                labelVisible = true;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timr1.Enabled = true;
            timr1.Start();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoomfrm anr = new AddNewRoomfrm();
            anr.Show();
        }

        private void btnUpDelEmployee_Click(object sender, EventArgs e)
        {
            UpDelEmplfrm udem = new UpDelEmplfrm();
            udem.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudentFrm ns = new NewStudentFrm();
            ns.Show();
        }

        private void btnUpDel_Click(object sender, EventArgs e)
        {
            UpDelStudentfrm uds = new UpDelStudentfrm();
            uds.Show(); 
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFeesfrm sf = new StudentFeesfrm();
            sf.Show();
        }

        private void btnFormerTenants_Click(object sender, EventArgs e)
        {
            formerStudentfrm fst = new formerStudentfrm();
            fst.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployeefrm ne = new NewEmployeefrm();
            ne.Show();

        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            EmplSalariesfrm es = new EmplSalariesfrm();
            es.Show();

        }

        private void btnAllEmpl_Click(object sender, EventArgs e)
        {
            AllActiveEmployeesfrm aae = new AllActiveEmployeesfrm();
            aae.Show();
        }

        private void btnFormerEmpl_Click(object sender, EventArgs e)
        {
            FormerEmployeesfrm fe = new FormerEmployeesfrm();
            fe.Show();

        }
    }
}
