
namespace SiparisOtomasyon.UserControls
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtCpassword = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtNickName = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.txtApassword = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.btnClogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAlogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(556, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 330);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(725, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 79);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(171, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 5);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(739, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 5);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(171, 125);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(215, 50);
            this.txtUserName.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.txtUserName.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txtUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUserName.StateCommon.Border.Rounding = 20;
            this.txtUserName.StateCommon.Border.Width = 1;
            this.txtUserName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUserName.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUserName.TabIndex = 20;
            this.txtUserName.Text = "User Name";
            // 
            // txtCpassword
            // 
            this.txtCpassword.Location = new System.Drawing.Point(171, 209);
            this.txtCpassword.Name = "txtCpassword";
            this.txtCpassword.Size = new System.Drawing.Size(215, 50);
            this.txtCpassword.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtCpassword.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtCpassword.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtCpassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCpassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCpassword.StateCommon.Border.Rounding = 20;
            this.txtCpassword.StateCommon.Border.Width = 1;
            this.txtCpassword.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtCpassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCpassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCpassword.TabIndex = 21;
            this.txtCpassword.Text = "password";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(693, 125);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(215, 47);
            this.txtNickName.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtNickName.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtNickName.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtNickName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNickName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtNickName.StateCommon.Border.Rounding = 20;
            this.txtNickName.StateCommon.Border.Width = 1;
            this.txtNickName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNickName.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNickName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtNickName.TabIndex = 22;
            this.txtNickName.Text = "Nick Name";
            // 
            // txtApassword
            // 
            this.txtApassword.Location = new System.Drawing.Point(693, 212);
            this.txtApassword.Name = "txtApassword";
            this.txtApassword.Size = new System.Drawing.Size(225, 47);
            this.txtApassword.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtApassword.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtApassword.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtApassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtApassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtApassword.StateCommon.Border.Rounding = 20;
            this.txtApassword.StateCommon.Border.Width = 1;
            this.txtApassword.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtApassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtApassword.TabIndex = 23;
            this.txtApassword.Text = "password";
            // 
            // btnClogin
            // 
            this.btnClogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnClogin.Location = new System.Drawing.Point(171, 304);
            this.btnClogin.Name = "btnClogin";
            this.btnClogin.Size = new System.Drawing.Size(215, 55);
            this.btnClogin.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnClogin.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnClogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClogin.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.btnClogin.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Silver;
            this.btnClogin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClogin.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnClogin.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnClogin.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.btnClogin.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.btnClogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnClogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnClogin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClogin.TabIndex = 24;
            this.btnClogin.Values.Text = "Login";
            this.btnClogin.Click += new System.EventHandler(this.btnClogin_Click);
            // 
            // btnAlogin
            // 
            this.btnAlogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAlogin.Location = new System.Drawing.Point(693, 304);
            this.btnAlogin.Name = "btnAlogin";
            this.btnAlogin.Size = new System.Drawing.Size(215, 55);
            this.btnAlogin.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Silver;
            this.btnAlogin.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Silver;
            this.btnAlogin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlogin.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnAlogin.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnAlogin.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.btnAlogin.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.btnAlogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAlogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAlogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnAlogin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlogin.TabIndex = 25;
            this.btnAlogin.Values.Text = "Login";
            this.btnAlogin.Click += new System.EventHandler(this.btnAlogin_Click);
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAlogin);
            this.Controls.Add(this.btnClogin);
            this.Controls.Add(this.txtApassword);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.txtCpassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtCpassword;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtNickName;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox txtApassword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAlogin;
    }
}
