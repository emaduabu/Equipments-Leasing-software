namespace Homework_3_solution
{
    partial class FrmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLeaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAvailableEquipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mechanicalStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEquipmentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateEquipmentStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationStaffToolStripMenuItem,
            this.mechanicalStaffToolStripMenuItem,
            this.managementStaffToolStripMenuItem,
            this.systemAdminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationStaffToolStripMenuItem
            // 
            this.operationStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLeaseRequestToolStripMenuItem,
            this.viewAvailableEquipmentsToolStripMenuItem,
            this.viewCustomersContactToolStripMenuItem});
            this.operationStaffToolStripMenuItem.Name = "operationStaffToolStripMenuItem";
            this.operationStaffToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.operationStaffToolStripMenuItem.Text = "Operation Staff";
            this.operationStaffToolStripMenuItem.Click += new System.EventHandler(this.operationStaffToolStripMenuItem_Click);
            // 
            // viewLeaseRequestToolStripMenuItem
            // 
            this.viewLeaseRequestToolStripMenuItem.Name = "viewLeaseRequestToolStripMenuItem";
            this.viewLeaseRequestToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.viewLeaseRequestToolStripMenuItem.Text = "View Lease Request";
            this.viewLeaseRequestToolStripMenuItem.Click += new System.EventHandler(this.viewLeaseRequestToolStripMenuItem_Click);
            // 
            // viewAvailableEquipmentsToolStripMenuItem
            // 
            this.viewAvailableEquipmentsToolStripMenuItem.Name = "viewAvailableEquipmentsToolStripMenuItem";
            this.viewAvailableEquipmentsToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.viewAvailableEquipmentsToolStripMenuItem.Text = "View Available Equipments";
            this.viewAvailableEquipmentsToolStripMenuItem.Click += new System.EventHandler(this.viewAvailableEquipmentsToolStripMenuItem_Click);
            // 
            // viewCustomersContactToolStripMenuItem
            // 
            this.viewCustomersContactToolStripMenuItem.Name = "viewCustomersContactToolStripMenuItem";
            this.viewCustomersContactToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.viewCustomersContactToolStripMenuItem.Text = "View Customers Contact";
            this.viewCustomersContactToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersContactToolStripMenuItem_Click);
            // 
            // mechanicalStaffToolStripMenuItem
            // 
            this.mechanicalStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEquipmentStatusToolStripMenuItem,
            this.updateEquipmentStatusToolStripMenuItem1});
            this.mechanicalStaffToolStripMenuItem.Name = "mechanicalStaffToolStripMenuItem";
            this.mechanicalStaffToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.mechanicalStaffToolStripMenuItem.Text = "Mechanical Staff";
            // 
            // updateEquipmentStatusToolStripMenuItem
            // 
            this.updateEquipmentStatusToolStripMenuItem.Name = "updateEquipmentStatusToolStripMenuItem";
            this.updateEquipmentStatusToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.updateEquipmentStatusToolStripMenuItem.Text = "Mobilize Equipment";
            this.updateEquipmentStatusToolStripMenuItem.Click += new System.EventHandler(this.updateEquipmentStatusToolStripMenuItem_Click);
            // 
            // managementStaffToolStripMenuItem
            // 
            this.managementStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReportToolStripMenuItem});
            this.managementStaffToolStripMenuItem.Name = "managementStaffToolStripMenuItem";
            this.managementStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.managementStaffToolStripMenuItem.Text = "Management Staff";
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // systemAdminToolStripMenuItem
            // 
            this.systemAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.systemAdminToolStripMenuItem.Name = "systemAdminToolStripMenuItem";
            this.systemAdminToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.systemAdminToolStripMenuItem.Text = "SystemAdmin";
            this.systemAdminToolStripMenuItem.Click += new System.EventHandler(this.systemAdminToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(928, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "KZ EMPLOYEE PORTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // updateEquipmentStatusToolStripMenuItem1
            // 
            this.updateEquipmentStatusToolStripMenuItem1.Name = "updateEquipmentStatusToolStripMenuItem1";
            this.updateEquipmentStatusToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.updateEquipmentStatusToolStripMenuItem1.Text = "Update Equipment Status";
            this.updateEquipmentStatusToolStripMenuItem1.Click += new System.EventHandler(this.updateEquipmentStatusToolStripMenuItem1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1369, 483);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1400, 793);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain2";
            this.Text = "FrmMain2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLeaseRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mechanicalStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEquipmentStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem viewAvailableEquipmentsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEquipmentStatusToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}