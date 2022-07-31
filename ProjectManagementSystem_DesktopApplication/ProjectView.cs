using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagementSystem;

namespace ProjectManagementSystem_DesktopApplication
{
    public partial class ProjectView : Form
    {
        public ProjectView()
        {
            InitializeComponent();
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet9.ListProjectStatus' table. You can move, or remove it, as needed.
            this.listProjectStatusTableAdapter.Fill(this.projectManagementSystemDataSet9.ListProjectStatus);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet8.ClientDetails' table. You can move, or remove it, as needed.
            this.clientDetailsTableAdapter.Fill(this.projectManagementSystemDataSet8.ClientDetails);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet7.ListProjectType' table. You can move, or remove it, as needed.
            this.listProjectTypeTableAdapter.Fill(this.projectManagementSystemDataSet7.ListProjectType);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet6.ProjectDetails' table. You can move, or remove it, as needed.
            this.projectDetailsTableAdapter.Fill(this.projectManagementSystemDataSet6.ProjectDetails);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = (int)comboProject.SelectedValue;
            ProjectDetailsRepo project = new ProjectDetailsRepo();
            ProjectDetailsModel model = project.Find(id);

            txtName.Text = model.ProjectName;
            comboType.SelectedValue = model.ProjectTypeId;
            comboClient.SelectedValue = model.ClientId;
            txtDesc.Text = model.ProjectDescription;
            txtTools.Text = model.ProjectTools;
            txtStart.Text = model.ProjectStartDateTime;
            txtEnd.Text = model.ProjectEndDateTime;
            comboStatus.SelectedValue = model.ProjectStatusId;
            txtURL.Text = model.ProjectURL;
            txtPrice.Text = model.ProjectPrice.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
            ProjectDetails form = new ProjectDetails();
            form.Show();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(57, 138, 185);
            btnSave.ForeColor = Color.White;
        }
    }
}
