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
    public partial class AllActiveEmployeesfrm : Form
    {
        function fn = new function();
        String query;
        public AllActiveEmployeesfrm()
        {
            InitializeComponent();
        }

        private void AllActiveEmployeesfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);

            query = "select * from newEmployee where working ='Yes'";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }
    }
}
