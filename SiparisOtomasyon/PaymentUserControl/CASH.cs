using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.PaymentUserControl
{
    public partial class CASH : UserControl
    {
        public CASH()
        {
            InitializeComponent();
        }
      
        private void Cash_Load(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            lbltutar.Text = pay.tuttar1.ToString();
        }

        private void btnBuyy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been recived...");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
