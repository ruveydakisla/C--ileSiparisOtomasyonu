using SiparisOtomasyon.PaymentUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
            Credit credit = new Credit();
            addUserControl(credit);
        }
        public decimal tuttar1;
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnCredit_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            addUserControl(credit);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            addUserControl(check);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CASH cash = new CASH();
            addUserControl(cash);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MusteriPaneli musteriPaneli = new MusteriPaneli();
            this.Hide();
            musteriPaneli.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
