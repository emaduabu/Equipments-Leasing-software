namespace Homework_3_solution
{
    partial class FrmEquipment
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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiphrcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipfuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipdriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emaduabuDataSet3 = new Homework_3_solution.emaduabuDataSet3();
            this.fillByEquip_nameToolStrip = new System.Windows.Forms.ToolStrip();
            this.equip_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.equip_nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEquip_nameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EquipmentTableAdapter = new Homework_3_solution.emaduabuDataSet3TableAdapters.Tbl_EquipmentTableAdapter();
            this.fillByEquip_fuellToolStrip = new System.Windows.Forms.ToolStrip();
            this.equip_fuelToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.equip_fuelToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEquip_fuellToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet3)).BeginInit();
            this.fillByEquip_nameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.fillByEquip_fuellToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equipIDDataGridViewTextBoxColumn,
            this.equipnameDataGridViewTextBoxColumn,
            this.equiphrcostDataGridViewTextBoxColumn,
            this.equipfuelDataGridViewTextBoxColumn,
            this.equipmodelDataGridViewTextBoxColumn,
            this.equipdriverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEquipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(988, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // equipIDDataGridViewTextBoxColumn
            // 
            this.equipIDDataGridViewTextBoxColumn.DataPropertyName = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.HeaderText = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.Name = "equipIDDataGridViewTextBoxColumn";
            // 
            // equipnameDataGridViewTextBoxColumn
            // 
            this.equipnameDataGridViewTextBoxColumn.DataPropertyName = "Equip_name";
            this.equipnameDataGridViewTextBoxColumn.HeaderText = "Equip_name";
            this.equipnameDataGridViewTextBoxColumn.Name = "equipnameDataGridViewTextBoxColumn";
            // 
            // equiphrcostDataGridViewTextBoxColumn
            // 
            this.equiphrcostDataGridViewTextBoxColumn.DataPropertyName = "Equip_hr_cost";
            this.equiphrcostDataGridViewTextBoxColumn.HeaderText = "Equip_hr_cost";
            this.equiphrcostDataGridViewTextBoxColumn.Name = "equiphrcostDataGridViewTextBoxColumn";
            // 
            // equipfuelDataGridViewTextBoxColumn
            // 
            this.equipfuelDataGridViewTextBoxColumn.DataPropertyName = "Equip_fuel";
            this.equipfuelDataGridViewTextBoxColumn.HeaderText = "Equip_fuel";
            this.equipfuelDataGridViewTextBoxColumn.Name = "equipfuelDataGridViewTextBoxColumn";
            // 
            // equipmodelDataGridViewTextBoxColumn
            // 
            this.equipmodelDataGridViewTextBoxColumn.DataPropertyName = "Equip_model";
            this.equipmodelDataGridViewTextBoxColumn.HeaderText = "Equip_model";
            this.equipmodelDataGridViewTextBoxColumn.Name = "equipmodelDataGridViewTextBoxColumn";
            // 
            // equipdriverDataGridViewTextBoxColumn
            // 
            this.equipdriverDataGridViewTextBoxColumn.DataPropertyName = "Equip_driver";
            this.equipdriverDataGridViewTextBoxColumn.HeaderText = "Equip_driver";
            this.equipdriverDataGridViewTextBoxColumn.Name = "equipdriverDataGridViewTextBoxColumn";
            // 
            // tblEquipmentBindingSource
            // 
            this.tblEquipmentBindingSource.DataMember = "Tbl_Equipment";
            this.tblEquipmentBindingSource.DataSource = this.emaduabuDataSet3;
            // 
            // emaduabuDataSet3
            // 
            this.emaduabuDataSet3.DataSetName = "emaduabuDataSet3";
            this.emaduabuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByEquip_nameToolStrip
            // 
            this.fillByEquip_nameToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByEquip_nameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equip_nameToolStripLabel,
            this.equip_nameToolStripTextBox,
            this.fillByEquip_nameToolStripButton});
            this.fillByEquip_nameToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByEquip_nameToolStrip.Name = "fillByEquip_nameToolStrip";
            this.fillByEquip_nameToolStrip.Size = new System.Drawing.Size(1050, 27);
            this.fillByEquip_nameToolStrip.TabIndex = 1;
            this.fillByEquip_nameToolStrip.Text = "fillByEquip_nameToolStrip";
            // 
            // equip_nameToolStripLabel
            // 
            this.equip_nameToolStripLabel.Name = "equip_nameToolStripLabel";
            this.equip_nameToolStripLabel.Size = new System.Drawing.Size(93, 24);
            this.equip_nameToolStripLabel.Text = "Equip_name:";
            // 
            // equip_nameToolStripTextBox
            // 
            this.equip_nameToolStripTextBox.Name = "equip_nameToolStripTextBox";
            this.equip_nameToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByEquip_nameToolStripButton
            // 
            this.fillByEquip_nameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEquip_nameToolStripButton.Name = "fillByEquip_nameToolStripButton";
            this.fillByEquip_nameToolStripButton.Size = new System.Drawing.Size(129, 24);
            this.fillByEquip_nameToolStripButton.Text = "FillByEquip_name";
            this.fillByEquip_nameToolStripButton.Click += new System.EventHandler(this.fillByEquip_nameToolStripButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.emaduabuDataSet3;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // tbl_EquipmentTableAdapter
            // 
            this.tbl_EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // fillByEquip_fuellToolStrip
            // 
            this.fillByEquip_fuellToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByEquip_fuellToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equip_fuelToolStripLabel,
            this.equip_fuelToolStripTextBox,
            this.fillByEquip_fuellToolStripButton});
            this.fillByEquip_fuellToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillByEquip_fuellToolStrip.Name = "fillByEquip_fuellToolStrip";
            this.fillByEquip_fuellToolStrip.Size = new System.Drawing.Size(1050, 27);
            this.fillByEquip_fuellToolStrip.TabIndex = 2;
            this.fillByEquip_fuellToolStrip.Text = "fillByEquip_fuellToolStrip";
            // 
            // equip_fuelToolStripLabel
            // 
            this.equip_fuelToolStripLabel.Name = "equip_fuelToolStripLabel";
            this.equip_fuelToolStripLabel.Size = new System.Drawing.Size(81, 24);
            this.equip_fuelToolStripLabel.Text = "Equip_fuel:";
            // 
            // equip_fuelToolStripTextBox
            // 
            this.equip_fuelToolStripTextBox.Name = "equip_fuelToolStripTextBox";
            this.equip_fuelToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByEquip_fuellToolStripButton
            // 
            this.fillByEquip_fuellToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEquip_fuellToolStripButton.Name = "fillByEquip_fuellToolStripButton";
            this.fillByEquip_fuellToolStripButton.Size = new System.Drawing.Size(121, 24);
            this.fillByEquip_fuellToolStripButton.Text = "FillByEquip_fuell";
            this.fillByEquip_fuellToolStripButton.Click += new System.EventHandler(this.fillByEquip_fuellToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Available Equipment";
            // 
            // FrmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByEquip_fuellToolStrip);
            this.Controls.Add(this.fillByEquip_nameToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEquipment";
            this.Text = "FrmEquipment";
            this.Load += new System.EventHandler(this.FrmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet3)).EndInit();
            this.fillByEquip_nameToolStrip.ResumeLayout(false);
            this.fillByEquip_nameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.fillByEquip_fuellToolStrip.ResumeLayout(false);
            this.fillByEquip_fuellToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private emaduabuDataSet3 emaduabuDataSet3;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource tblEquipmentBindingSource;
        private emaduabuDataSet3TableAdapters.Tbl_EquipmentTableAdapter tbl_EquipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipdriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipfuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equiphrcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByEquip_nameToolStrip;
        private System.Windows.Forms.ToolStripLabel equip_nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox equip_nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEquip_nameToolStripButton;
        private System.Windows.Forms.ToolStrip fillByEquip_fuellToolStrip;
        private System.Windows.Forms.ToolStripLabel equip_fuelToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox equip_fuelToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEquip_fuellToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}