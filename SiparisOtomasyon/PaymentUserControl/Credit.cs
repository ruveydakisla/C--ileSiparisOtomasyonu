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
    public partial class Credit : UserControl
    {
        public Credit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6CF2A79;Initial Catalog=SiparisOtomasyonProje;Integrated Security=True");
         
        private void btnBuyCredit_Click(object sender, EventArgs e)
        {
            Creditt credit = new Creditt();
            
            credit.CardNumber = txtCardNumber.Text;
            credit.Type = comboboxCardType.SelectedItem.ToString();
            credit.ExpDate= txtDateMonth.Text + "/" + txtDateYear.Text;
            credit.CVC = txtCardID.Text;
            baglanti.Open();
            SqlCommand ekleme = new SqlCommand("insert into Credit (CardNumber,Type,ExpDate,CVC) values (@f1,@f2,@f3,@f4)", baglanti);

            ekleme.Parameters.AddWithValue("@f1", credit.CardNumber);
            ekleme.Parameters.AddWithValue("@f2", credit.Type);
            ekleme.Parameters.AddWithValue("@f3", credit.ExpDate);
            ekleme.Parameters.AddWithValue("@f4", credit.CVC);
     
            ekleme.ExecuteNonQuery();
            MessageBox.Show("Your order has been recived...");

            baglanti.Close();
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            comboboxCardType.Items.Add("Mastercard");
            comboboxCardType.Items.Add("Visa");
            comboboxCardType.Items.Add("Troy");

        }
    }
}
