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
    public partial class ClientsDetail : Form
    {
        public ClientsDetail()
        {
            InitializeComponent();
        }

        private void btnAddNew_MouseEnter(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.FromArgb(57, 138, 185);
            btnAddNew.ForeColor = Color.White;
        }

        private void btnAddNew_MouseLeave(object sender, EventArgs e)
        {
            btnAddNew.BackColor = Color.FromArgb(216, 210, 203);
            btnAddNew.ForeColor = Color.Black;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientAdd form = new ClientAdd();
            form.Show();
        }

        private void ClientsDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet1.viewClientsDetail' table. You can move, or remove it, as needed.
            this.viewClientsDetailTableAdapter.Fill(this.projectManagementSystemDataSet1.viewClientsDetail);

        }
    }
}
