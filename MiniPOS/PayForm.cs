using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPOS
{
    public partial class PayForm : Form
    {
        public PaymentType PaymentType { get; set; }

        public PayForm()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (this.radioButtonCash.Checked)
            {
                this.PaymentType = PaymentType.Cash;
            }
            else if (this.radioButtonCreditCard.Checked)
            {
                this.PaymentType = PaymentType.CreditCard;
            }
        }
    }
}
