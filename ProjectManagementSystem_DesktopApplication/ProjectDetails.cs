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
    public partial class ProjectDetails : Form
    {
        public ProjectDetails()
        {
            InitializeComponent();
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet2.viewProjectDetails' table. You can move, or remove it, as needed.
            this.viewProjectDetailsTableAdapter.Fill(this.projectManagementSystemDataSet2.viewProjectDetails);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProjectAdd form = new ProjectAdd();
            this.Close();
            form.Show();
        }

        private void btnAddNew_MouseEnter(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.FromArgb(57, 138, 185);
            btnAddNew.ForeColor = Color.White;
        }

        private void btnAddNew_MouseLeave(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.FromArgb(216, 210, 203);
            btnAddNew.ForeColor = Color.Black;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectView form = new ProjectView();
            form.Show();
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(57, 138, 185);
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(216, 210, 203);
            btnDelete.ForeColor = Color.Black;
        }

        private void btnView_MouseEnter(object sender, EventArgs e)
        {
            btnView.BackColor = Color.FromArgb(57, 138, 185);
            btnView.ForeColor = Color.White;
        }

        private void btnView_MouseLeave(object sender, EventArgs e)
        {
            btnView.BackColor = Color.FromArgb(216, 210, 203);
            btnView.ForeColor = Color.Black;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectUpdate form = new ProjectUpdate();
            form.Show();
        }
    }
}
