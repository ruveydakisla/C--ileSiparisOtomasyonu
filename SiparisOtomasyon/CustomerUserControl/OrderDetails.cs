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
    public partial class OrderDetails : UserControl
    {
        public OrderDetails()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        private void OrderDetails_Load(object sender, EventArgs e) //Sipariş tablosundaki verileri gridviewe aktarıyor
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Orders", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            kryptonDataGridView1.DataSource = tablo;
            kryptonDataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
            kryptonDataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
       
            baglanti.Close();
        }
    }
}
