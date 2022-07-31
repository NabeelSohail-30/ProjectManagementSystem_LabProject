namespace ProjectManagementSystem_DesktopApplication
{
    partial class ProjectAdd
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
            this.header1 = new ProjectManagementSystem_DesktopApplication.Header();
            this.label1 = new System.Windows.Forms.Label();
            this.footer1 = new ProjectManagementSystem_DesktopApplication.Footer();
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTools = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bindType = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementSystemDataSet3 = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet3();
            this.listProjectTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProjectTypeTableAdapter = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet3TableAdapters.ListProjectTypeTableAdapter();
            this.bindingClient = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementSystemDataSet4 = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet4();
            this.viewClientsDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewClientsDetailTableAdapter = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet4TableAdapters.viewClientsDetailTableAdapter();
            this.bindingStatus = new System.Windows.Forms.BindingSource(this.components);
            this.projectManagementSystemDataSet5 = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet5();
            this.listProjectStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listProjectStatusTableAdapter = new ProjectManagementSystem_DesktopApplication.ProjectManagementSystemDataSet5TableAdapters.ListProjectStatusTableAdapter();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProjectTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProjectStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1032, 51);
            this.header1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1032, 66);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer1
            // 
            this.footer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer1.Location = new System.Drawing.Point(0, 765);
            this.footer1.Name = "footer1";
            this.footer1.Size = new System.Drawing.Size(1032, 80);
            this.footer1.TabIndex = 14;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.panelMain.Controls.Add(this.dtEnd);
            this.panelMain.Controls.Add(this.dtStart);
            this.panelMain.Controls.Add(this.txtPrice);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.txtURL);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.comboStatus);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.txtTools);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.comboClient);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtDesc);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.comboType);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(50, 167);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(932, 548);
            this.panelMain.TabIndex = 21;
            // 
            // comboType
            // 
            this.comboType.DataSource = this.listProjectTypeBindingSource;
            this.comboType.DisplayMember = "ProjectType";
            this.comboType.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(343, 77);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(236, 31);
            this.comboType.TabIndex = 16;
            this.comboType.ValueMember = "ProjectTypeId";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSave.Location = new System.Drawing.Point(412, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 38);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(338, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Project Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(30, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 30);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(50, 117);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(932, 50);
            this.panelTop.TabIndex = 20;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(50, 715);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(932, 50);
            this.panelBottom.TabIndex = 19;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(982, 117);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(50, 648);
            this.panelRight.TabIndex = 18;
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 117);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(50, 648);
            this.panelLeft.TabIndex = 17;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(30, 169);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(391, 70);
            this.txtDesc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(25, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboClient
            // 
            this.comboClient.DataSource = this.viewClientsDetailBindingSource;
            this.comboClient.DisplayMember = "ClientName";
            this.comboClient.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(656, 77);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(236, 31);
            this.comboClient.TabIndex = 20;
            this.comboClient.ValueMember = "ClientId";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(651, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTools
            // 
            this.txtTools.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTools.Location = new System.Drawing.Point(501, 169);
            this.txtTools.Multiline = true;
            this.txtTools.Name = "txtTools";
            this.txtTools.Size = new System.Drawing.Size(391, 70);
            this.txtTools.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(496, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tools";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(25, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "Start Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(338, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "End Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboStatus
            // 
            this.comboStatus.DataSource = this.listProjectStatusBindingSource;
            this.comboStatus.DisplayMember = "ProjectStatus";
            this.comboStatus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(656, 304);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(236, 31);
            this.comboStatus.TabIndex = 28;
            this.comboStatus.ValueMember = "ProjectStatusId";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(651, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "Project Status";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(30, 405);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(549, 30);
            this.txtURL.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(25, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Project URL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(656, 405);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 30);
            this.txtPrice.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(651, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Project Price";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindType
            // 
            this.bindType.DataSource = this.projectManagementSystemDataSet3;
            this.bindType.Position = 0;
            // 
            // projectManagementSystemDataSet3
            // 
            this.projectManagementSystemDataSet3.DataSetName = "ProjectManagementSystemDataSet3";
            this.projectManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listProjectTypeBindingSource
            // 
            this.listProjectTypeBindingSource.DataMember = "ListProjectType";
            this.listProjectTypeBindingSource.DataSource = this.bindType;
            // 
            // listProjectTypeTableAdapter
            // 
            this.listProjectTypeTableAdapter.ClearBeforeFill = true;
            // 
            // bindingClient
            // 
            this.bindingClient.DataSource = this.projectManagementSystemDataSet4;
            this.bindingClient.Position = 0;
            // 
            // projectManagementSystemDataSet4
            // 
            this.projectManagementSystemDataSet4.DataSetName = "ProjectManagementSystemDataSet4";
            this.projectManagementSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewClientsDetailBindingSource
            // 
            this.viewClientsDetailBindingSource.DataMember = "viewClientsDetail";
            this.viewClientsDetailBindingSource.DataSource = this.bindingClient;
            // 
            // viewClientsDetailTableAdapter
            // 
            this.viewClientsDetailTableAdapter.ClearBeforeFill = true;
            // 
            // bindingStatus
            // 
            this.bindingStatus.DataSource = this.projectManagementSystemDataSet5;
            this.bindingStatus.Position = 0;
            // 
            // projectManagementSystemDataSet5
            // 
            this.projectManagementSystemDataSet5.DataSetName = "ProjectManagementSystemDataSet5";
            this.projectManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listProjectStatusBindingSource
            // 
            this.listProjectStatusBindingSource.DataMember = "ListProjectStatus";
            this.listProjectStatusBindingSource.DataSource = this.bindingStatus;
            // 
            // listProjectStatusTableAdapter
            // 
            this.listProjectStatusTableAdapter.ClearBeforeFill = true;
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(30, 305);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(236, 30);
            this.dtStart.TabIndex = 33;
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(343, 305);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(236, 30);
            this.dtEnd.TabIndex = 34;
            // 
            // ProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(101)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1032, 845);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.footer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProjectAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectAdd";
            this.Load += new System.EventHandler(this.ProjectAdd_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProjectTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewClientsDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProjectStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Header header1;
        private System.Windows.Forms.Label label1;
        private Footer footer1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTools;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bindType;
        private ProjectManagementSystemDataSet3 projectManagementSystemDataSet3;
        private System.Windows.Forms.BindingSource listProjectTypeBindingSource;
        private ProjectManagementSystemDataSet3TableAdapters.ListProjectTypeTableAdapter listProjectTypeTableAdapter;
        private System.Windows.Forms.BindingSource bindingClient;
        private ProjectManagementSystemDataSet4 projectManagementSystemDataSet4;
        private System.Windows.Forms.BindingSource viewClientsDetailBindingSource;
        private ProjectManagementSystemDataSet4TableAdapters.viewClientsDetailTableAdapter viewClientsDetailTableAdapter;
        private System.Windows.Forms.BindingSource bindingStatus;
        private ProjectManagementSystemDataSet5 projectManagementSystemDataSet5;
        private System.Windows.Forms.BindingSource listProjectStatusBindingSource;
        private ProjectManagementSystemDataSet5TableAdapters.ListProjectStatusTableAdapter listProjectStatusTableAdapter;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
    }
}