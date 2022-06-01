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
    }
}
