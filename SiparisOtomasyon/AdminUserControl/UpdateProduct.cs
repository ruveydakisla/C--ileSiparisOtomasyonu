using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.AdminUserControl
{
    public partial class UpdateProduct : UserControl
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        private void UpdateProduct_Load(object sender, EventArgs e)//form yüklendiğinde comboboxa ürün isimlerini listeler
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ProductName from Urun", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                UpdateCombobox.Items.Add(reader[0]);
            }
            baglanti.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//Seçili ürüne ait bilgileri günceller
        {
            Product updateProduct = new Product();
            updateProduct.NameProduct = UpdateCombobox.SelectedItem.ToString();
            updateProduct.Price = Convert.ToInt32(txtUpdatePrice.Text);
            updateProduct.Quantity = Convert.ToInt32(txtUpdateQuantity.Text);
            updateProduct.UpdateProduct();
        }
    }
}
