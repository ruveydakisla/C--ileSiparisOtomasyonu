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

namespace SiparisOtomasyon.UserControls
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e) //Butona tıklandığında customer classına ait nesne oluşturup bilgileri alıp kaydeder
        {
            
            Customer customer = new Customer();
            customer.FullName = nameTxt.Text;
            customer.Address = adressTxt.Text;
            customer.Email = mailTxt.Text;
            customer.UserName = kullaniciAdiTxt.Text;
            customer.Password = sifreTxt.Text;
            customer.Telephone = telefonTxt.Text;
            customer.AddCustomer();
        }
    }
}
