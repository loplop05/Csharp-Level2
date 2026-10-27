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
    public partial class ctrlCalculator : UserControl
    {
        public ctrlCalculator()
        {
            InitializeComponent();
        }

        public event Action<int> OnCalculationCompleted;

        protected virtual void CalcuationComplete(int PersonID)
        {
            Action<int> handler = OnCalculationCompleted;
            if (handler != null)
            {
                handler(PersonID);
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) + Convert.ToInt32(txtNumber2.Text);   
            lblResult.Text = result.ToString();
            if(OnCalculationCompleted != null)
            {
                CalcuationComplete(result);
            }
        }
    }
}
