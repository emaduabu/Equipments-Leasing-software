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
    public partial class FrmUpdateEquipment : Form
    {
        public FrmUpdateEquipment()
        {
            InitializeComponent();
        }

        private void tbl_EquipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_EquipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.emaduabuDataSet3);

        }

        private void FrmUpdateEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emaduabuDataSet3.Tbl_Equipment' table. You can move, or remove it, as needed.
            this.tbl_EquipmentTableAdapter.Fill(this.emaduabuDataSet3.Tbl_Equipment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbl_EquipmentBindingSource.MovePrevious();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_EquipmentBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tbl_EquipmentBindingSource.EndEdit();
            this.tbl_EquipmentTableAdapter.Update(emaduabuDataSet3.Tbl_Equipment);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tbl_EquipmentBindingSource.RemoveCurrent();
        }
    }
}
