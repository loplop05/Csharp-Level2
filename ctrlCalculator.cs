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

        //public event Action<int> OnCalculationCompleted;

        //protected virtual void CalcuationComplete(int PersonID)
        //{
        //    Action<int> handler = OnCalculationCompleted;
        //    if (handler != null)
        //    {
        //        handler(PersonID);
        //    }
        //}


        public class CalculationCompleteEventArgs : EventArgs
        {
            public int Result { get; }
            public int number1 { get; }
            public int number2 { get; }

            public CalculationCompleteEventArgs(int result, int num1, int num2)
            {
                Result = result;
                number1 = num1;
                number2 = num2;
            }

        }


       public event EventHandler<CalculationCompleteEventArgs> OnCalculationCompleted;


        public void RaiseOnCalculationCompleted(int result, int num1, int num2)
        {
            RaiseOnCalculationCompleted(new CalculationCompleteEventArgs(result, num1, num2));
        }

        protected virtual void RaiseOnCalculationCompleted(CalculationCompleteEventArgs e)
        {
            OnCalculationCompleted?.Invoke(this, e);
        }









        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);
            int result = num1 + num2;
            lblResult.Text = result.ToString();
            if(OnCalculationCompleted != null)
            {
                RaiseOnCalculationCompleted(result,num1,num2);
            }
        }



        




















    }
}
