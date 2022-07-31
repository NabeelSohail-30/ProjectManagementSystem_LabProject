using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem_DesktopApplication
{
    public partial class Footer : UserControl
    {
        public Footer()
        {
            InitializeComponent();
        }

        private void Footer_Load(object sender, EventArgs e)
        {
            string userSummary = $"User: {Global.LoggedUser.UserFullName} --- Logged in as: {Global.LoggedUser.LoginRole} --- Logged in Since: {Global.LoggedUser.LoginDateTime}";
            lblUserDetails.Text = userSummary;
        }
    }
}
