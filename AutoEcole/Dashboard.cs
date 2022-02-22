using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //affiche forms in pannel
        public void Panelaffiche(Form form_af)
        {

            int panelcont = this.panelContainer.Controls.Count;
            if (panelcont > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form fh = form_af as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            NavUser.Visible = false;
            Form form = new Principal.F_Home();
            Panelaffiche(form);
        }

        private void btn_nav_Click(object sender, EventArgs e)
        {
            if (NavUser.Visible)
                NavUser.Visible = false;
            else
                NavUser.Visible = true;               
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_particip_Click(object sender, EventArgs e)
        {
            Form form = new Payemant.F_index();
            Panelaffiche(form);
        }

        private void btn_payement_Click(object sender, EventArgs e)
        {
            Form form = new Payemant.F_index();
            Panelaffiche(form);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form form = new Principal.F_Home();
            Panelaffiche(form);
        }
    }
}
