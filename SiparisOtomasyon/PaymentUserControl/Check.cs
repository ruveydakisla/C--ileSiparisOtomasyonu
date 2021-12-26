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

namespace SiparisOtomasyon.PaymentUserControl
{
    public partial class Check : UserControl
    {
        public Check()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");

        private void btnCheck_Click(object sender, EventArgs e) 
        {
            Checkk checkk = new Checkk();  
            checkk.Name = txtName.Text;
            checkk.BankkID = txtBankId.Text;
            baglanti.Open();
            SqlCommand ekleme = new SqlCommand("insert into [CHECK] (Namee,Bankid) values (@c1,@c2)", baglanti);

            ekleme.Parameters.AddWithValue("@c1", checkk.Name);
            ekleme.Parameters.AddWithValue("@c2", checkk.BankkID);        
            ekleme.ExecuteNonQuery();
            MessageBox.Show("Your order has been recived...");

            baglanti.Close();
        }
    }
}
