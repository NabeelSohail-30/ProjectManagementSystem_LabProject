﻿using System;
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
            string userSummary = $"User: {Global.LoggedUser.UserFullName} ---------- Logged in as: {Global.LoggedUser.LoginRole} ---------- Logged in Since: {Global.LoggedUser.LoginDateTime}";
            //lblUserDetails.Text = userSummary;
        }
    }
}
