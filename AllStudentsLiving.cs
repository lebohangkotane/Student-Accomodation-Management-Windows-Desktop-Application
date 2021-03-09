﻿using System;
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
    public partial class AllStudentsLiving : Form
    {
        function fn = new function();
        String query;
        public AllStudentsLiving()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AllStudentsLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);

            query = "select * from newStudent where living ='Yes'";
            DataSet ds = fn.getData(query);
            datagrid.DataSource = ds.Tables[0];
        }
    }
}
