
namespace SiparisOtomasyon.AdminUserControl
{
    partial class CustomerTracking
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriKayitBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisOtomasyonProjeDataSet = new SiparisOtomasyon.SiparisOtomasyonProjeDataSet();
            this.musteriKayitBilgiTableAdapter = new SiparisOtomasyon.SiparisOtomasyonProjeDataSetTableAdapters.MusteriKayitBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.musteriKayitBilgiBindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(85, 74);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1027, 416);
            this.kryptonDataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView1.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
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
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // musteriKayitBilgiBindingSource
            // 
            this.musteriKayitBilgiBindingSource.DataMember = "MusteriKayitBilgi";
            this.musteriKayitBilgiBindingSource.DataSource = this.siparisOtomasyonProjeDataSet;
            // 
            // siparisOtomasyonProjeDataSet
            // 
            this.siparisOtomasyonProjeDataSet.DataSetName = "SiparisOtomasyonProjeDataSet";
            this.siparisOtomasyonProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriKayitBilgiTableAdapter
            // 
            this.musteriKayitBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "CustomerTracking";
            this.Size = new System.Drawing.Size(1115, 493);
            this.Load += new System.EventHandler(this.CustomerTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriKayitBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisOtomasyonProjeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource musteriKayitBilgiBindingSource;
        private SiparisOtomasyonProjeDataSet siparisOtomasyonProjeDataSet;
        private SiparisOtomasyonProjeDataSetTableAdapters.MusteriKayitBilgiTableAdapter musteriKayitBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}
