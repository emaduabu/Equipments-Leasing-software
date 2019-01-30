using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3_solution
{
    public partial class FrmEquipment : Form
    {
        public FrmEquipment()
        {
            InitializeComponent();
        }

        private void FrmEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emaduabuDataSet3.Tbl_Equipment' table. You can move, or remove it, as needed.
            this.tbl_EquipmentTableAdapter.Fill(this.emaduabuDataSet3.Tbl_Equipment);
            // TODO: This line of code loads data into the 'emaduabuDataSet3.Tbl_Equipment' table. You can move, or remove it, as needed.
            this.tbl_EquipmentTableAdapter.Fill(this.emaduabuDataSet3.Tbl_Equipment);

        }

        private void fillByEuipment_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillByEuipment_name(this.emaduabuDataSet3.Tbl_Equipment, equip_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByEquip_fuelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillByEquip_fuel(this.emaduabuDataSet3.Tbl_Equipment, equip_fuelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillBy(this.emaduabuDataSet3.Tbl_Equipment, equip_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEquip_nameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillByEquip_name(this.emaduabuDataSet3.Tbl_Equipment, equip_nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillBy1(this.emaduabuDataSet3.Tbl_Equipment, equip_fuelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEquip_fuellToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_EquipmentTableAdapter.FillByEquip_fuell(this.emaduabuDataSet3.Tbl_Equipment, equip_fuelToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
