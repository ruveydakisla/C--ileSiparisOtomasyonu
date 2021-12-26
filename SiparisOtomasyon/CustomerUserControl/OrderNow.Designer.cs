
namespace SiparisOtomasyon.CustomerUserControl
{
    partial class OrderNow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisOtomasyonProjeDataSet1 = new SiparisOtomasyon.SiparisOtomasyonProjeDataSet1();
            this.siparisOtomasyonProjeDataSet = new SiparisOtomasyon.SiparisOtomasyonProjeDataSet();
            this.siparisOtomasyonProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriKayitBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriKayitBilgiTableAdapter = new SiparisOtomasyon.SiparisOtomasyonProjeDataSetTableAdapters.MusteriKayitBilgiTableAdapter();
            this.musteriKayitBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new SiparisOtomasyon.SiparisOtomasyonProjeDataSet1TableAdapters.UrunTableAdapter();
            this.comboboxOrderNow = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTax = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBuy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BasketDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductQuantity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnAddBasket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtİslem = new System.Windows.Forms.TextBox();
            this.txtAzaltma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxOrderNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(722, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Now";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(806, 152);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(6, 350);
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.Black;
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.Black;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.urunBindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(140, 62);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(620, 263);
            this.kryptonDataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.Background.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 2;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.siparisOtomasyonProjeDataSet1;
            // 
            // siparisOtomasyonProjeDataSet1
            // 
            this.siparisOtomasyonProjeDataSet1.DataSetName = "SiparisOtomasyonProjeDataSet1";
            this.siparisOtomasyonProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisOtomasyonProjeDataSet
            // 
            this.siparisOtomasyonProjeDataSet.DataSetName = "SiparisOtomasyonProjeDataSet";
            this.siparisOtomasyonProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisOtomasyonProjeDataSetBindingSource
            // 
            this.siparisOtomasyonProjeDataSetBindingSource.DataSource = this.siparisOtomasyonProjeDataSet;
            this.siparisOtomasyonProjeDataSetBindingSource.Position = 0;
            // 
            // musteriKayitBilgiBindingSource
            // 
            this.musteriKayitBilgiBindingSource.DataMember = "MusteriKayitBilgi";
            this.musteriKayitBilgiBindingSource.DataSource = this.siparisOtomasyonProjeDataSetBindingSource;
            // 
            // musteriKayitBilgiTableAdapter
            // 
            this.musteriKayitBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // musteriKayitBilgiBindingSource1
            // 
            this.musteriKayitBilgiBindingSource1.DataMember = "MusteriKayitBilgi";
            this.musteriKayitBilgiBindingSource1.DataSource = this.siparisOtomasyonProjeDataSetBindingSource;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // comboboxOrderNow
            // 
            this.comboboxOrderNow.DropDownWidth = 188;
            this.comboboxOrderNow.Location = new System.Drawing.Point(418, 341);
            this.comboboxOrderNow.Name = "comboboxOrderNow";
            this.comboboxOrderNow.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.comboboxOrderNow.Size = new System.Drawing.Size(188, 25);
            this.comboboxOrderNow.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboboxOrderNow.StateNormal.Item.Back.Color1 = System.Drawing.Color.Black;
            this.comboboxOrderNow.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.txtTotalPrice);
            this.kryptonPanel2.Controls.Add(this.txtTax);
            this.kryptonPanel2.Controls.Add(this.btnBuy);
            this.kryptonPanel2.Controls.Add(this.BasketDataGridView);
            this.kryptonPanel2.Location = new System.Drawing.Point(818, 62);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(623, 509);
            this.kryptonPanel2.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.StateNormal.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 4;
            this.kryptonPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel2_Paint);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(59, 315);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(105, 59);
            this.kryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Total:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(83, 242);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(81, 59);
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Tax:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(187, 330);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(188, 27);
            this.txtTotalPrice.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.txtTotalPrice.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalPrice.TabIndex = 12;
            this.txtTotalPrice.Text = "00";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(187, 260);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(188, 27);
            this.txtTax.TabIndex = 11;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(171, 390);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(204, 63);
            this.btnBuy.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnBuy.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBuy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuy.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnBuy.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnBuy.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnBuy.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnBuy.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnBuy.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnBuy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuy.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnBuy.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnBuy.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnBuy.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnBuy.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnBuy.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnBuy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBuy.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnBuy.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnBuy.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Values.Text = "Buy";
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // BasketDataGridView
            // 
            this.BasketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BasketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BasketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity});
            this.BasketDataGridView.Location = new System.Drawing.Point(29, 3);
            this.BasketDataGridView.Name = "BasketDataGridView";
            this.BasketDataGridView.RowHeadersWidth = 51;
            this.BasketDataGridView.RowTemplate.Height = 24;
            this.BasketDataGridView.Size = new System.Drawing.Size(591, 160);
            this.BasketDataGridView.StateNormal.Background.Color1 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.Background.Color2 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BasketDataGridView.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BasketDataGridView.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.BasketDataGridView.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BasketDataGridView.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.BasketDataGridView.StateNormal.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.BasketDataGridView.TabIndex = 10;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(418, 409);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(188, 27);
            this.txtProductQuantity.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(241, 322);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(163, 59);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Products:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(229, 392);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(164, 59);
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel2.TabIndex = 7;
            this.kryptonLabel2.Values.Text = "Quantity:";
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.Location = new System.Drawing.Point(387, 462);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(188, 62);
            this.btnAddBasket.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAddBasket.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAddBasket.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBasket.StatePressed.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StatePressed.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StatePressed.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StatePressed.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddBasket.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAddBasket.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAddBasket.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBasket.StateTracking.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateTracking.Back.Color2 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateTracking.Border.Color1 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateTracking.Border.Color2 = System.Drawing.Color.Khaki;
            this.btnAddBasket.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddBasket.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btnAddBasket.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnAddBasket.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBasket.TabIndex = 8;
            this.btnAddBasket.Values.Text = "Add Basket";
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // txtİslem
            // 
            this.txtİslem.Location = new System.Drawing.Point(504, 541);
            this.txtİslem.Name = "txtİslem";
            this.txtİslem.Size = new System.Drawing.Size(12, 22);
            this.txtİslem.TabIndex = 10;
            this.txtİslem.Visible = false;
            // 
            // txtAzaltma
            // 
            this.txtAzaltma.Location = new System.Drawing.Point(531, 541);
            this.txtAzaltma.Name = "txtAzaltma";
            this.txtAzaltma.Size = new System.Drawing.Size(13, 22);
            this.txtAzaltma.TabIndex = 11;
            this.txtAzaltma.Visible = false;
            // 
            // OrderNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtAzaltma);
            this.Controls.Add(this.txtİslem);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.comboboxOrderNow);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.label1);
            this.Name = "OrderNow";
            this.Size = new System.Drawing.Size(1462, 557);
            this.Load += new System.EventHandler(this.OrderNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboboxOrderNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private SiparisOtomasyonProjeDataSet1 siparisOtomasyonProjeDataSet1;
        private SiparisOtomasyonProjeDataSet siparisOtomasyonProjeDataSet;
        private System.Windows.Forms.BindingSource siparisOtomasyonProjeDataSetBindingSource;
        private System.Windows.Forms.BindingSource musteriKayitBilgiBindingSource;
        private SiparisOtomasyonProjeDataSetTableAdapters.MusteriKayitBilgiTableAdapter musteriKayitBilgiTableAdapter;
        private System.Windows.Forms.BindingSource musteriKayitBilgiBindingSource1;
        private SiparisOtomasyonProjeDataSet1TableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboboxOrderNow;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBuy;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView BasketDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductQuantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddBasket;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalPrice;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.TextBox txtİslem;
        private System.Windows.Forms.TextBox txtAzaltma;
    }
}
