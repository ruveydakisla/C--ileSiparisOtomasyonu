
namespace SiparisOtomasyon.PaymentUserControl
{
    partial class Credit
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
            this.txtDateMonth = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDateYear = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCardNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCardID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.comboboxCardType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnBuyCredit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxCardType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDateMonth
            // 
            this.txtDateMonth.Location = new System.Drawing.Point(374, 293);
            this.txtDateMonth.Name = "txtDateMonth";
            this.txtDateMonth.Size = new System.Drawing.Size(37, 27);
            this.txtDateMonth.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtDateMonth.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtDateMonth.TabIndex = 1;
            // 
            // txtDateYear
            // 
            this.txtDateYear.Location = new System.Drawing.Point(442, 293);
            this.txtDateYear.Name = "txtDateYear";
            this.txtDateYear.Size = new System.Drawing.Size(37, 27);
            this.txtDateYear.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtDateYear.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtDateYear.TabIndex = 2;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(373, 153);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(170, 27);
            this.txtCardNumber.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtCardNumber.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtCardNumber.StateNormal.Back.Color1 = System.Drawing.Color.Silver;
            this.txtCardNumber.TabIndex = 4;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(374, 220);
            this.txtCardID.MaxLength = 3;
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(64, 27);
            this.txtCardID.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtCardID.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtCardID.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(150, 138);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(215, 53);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Card Number:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(374, 27);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(174, 90);
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Credit";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(270, 207);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(82, 53);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "CVC:";
            // 
            // comboboxCardType
            // 
            this.comboboxCardType.DropDownWidth = 170;
            this.comboboxCardType.Location = new System.Drawing.Point(371, 373);
            this.comboboxCardType.Name = "comboboxCardType";
            this.comboboxCardType.Size = new System.Drawing.Size(170, 25);
            this.comboboxCardType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Silver;
            this.comboboxCardType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.comboboxCardType.TabIndex = 9;
            // 
            // btnBuyCredit
            // 
            this.btnBuyCredit.Location = new System.Drawing.Point(304, 458);
            this.btnBuyCredit.Name = "btnBuyCredit";
            this.btnBuyCredit.Size = new System.Drawing.Size(239, 80);
            this.btnBuyCredit.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnBuyCredit.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBuyCredit.StateNormal.Border.Color1 = System.Drawing.Color.Cyan;
            this.btnBuyCredit.StateNormal.Border.Color2 = System.Drawing.Color.Cyan;
            this.btnBuyCredit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuyCredit.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Cyan;
            this.btnBuyCredit.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Cyan;
            this.btnBuyCredit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyCredit.TabIndex = 10;
            this.btnBuyCredit.Values.Text = "Buy Credit";
            this.btnBuyCredit.Click += new System.EventHandler(this.btnBuyCredit_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(419, 293);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(19, 28);
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "/";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(182, 359);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(170, 53);
            this.kryptonLabel5.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel5.TabIndex = 12;
            this.kryptonLabel5.Values.Text = "Card Type:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(158, 280);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(194, 53);
            this.kryptonLabel6.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel6.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel6.TabIndex = 13;
            this.kryptonLabel6.Values.Text = "Month/Year:";
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.btnBuyCredit);
            this.Controls.Add(this.comboboxCardType);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtDateYear);
            this.Controls.Add(this.txtDateMonth);
            this.Name = "Credit";
            this.Size = new System.Drawing.Size(922, 557);
            this.Load += new System.EventHandler(this.Credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboboxCardType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDateYear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCardNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCardID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboboxCardType;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuyCredit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
    }
}
