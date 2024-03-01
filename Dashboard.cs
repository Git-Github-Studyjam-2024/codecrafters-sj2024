using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCrafters
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Home1.Visible = false;
            uC_Aboutme1.Visible = false;
            uC_Contact1.Visible = false;
            btnHome.PerformClick();  
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnHome.Left;
            uC_Home1.Visible = true;
            uC_Home1.BringToFront();
        }

        private void btnAboutme_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnAboutme.Left + 8;
            uC_Aboutme1.Visible = true;
            uC_Aboutme1.BringToFront();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlMoving.Left = btnContact.Left + 8;
            uC_Contact1.Visible = true;
            uC_Contact1.BringToFront();
        }

       
    }
}
