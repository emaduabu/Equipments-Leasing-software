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
    public partial class FrmMain2 : Form
    {
        public FrmMain2()
        {
            InitializeComponent();
        }

        private void operationStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewLeaseRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperations_dept FrmOP = new FrmOperations_dept();
            FrmOP.ShowDialog();
        }

        private void updateEquipmentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMechanical_dept FrmME = new FrmMechanical_dept();
            FrmME.ShowDialog();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Management_Report FrmMR = new Frm_Management_Report();
            FrmMR.ShowDialog();
        }

        private void systemAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSYS frmSY = new FrmSYS();
            frmSY.ShowDialog();
                
        }

        private void viewAvailableEquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipment frmEquipment = new FrmEquipment();
            frmEquipment.ShowDialog();
        }

        private void viewCustomersContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerdetails frmcustdet = new FrmCustomerdetails();
            frmcustdet.ShowDialog();
        }

        private void updateEquipmentStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUpdateEquipment frmUpdate = new FrmUpdateEquipment();
            frmUpdate.ShowDialog();
        }
    }
}
