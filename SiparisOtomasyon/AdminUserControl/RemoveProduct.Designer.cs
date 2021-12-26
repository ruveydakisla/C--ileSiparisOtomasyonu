
namespace SiparisOtomasyon.AdminUserControl
{
    partial class RemoveProduct
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
            this.RemoveCombobox = new System.Windows.Forms.ComboBox();
            this.btnRemove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(377, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Product:";
            // 
            // RemoveCombobox
            // 
            this.RemoveCombobox.BackColor = System.Drawing.Color.White;
            this.RemoveCombobox.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveCombobox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RemoveCombobox.FormattingEnabled = true;
            this.RemoveCombobox.Location = new System.Drawing.Point(753, 66);
            this.RemoveCombobox.Name = "RemoveCombobox";
            this.RemoveCombobox.Size = new System.Drawing.Size(308, 55);
            this.RemoveCombobox.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(633, 205);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(250, 92);
            this.btnRemove.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnRemove.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnRemove.StateNormal.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StateNormal.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.StatePressed.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StatePressed.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StatePressed.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StatePressed.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemove.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemove.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.StateTracking.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnRemove.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnRemove.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemove.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRemove.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRemove.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Values.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.RemoveCombobox);
            this.Controls.Add(this.label1);
            this.Name = "RemoveProduct";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RemoveCombobox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemove;
    }
}
