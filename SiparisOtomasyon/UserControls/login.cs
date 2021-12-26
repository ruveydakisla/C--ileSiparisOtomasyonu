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
using System.Data.Sql;

namespace SiparisOtomasyon.UserControls
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");//Sql ile bağlantıyı kurar
        SqlDataReader reader; //Sql den okuma yapmak için gerekli tanımlama


        private void login_Load(object sender, EventArgs e)
        {

        }
        

        

        private void btnAlogin_Click(object sender, EventArgs e)  //Butona tıklandığında sql ile bilgileri karşılaştırıp ona göre giriş yapıyor
        {
           
            string nickname = txtNickName.Text;
            string password = txtApassword.Text;
            baglanti.Open();
            SqlCommand command = new SqlCommand("Select *from AdminLogin where NickName='" + nickname + "'And Password='" + password + "'", baglanti);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Admin girişi başarılı");
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();


            }
            else
            {
                MessageBox.Show("Hatalı giriş...\nTekrar Deneyiniz.");
                txtNickName.Clear();
                txtApassword.Clear();
            }
            baglanti.Close();

        }

        private void btnClogin_Click(object sender, EventArgs e) //Butona tıklandığında sql ile bilgileri karşılaştırıp ona göre giriş yapıyor
        {
            string nickname = txtUserName.Text;
           string password = txtCpassword.Text;
           baglanti.Open();
           SqlCommand command = new SqlCommand("Select *from MusteriKayitBilgi where UserName='" + nickname + "'And Password='" + password + "'", baglanti);
           reader = command.ExecuteReader();
           if (reader.Read())
           {
               MessageBox.Show("Kullanıcı girişi başarılı");
                MusteriPaneli musteriPaneli = new MusteriPaneli();
                musteriPaneli.Show();
           }
           else
           {
               MessageBox.Show("Hatalı giriş...\nTekrar Deneyiniz.");
               txtUserName.Clear();
               txtCpassword.Clear();
           }
           baglanti.Close(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
