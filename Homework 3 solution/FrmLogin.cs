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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emaduabuDataSet1.Tbl_Operations' table. You can move, or remove it, as needed.
            this.tbl_OperationsTableAdapter.Fill(this.emaduabuDataSet1.Tbl_Operations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open from main
            FrmMain2 frmMain2 = new FrmMain2();
            frmMain2.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
