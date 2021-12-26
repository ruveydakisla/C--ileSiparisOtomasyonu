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
    public partial class CustomerTracking : UserControl
    {
        public CustomerTracking()
        {
            InitializeComponent();
        }

        private void CustomerTracking_Load(object sender, EventArgs e)//Form yüklendiğinde kayıt olan müşterilerin adres ve iletişim bilgilerini gösterir
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

            baglanti.Open();
           SqlDataAdapter da = new SqlDataAdapter("Select *From MusteriKayitBilgi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            kryptonDataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
