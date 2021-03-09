using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HostelManagementSystem
{
    public partial class SplashScreenFrm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int ntopRect,
            int RightRect,
            int nbottomRect,
            int nWidthEllipse,
            int nHieghtEllipse
            );

        public SplashScreenFrm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularPB.Value = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void SplashScreenFrm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularPB.Value += 1;
            circularPB.Text = circularPB.Value.ToString() + "%";

            if (circularPB.Value == 100)
            {
                timer1.Enabled = false;
                Loginfrm li = new Loginfrm();
                li.Show();
                this.Hide();
            }
        }
    }
}
