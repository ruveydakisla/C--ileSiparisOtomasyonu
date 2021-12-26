
namespace SiparisOtomasyon.UserControls
{
    partial class register
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.adressTxt = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(405, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 85);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTxt.Location = new System.Drawing.Point(172, 84);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(196, 48);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.Text = "FullName";
            // 
            // telefonTxt
            // 
            this.telefonTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.telefonTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telefonTxt.Location = new System.Drawing.Point(172, 177);
            this.telefonTxt.MaxLength = 11;
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(196, 48);
            this.telefonTxt.TabIndex = 9;
            this.telefonTxt.Text = "Telephone";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // mailTxt
            // 
            this.mailTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mailTxt.Location = new System.Drawing.Point(172, 266);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(196, 48);
            this.mailTxt.TabIndex = 12;
            this.mailTxt.Text = "E-Mail";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(100, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kullaniciAdiTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullaniciAdiTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(712, 85);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(180, 48);
            this.kullaniciAdiTxt.TabIndex = 15;
            this.kullaniciAdiTxt.Text = "User Name";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(636, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // sifreTxt
            // 
            this.sifreTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sifreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifreTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifreTxt.Location = new System.Drawing.Point(712, 180);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(180, 48);
            this.sifreTxt.TabIndex = 18;
            this.sifreTxt.Text = "Password";
            this.sifreTxt.UseSystemPasswordChar = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(636, 180);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // adressTxt
            // 
            this.adressTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adressTxt.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adressTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adressTxt.Location = new System.Drawing.Point(712, 266);
            this.adressTxt.Multiline = true;
            this.adressTxt.Name = "adressTxt";
            this.adressTxt.Size = new System.Drawing.Size(180, 129);
            this.adressTxt.TabIndex = 21;
            this.adressTxt.Text = "Address";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(636, 266);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(116, 396);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(252, 77);
            this.btnRegister.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegister.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegister.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.btnRegister.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Silver;
            this.btnRegister.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnRegister.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnRegister.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.btnRegister.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.btnRegister.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRegister.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Values.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.adressTxt);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.kullaniciAdiTxt);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.telefonTxt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "register";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox adressTxt;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRegister;
    }
}
