using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem_DesktopApplication
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProjects_MouseEnter(object sender, EventArgs e)
        {
            btnProjects.BackColor = Color.FromArgb(57, 138, 185);
            btnProjects.ForeColor = Color.White;
        }

        private void btnProjects_MouseLeave(object sender, EventArgs e)
        {
            btnProjects.BackColor = Color.FromArgb(216, 210, 203);
            btnProjects.ForeColor = Color.Black;
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(57, 138, 185);
            btnProfile.ForeColor = Color.White;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(216, 210, 203);
            btnProfile.ForeColor = Color.Black;
        }

        private void btnClient_MouseEnter(object sender, EventArgs e)
        {
            btnClient.BackColor = Color.FromArgb(57, 138, 185);
            btnClient.ForeColor = Color.White;
        }

        private void btnClient_MouseLeave(object sender, EventArgs e)
        {
            btnClient.BackColor = Color.FromArgb(216, 210, 203);
            btnClient.ForeColor = Color.Black;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileView pv = new ProfileView();
            pv.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientsDetail cd = new ClientsDetail();
            cd.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectDetails form = new ProjectDetails();
            form.Show();
        }
    }
}
