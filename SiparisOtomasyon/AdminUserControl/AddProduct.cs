using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.AdminUserControl
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Product nesnesi oluşturup bilgileri aldıktan sonra sql e kaydeder
        {
            int pricee = Convert.ToInt32(txtProductPrice.Text);
            int quantityy = Convert.ToInt32(txtProductQuantity.Text);
            int weightt = Convert.ToInt32(txtProductWeight.Text);

            Product product = new Product();
            product.NameProduct = txtProductName.Text;
            product.Price = pricee;
            product.Quantity = quantityy;
            product.WeightProduct = weightt;
            product.AddProduct();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
