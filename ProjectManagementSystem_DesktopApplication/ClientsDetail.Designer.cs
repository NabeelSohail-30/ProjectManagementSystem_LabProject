namespace ProjectManagementSystem_DesktopApplication
{
    partial class ClientsDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelRightMargin = new System.Windows.Forms.Panel();
            this.panelleftmargin = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementSystemDataSet1 = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet1();
            this.viewClientsDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClientsDetailTableAdapter = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet1TableAdapters.viewClientsDetailTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.footer1 = new ProjectManagementSystem_DesktopApplication.Footer();
            this.header1 = new ProjectManagementSystem_DesktopApplication.Header();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRightMargin
            // 
            this.PanelRightMargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRightMargin.Location = new System.Drawing.Point(1464, 493);
            this.PanelRightMargin.Name = "PanelRightMargin";
            this.PanelRightMargin.Size = new System.Drawing.Size(200, 438);
            this.PanelRightMargin.TabIndex = 20;
            // 
            // panelleftmargin
            // 
            this.panelleftmargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftmargin.Location = new System.Drawing.Point(0, 493);
            this.panelleftmargin.Name = "panelleftmargin";
            this.panelleftmargin.Size = new System.Drawing.Size(200, 438);
            this.panelleftmargin.TabIndex = 19;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(0, 386);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1664, 107);
            this.lblHeading.TabIndex = 18;
            this.lblHeading.Text = "Clients Detail";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBanner
            // 
            this.imgBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgBanner.ErrorImage = null;
            this.imgBanner.Image = global::ProjectManagementSystem_DesktopApplication.Properties.Resources.banner;
            this.imgBanner.Location = new System.Drawing.Point(0, 47);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(1664, 339);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 17;
            this.imgBanner.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(733, 516);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(209, 66);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Text = "Add New Client";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnAddNew.MouseEnter += new System.EventHandler(this.btnAddNew_MouseEnter);
            this.btnAddNew.MouseLeave += new System.EventHandler(this.btnAddNew_MouseLeave);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.projectManagementSystemDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // projectManagementSystemDataSet1
            // 
            this.projectManagementSystemDataSet1.DataSetName = "ProjectManagementSystemDataSet1";
            this.projectManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClientsDetailBindingSource
            // 
            this.viewClientsDetailBindingSource.DataMember = "viewClientsDetail";
            this.viewClientsDetailBindingSource.DataSource = this.bindingSource1;
            // 
            // viewClientsDetailTableAdapter
            // 
            this.viewClientsDetailTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewClientsDetailBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.dataGridView1.Location = new System.Drawing.Point(381, 610);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.DividerHeight = 2;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(867, 298);
            this.dataGridView1.TabIndex = 24;
            // 
            // footer1
            // 
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 931);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1664, 80);
            this.footer1.TabIndex = 16;
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1664, 47);
            this.header1.TabIndex = 15;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Width = 52;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client\'s Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 164;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "Client\'s Type";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.Width = 156;
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "ClientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "Client\'s Phone Number";
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            this.clientPhoneDataGridViewTextBoxColumn.Width = 251;
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "ClientEmail";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "Client\'s Email Address";
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            this.clientEmailDataGridViewTextBoxColumn.Width = 244;
            // 
            // ClientsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1664, 1011);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.PanelRightMargin);
            this.Controls.Add(this.panelleftmargin);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.imgBanner);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClientsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsDetail";
            this.Load += new System.EventHandler(this.ClientsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelRightMargin;
        private System.Windows.Forms.Panel panelleftmargin;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox imgBanner;
        private Footer footer1;
        private Header header1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ProjectManagementSystemDataSet1 projectManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource viewClientsDetailBindingSource;
        private ProjectManagementSystemDataSet1TableAdapters.viewClientsDetailTableAdapter viewClientsDetailTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
    }
}