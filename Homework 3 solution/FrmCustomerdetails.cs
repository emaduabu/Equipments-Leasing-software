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
    public partial class FrmCustomerdetails : Form
    {
        public FrmCustomerdetails()
        {
            InitializeComponent();
        }

        private void FrmCustomerdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emaduabuDataSet4.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.emaduabuDataSet4.Tbl_Customer);
            // TODO: This line of code loads data into the 'emaduabuDataSet4.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.emaduabuDataSet4.Tbl_Customer);
            // TODO: This line of code loads data into the 'emaduabuDataSet4.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.emaduabuDataSet4.Tbl_Customer);
            // TODO: This line of code loads data into the 'emaduabuDataSet4.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.emaduabuDataSet4.Tbl_Customer);

        }

        private void custom_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
