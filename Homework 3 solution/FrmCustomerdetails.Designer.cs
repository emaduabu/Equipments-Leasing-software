namespace Homework_3_solution
{
    partial class FrmCustomerdetails
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
            System.Windows.Forms.Label custom_nameLabel;
            System.Windows.Forms.Label custom_IDLabel;
            System.Windows.Forms.Label custom_nameLabel1;
            System.Windows.Forms.Label custom_Pho_numLabel;
            System.Windows.Forms.Label custom_companyLabel;
            System.Windows.Forms.Label custom_comp_addresLabel;
            System.Windows.Forms.Label custom_comp_emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerdetails));
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emaduabuDataSet4 = new Homework_3_solution.emaduabuDataSet4();
            this.tbl_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CustomerTableAdapter = new Homework_3_solution.emaduabuDataSet4TableAdapters.Tbl_CustomerTableAdapter();
            this.tableAdapterManager = new Homework_3_solution.emaduabuDataSet4TableAdapters.TableAdapterManager();
            this.custom_nameTextBox = new System.Windows.Forms.TextBox();
            this.custom_Pho_numTextBox = new System.Windows.Forms.TextBox();
            this.custom_companyTextBox = new System.Windows.Forms.TextBox();
            this.custom_comp_addresTextBox = new System.Windows.Forms.TextBox();
            this.custom_comp_emailTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            custom_nameLabel = new System.Windows.Forms.Label();
            custom_IDLabel = new System.Windows.Forms.Label();
            custom_nameLabel1 = new System.Windows.Forms.Label();
            custom_Pho_numLabel = new System.Windows.Forms.Label();
            custom_companyLabel = new System.Windows.Forms.Label();
            custom_comp_addresLabel = new System.Windows.Forms.Label();
            custom_comp_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // custom_nameLabel
            // 
            custom_nameLabel.AutoSize = true;
            custom_nameLabel.Location = new System.Drawing.Point(94, 198);
            custom_nameLabel.Name = "custom_nameLabel";
            custom_nameLabel.Size = new System.Drawing.Size(0, 17);
            custom_nameLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "CUSTOMER CONTACT INFORMATION";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.emaduabuDataSet4;
            this.bindingSource1.Position = 0;
            // 
            // emaduabuDataSet4
            // 
            this.emaduabuDataSet4.DataSetName = "emaduabuDataSet4";
            this.emaduabuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CustomerBindingSource
            // 
            this.tbl_CustomerBindingSource.DataMember = "Tbl_Customer";
            this.tbl_CustomerBindingSource.DataSource = this.emaduabuDataSet4;
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_CustomerTableAdapter = this.tbl_CustomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Homework_3_solution.emaduabuDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // custom_IDLabel
            // 
            custom_IDLabel.AutoSize = true;
            custom_IDLabel.Location = new System.Drawing.Point(181, 149);
            custom_IDLabel.Name = "custom_IDLabel";
            custom_IDLabel.Size = new System.Drawing.Size(76, 17);
            custom_IDLabel.TabIndex = 13;
            custom_IDLabel.Text = "Custom ID:";
            // 
            // custom_nameLabel1
            // 
            custom_nameLabel1.AutoSize = true;
            custom_nameLabel1.Location = new System.Drawing.Point(159, 225);
            custom_nameLabel1.Name = "custom_nameLabel1";
            custom_nameLabel1.Size = new System.Drawing.Size(98, 17);
            custom_nameLabel1.TabIndex = 14;
            custom_nameLabel1.Text = "Custom name:";
            // 
            // custom_nameTextBox
            // 
            this.custom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CustomerBindingSource, "Custom_name", true));
            this.custom_nameTextBox.Location = new System.Drawing.Point(263, 225);
            this.custom_nameTextBox.Name = "custom_nameTextBox";
            this.custom_nameTextBox.Size = new System.Drawing.Size(302, 22);
            this.custom_nameTextBox.TabIndex = 15;
            // 
            // custom_Pho_numLabel
            // 
            custom_Pho_numLabel.AutoSize = true;
            custom_Pho_numLabel.Location = new System.Drawing.Point(138, 309);
            custom_Pho_numLabel.Name = "custom_Pho_numLabel";
            custom_Pho_numLabel.Size = new System.Drawing.Size(119, 17);
            custom_Pho_numLabel.TabIndex = 15;
            custom_Pho_numLabel.Text = "Custom Pho num:";
            // 
            // custom_Pho_numTextBox
            // 
            this.custom_Pho_numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CustomerBindingSource, "Custom_Pho_num", true));
            this.custom_Pho_numTextBox.Location = new System.Drawing.Point(263, 306);
            this.custom_Pho_numTextBox.Name = "custom_Pho_numTextBox";
            this.custom_Pho_numTextBox.Size = new System.Drawing.Size(302, 22);
            this.custom_Pho_numTextBox.TabIndex = 16;
            // 
            // custom_companyLabel
            // 
            custom_companyLabel.AutoSize = true;
            custom_companyLabel.Location = new System.Drawing.Point(137, 407);
            custom_companyLabel.Name = "custom_companyLabel";
            custom_companyLabel.Size = new System.Drawing.Size(120, 17);
            custom_companyLabel.TabIndex = 16;
            custom_companyLabel.Text = "Custom company:";
            // 
            // custom_companyTextBox
            // 
            this.custom_companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CustomerBindingSource, "Custom_company", true));
            this.custom_companyTextBox.Location = new System.Drawing.Point(263, 404);
            this.custom_companyTextBox.Name = "custom_companyTextBox";
            this.custom_companyTextBox.Size = new System.Drawing.Size(302, 22);
            this.custom_companyTextBox.TabIndex = 17;
            // 
            // custom_comp_addresLabel
            // 
            custom_comp_addresLabel.AutoSize = true;
            custom_comp_addresLabel.Location = new System.Drawing.Point(112, 501);
            custom_comp_addresLabel.Name = "custom_comp_addresLabel";
            custom_comp_addresLabel.Size = new System.Drawing.Size(145, 17);
            custom_comp_addresLabel.TabIndex = 17;
            custom_comp_addresLabel.Text = "Custom comp addres:";
            // 
            // custom_comp_addresTextBox
            // 
            this.custom_comp_addresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CustomerBindingSource, "Custom_comp_addres", true));
            this.custom_comp_addresTextBox.Location = new System.Drawing.Point(263, 498);
            this.custom_comp_addresTextBox.Name = "custom_comp_addresTextBox";
            this.custom_comp_addresTextBox.Size = new System.Drawing.Size(302, 22);
            this.custom_comp_addresTextBox.TabIndex = 18;
            // 
            // custom_comp_emailLabel
            // 
            custom_comp_emailLabel.AutoSize = true;
            custom_comp_emailLabel.Location = new System.Drawing.Point(125, 572);
            custom_comp_emailLabel.Name = "custom_comp_emailLabel";
            custom_comp_emailLabel.Size = new System.Drawing.Size(132, 17);
            custom_comp_emailLabel.TabIndex = 18;
            custom_comp_emailLabel.Text = "custom comp email:";
            // 
            // custom_comp_emailTextBox
            // 
            this.custom_comp_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CustomerBindingSource, "custom_comp_email", true));
            this.custom_comp_emailTextBox.Location = new System.Drawing.Point(263, 569);
            this.custom_comp_emailTextBox.Name = "custom_comp_emailTextBox";
            this.custom_comp_emailTextBox.Size = new System.Drawing.Size(302, 22);
            this.custom_comp_emailTextBox.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbl_CustomerBindingSource;
            this.comboBox1.DisplayMember = "Custom_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "Custom_ID";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.emaduabuDataSet4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCustomerdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 737);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(custom_comp_emailLabel);
            this.Controls.Add(this.custom_comp_emailTextBox);
            this.Controls.Add(custom_comp_addresLabel);
            this.Controls.Add(this.custom_comp_addresTextBox);
            this.Controls.Add(custom_companyLabel);
            this.Controls.Add(this.custom_companyTextBox);
            this.Controls.Add(custom_Pho_numLabel);
            this.Controls.Add(this.custom_Pho_numTextBox);
            this.Controls.Add(custom_nameLabel1);
            this.Controls.Add(this.custom_nameTextBox);
            this.Controls.Add(custom_IDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(custom_nameLabel);
            this.Name = "FrmCustomerdetails";
            this.Text = "FrmCustomerdetails";
            this.Load += new System.EventHandler(this.FrmCustomerdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emaduabuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private emaduabuDataSet4 emaduabuDataSet4;
        private System.Windows.Forms.BindingSource tbl_CustomerBindingSource;
        private emaduabuDataSet4TableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private emaduabuDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox custom_nameTextBox;
        private System.Windows.Forms.TextBox custom_Pho_numTextBox;
        private System.Windows.Forms.TextBox custom_companyTextBox;
        private System.Windows.Forms.TextBox custom_comp_addresTextBox;
        private System.Windows.Forms.TextBox custom_comp_emailTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}