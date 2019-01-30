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
    public partial class FrmOperations_dept : Form
    {
        public FrmOperations_dept()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipment has been Succesfully Dispatched.Email has been sent to customer");
        }
    }
}
