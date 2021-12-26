using SiparisOtomasyon.AdminUserControl;
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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
            AddProduct addProduct = new AddProduct();
            addUserControl(addProduct);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addUserControl(addProduct);

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            RemoveProduct removeProduct = new RemoveProduct();
            addUserControl(removeProduct);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            addUserControl(updateProduct);
        }

        private void btnCustomerTracking_Click(object sender, EventArgs e)
        {
            CustomerTracking customerTracking = new CustomerTracking();
            addUserControl(customerTracking);
        }
    }
}
