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
    public partial class RemoveProduct : UserControl
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        private void RemoveProduct_Load(object sender, EventArgs e)//form yüklendiğinde comboboxa ürün isimlerini listeler
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ProductName from Urun", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                RemoveCombobox.Items.Add(reader[0]);
            }
            baglanti.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)//Butona tıklandığında seçili ürünü siler
        {
            Product removeProduct = new Product();
            removeProduct.NameProduct = RemoveCombobox.SelectedItem.ToString();
            removeProduct.RemoveProduct();
        }
    }
}
