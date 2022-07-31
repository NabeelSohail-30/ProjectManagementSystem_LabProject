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
    public partial class SignOut : Form
    {
        public SignOut()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void SignOut_Load(object sender, EventArgs e)
        {
            lblsignout.Text = $"User : {Global.LoggedUser.UserFullName}{Environment.NewLine}You have been logged out successfully";
        }

        private void LoginBtn_MouseEnter(object sender, EventArgs e)
        {
            LoginBtn.BackColor = Color.White;
            LoginBtn.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.BackColor = Color.FromArgb(57, 138, 185);
            LoginBtn.ForeColor = Color.White;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.FromArgb(28, 101, 140);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(57, 138, 185);
            btnExit.ForeColor = Color.White;
        }
    }
}
