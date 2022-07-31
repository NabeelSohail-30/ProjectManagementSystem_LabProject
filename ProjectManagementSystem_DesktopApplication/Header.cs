using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ProjectManagementSystem_DesktopApplication
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SignOut FormSignOut = new SignOut();

            //Panel ParentPanel = (Panel)this.Parent;
            Form ParentForm = (Form)this.Parent;
            ParentForm.Hide();
            FormSignOut.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ProfileView form = new ProfileView();
            Form ParentForm = (Form)this.Parent;
            ParentForm.Hide();
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormDashboard form = new FormDashboard();
            Form ParentForm = (Form)this.Parent;
            ParentForm.Hide();
            form.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ClientsDetail form = new ClientsDetail();
            Form ParentForm = (Form)this.Parent;
            ParentForm.Hide();
            form.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ProjectDetails form = new ProjectDetails();
            Form ParentForm = (Form)this.Parent;
            ParentForm.Hide();
            form.Show();
        }
    }
}
