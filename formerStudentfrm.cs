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
    public partial class formerStudentfrm : Form
    {
        function fn = new function();
        String query;

        public formerStudentfrm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void formerStudentfrm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350,170);

            query = "select * from newStudent where living = 'No'";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }
    }
}
