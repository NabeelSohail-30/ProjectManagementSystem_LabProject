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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            UserAccountsRepo user = new UserAccountsRepo();
            UserAccountsModel User = user.Authenticate(txtName.Text, txtPass.Text);

            if(User.UserId == -1)
            {
                MessageBox.Show("User Name or Password is Incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Global.LoggedUser.UserId = User.UserId;
                Global.LoggedUser.UserFullName = User.UserFullName;
                Global.LoggedUser.Email = User.Email;
                Global.LoggedUser.Mobile = User.Mobile;
                Global.LoggedUser.LoginRole = User.LoginRole;
                Global.LoggedUser.LoginDateTime = User.LoginDateTime;

                FormDashboard dashboard = new FormDashboard();
                dashboard.Show();
                this.Hide(); 
            }

        }
    }
}
