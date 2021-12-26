
namespace SiparisOtomasyon.AdminUserControl
{
    partial class UpdateProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateCombobox = new System.Windows.Forms.ComboBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(533, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(459, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // UpdateCombobox
            // 
            this.UpdateCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateCombobox.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateCombobox.FormattingEnabled = true;
            this.UpdateCombobox.Location = new System.Drawing.Point(688, 99);
            this.UpdateCombobox.Name = "UpdateCombobox";
            this.UpdateCombobox.Size = new System.Drawing.Size(209, 39);
            this.UpdateCombobox.TabIndex = 2;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUpdatePrice.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdatePrice.Location = new System.Drawing.Point(688, 207);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(209, 38);
            this.txtUpdatePrice.TabIndex = 3;
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUpdateQuantity.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateQuantity.Location = new System.Drawing.Point(688, 311);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(209, 38);
            this.txtUpdateQuantity.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(688, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 82);
            this.btnUpdate.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Red;
            this.btnUpdate.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Red;
            this.btnUpdate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.btnUpdate.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.btnUpdate.StatePressed.Border.Color1 = System.Drawing.Color.Red;
            this.btnUpdate.StatePressed.Border.Color2 = System.Drawing.Color.Red;
            this.btnUpdate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnUpdate.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.btnUpdate.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.btnUpdate.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.btnUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdateQuantity);
            this.Controls.Add(this.txtUpdatePrice);
            this.Controls.Add(this.UpdateCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UpdateCombobox;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
    }
}
