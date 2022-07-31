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
    public partial class ProjectAdd : Form
    {
        public ProjectAdd()
        {
            InitializeComponent();
        }

        private void ProjectAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet5.ListProjectStatus' table. You can move, or remove it, as needed.
            this.listProjectStatusTableAdapter.Fill(this.projectManagementSystemDataSet5.ListProjectStatus);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet4.viewClientsDetail' table. You can move, or remove it, as needed.
            this.viewClientsDetailTableAdapter.Fill(this.projectManagementSystemDataSet4.viewClientsDetail);
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet3.ListProjectType' table. You can move, or remove it, as needed.
            this.listProjectTypeTableAdapter.Fill(this.projectManagementSystemDataSet3.ListProjectType);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectDetailsModel projectModel = new ProjectDetailsModel();
            ProjectDetailsRepo project = new ProjectDetailsRepo();
            int id = -1;

            projectModel.ProjectName = txtName.Text;
            projectModel.ProjectDescription = txtDesc.Text;
            projectModel.ProjectTypeId = int.Parse(comboType.SelectedValue.ToString());
            projectModel.ProjectTools = txtTools.Text;
            projectModel.ClientId = int.Parse(comboClient.SelectedValue.ToString());
            projectModel.ProjectStartDateTime = dtStart.Value.ToString();
            projectModel.ProjectEndDateTime = dtEnd.Value.ToString();
            projectModel.ProjectStatusId = int.Parse(comboStatus.SelectedValue.ToString());
            projectModel.ProjectURL = txtURL.Text;
            projectModel.ProjectPrice = double.Parse(txtPrice.Text);

            id = project.Add(projectModel);

            if (id > 0)
            {
                this.Close();
                ProjectDetails form = new ProjectDetails();
                form.Show();
            }
            else
            {
                MessageBox.Show("Project not Added", "Add Project Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
