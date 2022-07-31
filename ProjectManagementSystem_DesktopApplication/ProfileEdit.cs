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
    public partial class ProfileEdit : Form
    {
        public ProfileEdit()
        {
            InitializeComponent();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDashboard form = new FormDashboard();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserAccountsModel user = new UserAccountsModel();
            UserAccountsRepo userRepo = new UserAccountsRepo();

            user.UserFullName = txtFullName.Text;
            user.Mobile = txtMobile.Text;
            user.Email = txtEmail.Text;

            int identity = userRepo.Update(Global.LoggedUser.UserId, user);

            if (identity == 0)
            {
                MessageBox.Show("User not updated successfully", "Updation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
                FormDashboard form = new FormDashboard();
                form.Close();
            }

            //FormDashboard form2 = new FormDashboard();
            //form2.Show();

        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = Global.LoggedUser.UserName;
            txtFullName.Text = Global.LoggedUser.UserFullName;
            txtMobile.Text = Global.LoggedUser.Mobile;
            txtEmail.Text = Global.LoggedUser.Email;
            txtRole.Text = Global.LoggedUser.LoginRole;
            txtLogged.Text = Global.LoggedUser.LoginDateTime.ToString();
        }
    }
}
