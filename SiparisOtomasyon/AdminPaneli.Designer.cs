
namespace SiparisOtomasyon
{
    partial class AdminPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCustomerTracking = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdateProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRemoveProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddProduct = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 75);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAR MUSİC COMPANY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSignOut);
            this.panel2.Controls.Add(this.btnCustomerTracking);
            this.panel2.Controls.Add(this.btnUpdateProduct);
            this.panel2.Controls.Add(this.btnRemoveProduct);
            this.panel2.Controls.Add(this.btnAddProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 64);
            this.panel2.TabIndex = 2;
            // 
            // btnSignOut
            // 
            this.btnSignOut.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnSignOut.Location = new System.Drawing.Point(892, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSignOut.Size = new System.Drawing.Size(223, 64);
            this.btnSignOut.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignOut.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnSignOut.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnSignOut.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnSignOut.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnSignOut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnSignOut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnSignOut.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignOut.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnSignOut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignOut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnSignOut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnSignOut.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Values.Text = "Sign Out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnCustomerTracking
            // 
            this.btnCustomerTracking.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnCustomerTracking.Location = new System.Drawing.Point(669, 0);
            this.btnCustomerTracking.Name = "btnCustomerTracking";
            this.btnCustomerTracking.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCustomerTracking.Size = new System.Drawing.Size(223, 64);
            this.btnCustomerTracking.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerTracking.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomerTracking.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnCustomerTracking.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnCustomerTracking.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerTracking.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnCustomerTracking.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCustomerTracking.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnCustomerTracking.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnCustomerTracking.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerTracking.TabIndex = 4;
            this.btnCustomerTracking.Values.Text = "Customer Tracking";
            this.btnCustomerTracking.Click += new System.EventHandler(this.btnCustomerTracking_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnUpdateProduct.Location = new System.Drawing.Point(446, 0);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUpdateProduct.Size = new System.Drawing.Size(223, 64);
            this.btnUpdateProduct.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProduct.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateProduct.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnUpdateProduct.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnUpdateProduct.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProduct.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnUpdateProduct.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdateProduct.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnUpdateProduct.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnUpdateProduct.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Values.Text = "Update Product";
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnRemoveProduct.Location = new System.Drawing.Point(223, 0);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnRemoveProduct.Size = new System.Drawing.Size(223, 64);
            this.btnRemoveProduct.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveProduct.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnRemoveProduct.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnRemoveProduct.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveProduct.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnRemoveProduct.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoveProduct.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnRemoveProduct.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnRemoveProduct.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Values.Text = "Remove Product";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btnAddProduct.Location = new System.Drawing.Point(1, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAddProduct.Size = new System.Drawing.Size(223, 64);
            this.btnAddProduct.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAddProduct.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAddProduct.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAddProduct.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddProduct.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAddProduct.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAddProduct.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Values.Image")));
            this.btnAddProduct.Values.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 493);
            this.panel3.TabIndex = 3;
            // 
            // AdminPaneli
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SiparisOtomasyon.Properties.Resources.foto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 632);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSignOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCustomerTracking;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdateProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoveProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}