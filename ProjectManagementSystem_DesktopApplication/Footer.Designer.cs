namespace ProjectManagementSystem_DesktopApplication
{
    partial class Footer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFooter = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelFooter
            // 
            this.LabelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.LabelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFooter.ForeColor = System.Drawing.Color.White;
            this.LabelFooter.Location = new System.Drawing.Point(0, 0);
            this.LabelFooter.Name = "LabelFooter";
            this.LabelFooter.Size = new System.Drawing.Size(1460, 56);
            this.LabelFooter.TabIndex = 6;
            this.LabelFooter.Text = "Copyright © 2022, Project Management System. All Rights Reserved";
            this.LabelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserDetails.ForeColor = System.Drawing.Color.Black;
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(1445, 19);
            this.lblUserDetails.Spring = true;
            this.lblUserDetails.Text = "Welcome";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(210)))), ((int)(((byte)(203)))));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserDetails});
            this.statusStrip1.Location = new System.Drawing.Point(0, 56);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1460, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelFooter);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(1460, 80);
            this.Load += new System.EventHandler(this.Footer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFooter;
        private System.Windows.Forms.ToolStripStatusLabel lblUserDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
