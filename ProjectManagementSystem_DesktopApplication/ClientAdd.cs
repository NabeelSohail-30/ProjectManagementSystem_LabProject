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
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectManagementSystemDataSet.ListClientType' table. You can move, or remove it, as needed.
            this.listClientTypeTableAdapter.Fill(this.projectManagementSystemDataSet.ListClientType);
            this.comboType.SelectedValue = -1;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClientDetailModel clientModel = new ClientDetailModel();
            ClientDetailRepo client = new ClientDetailRepo();
            int id = -1;
            clientModel.ClientName = txtName.Text;
            clientModel.ClientTypeId = (int)comboType.SelectedValue;
            clientModel.ClientPhone = txtMobile.Text;
            clientModel.ClientEmail = txtEmail.Text;
            clientModel.ClientAddress = txtAddress.Text;
            clientModel.Note = txtNote.Text;
            id = client.Add(clientModel);

            if (id > 0)
            {
                this.Close();
                ClientsDetail form = new ClientsDetail();
                form.Show();
            }
            else
            {
                MessageBox.Show("Client not Added", "Add Client Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
