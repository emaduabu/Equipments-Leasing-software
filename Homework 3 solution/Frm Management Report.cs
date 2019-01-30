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
    public partial class Frm_Management_Report : Form
    {
        public Frm_Management_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInventory frminvent = new FrmInventory();
            frminvent.ShowDialog();
        }
    }
}
