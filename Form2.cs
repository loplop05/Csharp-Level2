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
    public partial class Form2 : Form
    {

        public delegate void returnPersonID(object sender, int PersonID);

        public event returnPersonID PersonIDReturned;












        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendDataBack_Click(object sender, EventArgs e)
        {
            int persondID = int.Parse(txtPersonID.Text);
            PersonIDReturned?.Invoke(this, persondID);
            this.Close();
        }









    }
}
