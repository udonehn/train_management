using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    public partial class Payment : Form
    {
        public int SelectedPaymentId { get; private set; }
        public Payment()
        {
            InitializeComponent();
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SelectedPaymentId = 1;
            }
            else if (radioButton2.Checked)
            {
                SelectedPaymentId = 2;
            }
            else if (radioButton3.Checked)
            {
                SelectedPaymentId = 3;
            }
            else if (radioButton4.Checked)
            {
                SelectedPaymentId = 4;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
