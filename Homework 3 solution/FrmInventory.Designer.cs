namespace Homework_3_solution
{
    partial class FrmInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premobdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demobdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emaduabuDataSet2 = new Homework_3_solution.emaduabuDataSet2();
            this.fillByEquip_IDToolStrip = new System.Windows.Forms.ToolStrip();
            this.equip_IDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.equip_IDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEquip_IDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_InventoryTableAdapter = new Homework_3_solution.emaduabuDataSet2TableAdapters.Tbl_InventoryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet2)).BeginInit();
            this.fillByEquip_IDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryIDDataGridViewTextBoxColumn,
            this.premobdatetimeDataGridViewTextBoxColumn,
            this.demobdatetimeDataGridViewTextBoxColumn,
            this.equipStatusDataGridViewTextBoxColumn,
            this.equipIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblInventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 471);
            this.dataGridView1.TabIndex = 0;
            // 
            // inventoryIDDataGridViewTextBoxColumn
            // 
            this.inventoryIDDataGridViewTextBoxColumn.DataPropertyName = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory_ID";
            this.inventoryIDDataGridViewTextBoxColumn.Name = "inventoryIDDataGridViewTextBoxColumn";
            // 
            // premobdatetimeDataGridViewTextBoxColumn
            // 
            this.premobdatetimeDataGridViewTextBoxColumn.DataPropertyName = "Premob_date_time";
            this.premobdatetimeDataGridViewTextBoxColumn.HeaderText = "Premob_date_time";
            this.premobdatetimeDataGridViewTextBoxColumn.Name = "premobdatetimeDataGridViewTextBoxColumn";
            // 
            // demobdatetimeDataGridViewTextBoxColumn
            // 
            this.demobdatetimeDataGridViewTextBoxColumn.DataPropertyName = "Demob_date_time";
            this.demobdatetimeDataGridViewTextBoxColumn.HeaderText = "Demob_date_time";
            this.demobdatetimeDataGridViewTextBoxColumn.Name = "demobdatetimeDataGridViewTextBoxColumn";
            // 
            // equipStatusDataGridViewTextBoxColumn
            // 
            this.equipStatusDataGridViewTextBoxColumn.DataPropertyName = "Equip_Status";
            this.equipStatusDataGridViewTextBoxColumn.HeaderText = "Equip_Status";
            this.equipStatusDataGridViewTextBoxColumn.Name = "equipStatusDataGridViewTextBoxColumn";
            // 
            // equipIDDataGridViewTextBoxColumn
            // 
            this.equipIDDataGridViewTextBoxColumn.DataPropertyName = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.HeaderText = "Equip_ID";
            this.equipIDDataGridViewTextBoxColumn.Name = "equipIDDataGridViewTextBoxColumn";
            // 
            // tblInventoryBindingSource
            // 
            this.tblInventoryBindingSource.DataMember = "Tbl_Inventory";
            this.tblInventoryBindingSource.DataSource = this.emaduabuDataSet2;
            // 
            // emaduabuDataSet2
            // 
            this.emaduabuDataSet2.DataSetName = "emaduabuDataSet2";
            this.emaduabuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByEquip_IDToolStrip
            // 
            this.fillByEquip_IDToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByEquip_IDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equip_IDToolStripLabel,
            this.equip_IDToolStripTextBox,
            this.fillByEquip_IDToolStripButton});
            this.fillByEquip_IDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByEquip_IDToolStrip.Name = "fillByEquip_IDToolStrip";
            this.fillByEquip_IDToolStrip.Size = new System.Drawing.Size(971, 27);
            this.fillByEquip_IDToolStrip.TabIndex = 1;
            this.fillByEquip_IDToolStrip.Text = "fillByEquip_IDToolStrip";
            // 
            // equip_IDToolStripLabel
            // 
            this.equip_IDToolStripLabel.Name = "equip_IDToolStripLabel";
            this.equip_IDToolStripLabel.Size = new System.Drawing.Size(71, 24);
            this.equip_IDToolStripLabel.Text = "Equip_ID:";
            // 
            // equip_IDToolStripTextBox
            // 
            this.equip_IDToolStripTextBox.Name = "equip_IDToolStripTextBox";
            this.equip_IDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByEquip_IDToolStripButton
            // 
            this.fillByEquip_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEquip_IDToolStripButton.Name = "fillByEquip_IDToolStripButton";
            this.fillByEquip_IDToolStripButton.Size = new System.Drawing.Size(107, 24);
            this.fillByEquip_IDToolStripButton.Text = "FillByEquip_ID";
            this.fillByEquip_IDToolStripButton.Click += new System.EventHandler(this.fillByEquip_IDToolStripButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.emaduabuDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // tbl_InventoryTableAdapter
            // 
            this.tbl_InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "KZ INVENTORY PANEL";
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByEquip_IDToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet2)).EndInit();
            this.fillByEquip_IDToolStrip.ResumeLayout(false);
            this.fillByEquip_IDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private emaduabuDataSet2 emaduabuDataSet2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource tblInventoryBindingSource;
        private emaduabuDataSet2TableAdapters.Tbl_InventoryTableAdapter tbl_InventoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premobdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demobdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByEquip_IDToolStrip;
        private System.Windows.Forms.ToolStripLabel equip_IDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox equip_IDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEquip_IDToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}