namespace Homework_3_solution
{
    partial class FrmUpdateEquipment
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
            System.Windows.Forms.Label equip_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateEquipment));
            System.Windows.Forms.Label equip_nameLabel;
            System.Windows.Forms.Label equip_hr_costLabel;
            System.Windows.Forms.Label equip_fuelLabel;
            System.Windows.Forms.Label equip_modelLabel;
            System.Windows.Forms.Label equip_driverLabel;
            this.emaduabuDataSet3 = new Homework_3_solution.emaduabuDataSet3();
            this.tbl_EquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EquipmentTableAdapter = new Homework_3_solution.emaduabuDataSet3TableAdapters.Tbl_EquipmentTableAdapter();
            this.tableAdapterManager = new Homework_3_solution.emaduabuDataSet3TableAdapters.TableAdapterManager();
            this.tbl_EquipmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.equip_IDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_EquipmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.equip_nameTextBox = new System.Windows.Forms.TextBox();
            this.equip_hr_costTextBox = new System.Windows.Forms.TextBox();
            this.equip_fuelTextBox = new System.Windows.Forms.TextBox();
            this.equip_modelTextBox = new System.Windows.Forms.TextBox();
            this.equip_driverTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            equip_IDLabel = new System.Windows.Forms.Label();
            equip_nameLabel = new System.Windows.Forms.Label();
            equip_hr_costLabel = new System.Windows.Forms.Label();
            equip_fuelLabel = new System.Windows.Forms.Label();
            equip_modelLabel = new System.Windows.Forms.Label();
            equip_driverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EquipmentBindingNavigator)).BeginInit();
            this.tbl_EquipmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emaduabuDataSet3
            // 
            this.emaduabuDataSet3.DataSetName = "emaduabuDataSet3";
            this.emaduabuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_EquipmentBindingSource
            // 
            this.tbl_EquipmentBindingSource.DataMember = "Tbl_Equipment";
            this.tbl_EquipmentBindingSource.DataSource = this.emaduabuDataSet3;
            // 
            // tbl_EquipmentTableAdapter
            // 
            this.tbl_EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_EquipmentTableAdapter = this.tbl_EquipmentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Homework_3_solution.emaduabuDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_EquipmentBindingNavigator
            // 
            this.tbl_EquipmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_EquipmentBindingNavigator.BindingSource = this.tbl_EquipmentBindingSource;
            this.tbl_EquipmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_EquipmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_EquipmentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_EquipmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_EquipmentBindingNavigatorSaveItem});
            this.tbl_EquipmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_EquipmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_EquipmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_EquipmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_EquipmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_EquipmentBindingNavigator.Name = "tbl_EquipmentBindingNavigator";
            this.tbl_EquipmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_EquipmentBindingNavigator.Size = new System.Drawing.Size(933, 27);
            this.tbl_EquipmentBindingNavigator.TabIndex = 0;
            this.tbl_EquipmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // equip_IDLabel
            // 
            equip_IDLabel.AutoSize = true;
            equip_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_IDLabel.Location = new System.Drawing.Point(190, 139);
            equip_IDLabel.Name = "equip_IDLabel";
            equip_IDLabel.Size = new System.Drawing.Size(101, 25);
            equip_IDLabel.TabIndex = 1;
            equip_IDLabel.Text = "Equip ID:";
            // 
            // equip_IDTextBox
            // 
            this.equip_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_ID", true));
            this.equip_IDTextBox.Location = new System.Drawing.Point(316, 139);
            this.equip_IDTextBox.Name = "equip_IDTextBox";
            this.equip_IDTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_IDTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tbl_EquipmentBindingNavigatorSaveItem
            // 
            this.tbl_EquipmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_EquipmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_EquipmentBindingNavigatorSaveItem.Image")));
            this.tbl_EquipmentBindingNavigatorSaveItem.Name = "tbl_EquipmentBindingNavigatorSaveItem";
            this.tbl_EquipmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbl_EquipmentBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_EquipmentBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_EquipmentBindingNavigatorSaveItem_Click);
            // 
            // equip_nameLabel
            // 
            equip_nameLabel.AutoSize = true;
            equip_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_nameLabel.Location = new System.Drawing.Point(177, 217);
            equip_nameLabel.Name = "equip_nameLabel";
            equip_nameLabel.Size = new System.Drawing.Size(133, 25);
            equip_nameLabel.TabIndex = 3;
            equip_nameLabel.Text = "Equip name:";
            // 
            // equip_nameTextBox
            // 
            this.equip_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_name", true));
            this.equip_nameTextBox.Location = new System.Drawing.Point(316, 221);
            this.equip_nameTextBox.Name = "equip_nameTextBox";
            this.equip_nameTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_nameTextBox.TabIndex = 4;
            // 
            // equip_hr_costLabel
            // 
            equip_hr_costLabel.AutoSize = true;
            equip_hr_costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_hr_costLabel.Location = new System.Drawing.Point(170, 287);
            equip_hr_costLabel.Name = "equip_hr_costLabel";
            equip_hr_costLabel.Size = new System.Drawing.Size(140, 24);
            equip_hr_costLabel.TabIndex = 5;
            equip_hr_costLabel.Text = "Equip hr cost:";
            // 
            // equip_hr_costTextBox
            // 
            this.equip_hr_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_hr_cost", true));
            this.equip_hr_costTextBox.Location = new System.Drawing.Point(316, 289);
            this.equip_hr_costTextBox.Name = "equip_hr_costTextBox";
            this.equip_hr_costTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_hr_costTextBox.TabIndex = 6;
            // 
            // equip_fuelLabel
            // 
            equip_fuelLabel.AutoSize = true;
            equip_fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_fuelLabel.Location = new System.Drawing.Point(190, 384);
            equip_fuelLabel.Name = "equip_fuelLabel";
            equip_fuelLabel.Size = new System.Drawing.Size(111, 24);
            equip_fuelLabel.TabIndex = 7;
            equip_fuelLabel.Text = "Equip fuel:";
            // 
            // equip_fuelTextBox
            // 
            this.equip_fuelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_fuel", true));
            this.equip_fuelTextBox.Location = new System.Drawing.Point(316, 387);
            this.equip_fuelTextBox.Name = "equip_fuelTextBox";
            this.equip_fuelTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_fuelTextBox.TabIndex = 8;
            // 
            // equip_modelLabel
            // 
            equip_modelLabel.AutoSize = true;
            equip_modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_modelLabel.Location = new System.Drawing.Point(156, 476);
            equip_modelLabel.Name = "equip_modelLabel";
            equip_modelLabel.Size = new System.Drawing.Size(135, 24);
            equip_modelLabel.TabIndex = 9;
            equip_modelLabel.Text = "Equip model:";
            // 
            // equip_modelTextBox
            // 
            this.equip_modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_model", true));
            this.equip_modelTextBox.Location = new System.Drawing.Point(316, 476);
            this.equip_modelTextBox.Name = "equip_modelTextBox";
            this.equip_modelTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_modelTextBox.TabIndex = 10;
            // 
            // equip_driverLabel
            // 
            equip_driverLabel.AutoSize = true;
            equip_driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equip_driverLabel.Location = new System.Drawing.Point(161, 553);
            equip_driverLabel.Name = "equip_driverLabel";
            equip_driverLabel.Size = new System.Drawing.Size(130, 24);
            equip_driverLabel.TabIndex = 11;
            equip_driverLabel.Text = "Equip driver:";
            // 
            // equip_driverTextBox
            // 
            this.equip_driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_EquipmentBindingSource, "Equip_driver", true));
            this.equip_driverTextBox.Location = new System.Drawing.Point(316, 564);
            this.equip_driverTextBox.Name = "equip_driverTextBox";
            this.equip_driverTextBox.Size = new System.Drawing.Size(259, 22);
            this.equip_driverTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(570, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(817, 619);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "EQUIPMENT UPDATE FORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUpdateEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 734);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(equip_driverLabel);
            this.Controls.Add(this.equip_driverTextBox);
            this.Controls.Add(equip_modelLabel);
            this.Controls.Add(this.equip_modelTextBox);
            this.Controls.Add(equip_fuelLabel);
            this.Controls.Add(this.equip_fuelTextBox);
            this.Controls.Add(equip_hr_costLabel);
            this.Controls.Add(this.equip_hr_costTextBox);
            this.Controls.Add(equip_nameLabel);
            this.Controls.Add(this.equip_nameTextBox);
            this.Controls.Add(equip_IDLabel);
            this.Controls.Add(this.equip_IDTextBox);
            this.Controls.Add(this.tbl_EquipmentBindingNavigator);
            this.Name = "FrmUpdateEquipment";
            this.Text = "FrmUpdateEquipment";
            this.Load += new System.EventHandler(this.FrmUpdateEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_EquipmentBindingNavigator)).EndInit();
            this.tbl_EquipmentBindingNavigator.ResumeLayout(false);
            this.tbl_EquipmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private emaduabuDataSet3 emaduabuDataSet3;
        private System.Windows.Forms.BindingSource tbl_EquipmentBindingSource;
        private emaduabuDataSet3TableAdapters.Tbl_EquipmentTableAdapter tbl_EquipmentTableAdapter;
        private emaduabuDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_EquipmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_EquipmentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox equip_IDTextBox;
        private System.Windows.Forms.TextBox equip_nameTextBox;
        private System.Windows.Forms.TextBox equip_hr_costTextBox;
        private System.Windows.Forms.TextBox equip_fuelTextBox;
        private System.Windows.Forms.TextBox equip_modelTextBox;
        private System.Windows.Forms.TextBox equip_driverTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}