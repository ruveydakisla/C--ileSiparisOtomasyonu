using SiparisOtomasyon.PaymentUserControl;
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

namespace SiparisOtomasyon.CustomerUserControl
{
    public partial class OrderNow : UserControl
    {
        public OrderNow()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.urunTableAdapter.FillBy(this.siparisOtomasyonProjeDataSet1.Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void addGridView() //Gridview e urun tablosundaki verileri sıralar
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Urun", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            kryptonDataGridView1.DataSource = tablo;
            kryptonDataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            kryptonDataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
            BasketDataGridView.ReadOnly = true; 
            BasketDataGridView.AllowUserToDeleteRows = false;
            baglanti.Close();
        }
        private void OrderNow_Load(object sender, EventArgs e)
        {
            addGridView();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ProductName from Urun", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboboxOrderNow.Items.Add(reader[0]);
            }
            baglanti.Close();
        }
        
        private void btnAddBasket_Click(object sender, EventArgs e)
        {
          BasketDataGridView.Rows.Add(comboboxOrderNow.SelectedItem.ToString(), txtProductQuantity.Text); //sepete seçilen ürün bilgilerini girer
            txtTax.Text = "%18";
            decimal price;
            decimal totalprice = Convert.ToDecimal(txtTotalPrice.Text);
            decimal ptotalprice;
            decimal islem;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ProductPrice from Urun where ProductName='" + comboboxOrderNow.SelectedItem.ToString() + "'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                price = Convert.ToDecimal(reader["ProductPrice"]);
                islem= price * Convert.ToDecimal(txtProductQuantity.Text);
                txtİslem.Text = Convert.ToString(islem);
                totalprice += islem;
                ptotalprice = (totalprice * 18 / 100) + totalprice;
                txtTotalPrice.Text = Convert.ToString(ptotalprice);
                Pay cASH = new Pay();
                cASH.tuttar1 = Convert.ToDecimal(txtTotalPrice.Text);
            }
            baglanti.Close();

            baglanti.Open(); //Sipariş tablosuna sipariş bilgilerini kaydeder

            SqlCommand ekleme = new SqlCommand("insert into Orders (Name,Price,Quantity) values (@r1,@r2,@r3)", baglanti);
            string namee = comboboxOrderNow.SelectedItem.ToString();
            decimal quantity = Convert.ToDecimal(txtProductQuantity.Text);
            decimal pricee= Convert.ToDecimal(txtİslem.Text);
            ekleme.Parameters.AddWithValue("@r1", namee);
            ekleme.Parameters.AddWithValue("@r2", pricee);
            ekleme.Parameters.AddWithValue("@r3", quantity);
            ekleme.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand command = new SqlCommand("Select ProductQuantity from Urun where ProductName='" + comboboxOrderNow.SelectedItem.ToString() + "'", baglanti);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtAzaltma.Text = sqlDataReader[0].ToString();
            }
            baglanti.Close();

            baglanti.Open(); //Alınan ürün miktarı kadarını toplam üründen çıkarır
            decimal azaltma = Convert.ToDecimal(txtAzaltma.Text) - quantity;
            SqlCommand komut2 = new SqlCommand("update Urun set ProductQuantity=@a3 where ProductName=@a1", baglanti);
            komut2.Parameters.AddWithValue("@a1", comboboxOrderNow.SelectedItem.ToString());
            komut2.Parameters.AddWithValue("@a3", azaltma);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            addGridView(); //Methodu çağırır
        }

        private void btnGoBasket_Click(object sender, EventArgs e)
        {
          //  kryptonPanel2.Visible = true;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
            Pay pay = new Pay();
            pay.Show();
            
        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
