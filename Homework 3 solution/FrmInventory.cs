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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emaduabuDataSet2.Tbl_Inventory' table. You can move, or remove it, as needed.
            this.tbl_InventoryTableAdapter.Fill(this.emaduabuDataSet2.Tbl_Inventory);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_InventoryTableAdapter.FillBy(this.emaduabuDataSet2.Tbl_Inventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByEquip_IDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_InventoryTableAdapter.FillByEquip_ID(this.emaduabuDataSet2.Tbl_Inventory, equip_IDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
