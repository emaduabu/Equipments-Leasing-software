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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equpimentLeaseRequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void requestOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void equipmentStatusUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open lease Request form
            FrmEquipment_Lease_Reques frmEquipment_Lease= new FrmEquipment_Lease_Reques();
            frmEquipment_Lease.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open employee portal
            FrmMain2 FrmM2 = new FrmMain2();
            FrmM2.ShowDialog();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
