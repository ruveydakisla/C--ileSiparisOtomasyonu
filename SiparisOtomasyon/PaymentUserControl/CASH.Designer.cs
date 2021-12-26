
namespace SiparisOtomasyon.PaymentUserControl
{
    partial class CASH
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
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnBuyy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbltutar = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(403, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(334, 194);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(148, 83);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Total:";
            // 
            // btnBuyy
            // 
            this.btnBuyy.Location = new System.Drawing.Point(353, 338);
            this.btnBuyy.Name = "btnBuyy";
            this.btnBuyy.Size = new System.Drawing.Size(220, 95);
            this.btnBuyy.StateCommon.Border.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuyy.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnBuyy.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBuyy.StateNormal.Border.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateNormal.Border.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuyy.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyy.StatePressed.Back.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StatePressed.Back.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StatePressed.Border.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StatePressed.Border.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuyy.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBuyy.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBuyy.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyy.StateTracking.Back.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateTracking.Back.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateTracking.Border.Color1 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateTracking.Border.Color2 = System.Drawing.Color.Aqua;
            this.btnBuyy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuyy.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBuyy.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBuyy.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyy.TabIndex = 3;
            this.btnBuyy.Values.Text = "Buy";
            this.btnBuyy.Click += new System.EventHandler(this.btnBuyy_Click);
            // 
            // lbltutar
            // 
            this.lbltutar.Location = new System.Drawing.Point(488, 194);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(85, 83);
            this.lbltutar.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.lbltutar.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.TabIndex = 4;
            this.lbltutar.Values.Text = "00";
            // 
            // CASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.btnBuyy);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.label1);
            this.Name = "CASH";
            this.Size = new System.Drawing.Size(922, 557);
            this.Load += new System.EventHandler(this.Cash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuyy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbltutar;
    }
}
