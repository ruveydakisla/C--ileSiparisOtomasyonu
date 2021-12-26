
namespace SiparisOtomasyon.AdminUserControl
{
    partial class AddProduct
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
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProductPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductWeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(442, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(750, 22);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(225, 46);
            this.txtProductName.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductName.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductName.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtProductName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProductName.StateCommon.Border.Rounding = 20;
            this.txtProductName.StateCommon.Border.Width = 1;
            this.txtProductName.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProductName.TabIndex = 1;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(750, 119);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(225, 46);
            this.txtProductPrice.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductPrice.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductPrice.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtProductPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProductPrice.StateCommon.Border.Rounding = 20;
            this.txtProductPrice.StateCommon.Border.Width = 1;
            this.txtProductPrice.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductPrice.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProductPrice.TabIndex = 3;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(455, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price:";
            // 
            // txtProductWeight
            // 
            this.txtProductWeight.Location = new System.Drawing.Point(750, 323);
            this.txtProductWeight.Name = "txtProductWeight";
            this.txtProductWeight.Size = new System.Drawing.Size(225, 46);
            this.txtProductWeight.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductWeight.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductWeight.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtProductWeight.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductWeight.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProductWeight.StateCommon.Border.Rounding = 20;
            this.txtProductWeight.StateCommon.Border.Width = 1;
            this.txtProductWeight.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductWeight.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductWeight.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProductWeight.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(397, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 61);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product Weight:";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(750, 222);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(225, 46);
            this.txtProductQuantity.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductQuantity.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.txtProductQuantity.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.txtProductQuantity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductQuantity.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProductQuantity.StateCommon.Border.Rounding = 20;
            this.txtProductQuantity.StateCommon.Border.Width = 1;
            this.txtProductQuantity.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductQuantity.StateCommon.Content.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductQuantity.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProductQuantity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(379, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAdd.Location = new System.Drawing.Point(624, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(258, 84);
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAdd.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAdd.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAdd.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAdd.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductPrice;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductWeight;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductQuantity;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
    }
}
