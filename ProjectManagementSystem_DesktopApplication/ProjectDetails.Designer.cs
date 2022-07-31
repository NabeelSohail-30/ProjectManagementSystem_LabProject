namespace ProjectManagementSystem_DesktopApplication
{
    partial class ProjectDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.PanelRightMargin = new System.Windows.Forms.Panel();
            this.panelleftmargin = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewProjectDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementSystemDataSet2 = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet2();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.viewProjectDetailsTableAdapter = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet2TableAdapters.viewProjectDetailsTableAdapter();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.header1 = new ProjectManagementSystem_DesktopApplication.Header();
            this.footer1 = new ProjectManagementSystem_DesktopApplication.Footer();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBanner
            // 
            this.imgBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgBanner.ErrorImage = null;
            this.imgBanner.Image = global::ProjectManagementSystem_DesktopApplication.Properties.Resources.banner;
            this.imgBanner.Location = new System.Drawing.Point(0, 47);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(1668, 339);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 28;
            this.imgBanner.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(0, 386);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(1668, 107);
            this.lblHeading.TabIndex = 29;
            this.lblHeading.Text = "Project Details";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRightMargin
            // 
            this.PanelRightMargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRightMargin.Location = new System.Drawing.Point(1468, 493);
            this.PanelRightMargin.Name = "PanelRightMargin";
            this.PanelRightMargin.Size = new System.Drawing.Size(200, 442);
            this.PanelRightMargin.TabIndex = 30;
            // 
            // panelleftmargin
            // 
            this.panelleftmargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftmargin.Location = new System.Drawing.Point(0, 493);
            this.panelleftmargin.Name = "panelleftmargin";
            this.panelleftmargin.Size = new System.Drawing.Size(200, 442);
            this.panelleftmargin.TabIndex = 31;
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
            this.projectIdDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.projectTypeDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.projectStatusDataGridViewTextBoxColumn,
            this.projectPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewProjectDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.dataGridView1.Location = new System.Drawing.Point(388, 603);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowTemplate.DividerHeight = 2;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(877, 298);
            this.dataGridView1.TabIndex = 33;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.Width = 52;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "Project Name";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            this.projectNameDataGridViewTextBoxColumn.Width = 161;
            // 
            // projectTypeDataGridViewTextBoxColumn
            // 
            this.projectTypeDataGridViewTextBoxColumn.DataPropertyName = "ProjectType";
            this.projectTypeDataGridViewTextBoxColumn.HeaderText = "Project Type";
            this.projectTypeDataGridViewTextBoxColumn.Name = "projectTypeDataGridViewTextBoxColumn";
            this.projectTypeDataGridViewTextBoxColumn.Width = 153;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 149;
            // 
            // projectStatusDataGridViewTextBoxColumn
            // 
            this.projectStatusDataGridViewTextBoxColumn.DataPropertyName = "ProjectStatus";
            this.projectStatusDataGridViewTextBoxColumn.HeaderText = "Project Status";
            this.projectStatusDataGridViewTextBoxColumn.Name = "projectStatusDataGridViewTextBoxColumn";
            this.projectStatusDataGridViewTextBoxColumn.Width = 162;
            // 
            // projectPriceDataGridViewTextBoxColumn
            // 
            this.projectPriceDataGridViewTextBoxColumn.DataPropertyName = "ProjectPrice";
            this.projectPriceDataGridViewTextBoxColumn.HeaderText = "Project Price";
            this.projectPriceDataGridViewTextBoxColumn.Name = "projectPriceDataGridViewTextBoxColumn";
            this.projectPriceDataGridViewTextBoxColumn.Width = 154;
            // 
            // viewProjectDetailsBindingSource
            // 
            this.viewProjectDetailsBindingSource.DataMember = "viewProjectDetails";
            this.viewProjectDetailsBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.projectManagementSystemDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // projectManagementSystemDataSet2
            // 
            this.projectManagementSystemDataSet2.DataSetName = "ProjectManagementSystemDataSet2";
            this.projectManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(748, 512);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(209, 66);
            this.btnAddNew.TabIndex = 32;
            this.btnAddNew.Text = "Add New Project";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnAddNew.MouseEnter += new System.EventHandler(this.btnAddNew_MouseEnter);
            this.btnAddNew.MouseLeave += new System.EventHandler(this.btnAddNew_MouseLeave);
            // 
            // viewProjectDetailsTableAdapter
            // 
            this.viewProjectDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(533, 512);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(209, 66);
            this.btnView.TabIndex = 34;
            this.btnView.Text = "View Project";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.MouseEnter += new System.EventHandler(this.btnView_MouseEnter);
            this.btnView.MouseLeave += new System.EventHandler(this.btnView_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(963, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 66);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Update Project";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1668, 47);
            this.header1.TabIndex = 27;
            // 
            // footer1
            // 
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 935);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1668, 80);
            this.footer1.TabIndex = 26;
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1668, 1015);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.panelleftmargin);
            this.Controls.Add(this.PanelRightMargin);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.imgBanner);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.footer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectDetails";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Footer footer1;
        private Header header1;
        private System.Windows.Forms.PictureBox imgBanner;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel PanelRightMargin;
        private System.Windows.Forms.Panel panelleftmargin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ProjectManagementSystemDataSet2 projectManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource viewProjectDetailsBindingSource;
        private ProjectManagementSystemDataSet2TableAdapters.viewProjectDetailsTableAdapter viewProjectDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
    }
}