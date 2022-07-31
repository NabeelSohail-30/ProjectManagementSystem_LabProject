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
    public partial class ProfileView : Form
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            txtName.Text = Global.LoggedUser.UserName;
            txtFullName.Text = Global.LoggedUser.UserFullName;
            txtMobile.Text = Global.LoggedUser.Mobile;
            txtEmail.Text = Global.LoggedUser.Email;
            txtRole.Text = Global.LoggedUser.LoginRole;
            txtLogged.Text = Global.LoggedUser.LoginDateTime.ToString();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDashboard form = new FormDashboard();
            form.Show();
        }

        private void LoginBtn_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(57, 138, 185);
            btnClose.ForeColor = Color.White;
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.White;
            btnEdit.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(57, 138, 185);
            btnEdit.ForeColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileEdit form = new ProfileEdit();
            form.Show();
        }
    }
}
