using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Level2
{
    public partial class frmTest2 : Form
    {


        public frmTest2()
        {
            InitializeComponent();
        }

        private void ctrlCalculator1_OnCalculationCompleted(int obj)
        {
            MessageBox.Show("Calculation completed with result: " + obj.ToString());
        }
    }
}
