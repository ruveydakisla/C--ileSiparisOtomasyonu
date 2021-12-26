using SiparisOtomasyon.CustomerUserControl;
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
    public partial class MusteriPaneli : Form
    {
        public MusteriPaneli()
        {
            InitializeComponent();
            OrderNow orderNow = new OrderNow();
            addUserControl(orderNow);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            anaForm anaForm = new anaForm();
            this.Hide();
            anaForm.Show();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            OrderNow orderNow = new OrderNow();
            addUserControl(orderNow);
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            addUserControl(orderDetails);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
