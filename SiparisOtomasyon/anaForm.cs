using SiparisOtomasyon.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
            Home sayfa = new Home();   //Anaformun içerisinde açılır açılmaz ilk olarak Home sayfası geliyo
            addUserControl(sayfa);

        }
        private void anaForm_Load(object sender, EventArgs e)
        {
            
        }
        private void addUserControl(UserControl userControl)   //Formların içerisindeki ana panele kontrol formları ekleyen method
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home sayfa = new Home();
            addUserControl(sayfa);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login log = new login();
            addUserControl(log);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register reg = new register();
            addUserControl(reg);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();  //Uygulamadan çıkar
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
