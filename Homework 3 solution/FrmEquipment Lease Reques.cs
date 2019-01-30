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
    public partial class FrmEquipment_Lease_Reques : Form
    {
        public FrmEquipment_Lease_Reques()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //open contact panel
            FrmContactPanel frmContact = new FrmContactPanel();
           
            frmContact.ShowDialog();

        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No available equipments presently");
        }

        private void FrmEquipment_Lease_Reques_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //open contact panel
            FrmContactPanel frmContactPanel = new FrmContactPanel();
            frmContactPanel.ShowDialog();
        }
    }
}
