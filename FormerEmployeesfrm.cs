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
    public partial class FormerEmployeesfrm : Form
    {
        function fn = new function();
        String query;

        public FormerEmployeesfrm()
        {
            InitializeComponent();
        }

        private void FormerEmployeesfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);

            query = "select * from newEmployee where working = 'No'";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }
    }
}
