namespace BetaMart
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDitambahkanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new BetaMart.Database1DataSet1();
            this.dataBarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new BetaMart.Database1DataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tanggal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_kode_barang = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBarangTableAdapter = new BetaMart.Database1DataSet1TableAdapters.DataBarangTableAdapter();
            this.dataBarangTableAdapter1 = new BetaMart.Database1DataSetTableAdapters.DataBarangTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 159);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.tanggalDitambahkanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 132);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // tanggalDitambahkanDataGridViewTextBoxColumn
            // 
            this.tanggalDitambahkanDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Ditambahkan";
            this.tanggalDitambahkanDataGridViewTextBoxColumn.HeaderText = "Tanggal_Ditambahkan";
            this.tanggalDitambahkanDataGridViewTextBoxColumn.Name = "tanggalDitambahkanDataGridViewTextBoxColumn";
            // 
            // dataBarangBindingSource
            // 
            this.dataBarangBindingSource.DataMember = "DataBarang";
            this.dataBarangBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBarangBindingSource1
            // 
            this.dataBarangBindingSource1.DataMember = "DataBarang";
            this.dataBarangBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.panelData);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_hapus);
            this.panel1.Controls.Add(this.btn_tambah);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 285);
            this.panel1.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_refresh.Location = new System.Drawing.Point(279, 243);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(65, 28);
            this.btn_refresh.TabIndex = 58;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelData.Controls.Add(this.txt_id);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.txt_tanggal);
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.txt_kode_barang);
            this.panelData.Controls.Add(this.txt_stok);
            this.panelData.Controls.Add(this.txt_harga);
            this.panelData.Controls.Add(this.txt_nama);
            this.panelData.Location = new System.Drawing.Point(12, 69);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(760, 164);
            this.panelData.TabIndex = 57;
            this.panelData.Paint += new System.Windows.Forms.PaintEventHandler(this.panelData_Paint);
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "ID", true));
            this.txt_id.Location = new System.Drawing.Point(590, 46);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 20);
            this.txt_id.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(553, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "ID";
            // 
            // txt_tanggal
            // 
            this.txt_tanggal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Tanggal_Ditambahkan", true));
            this.txt_tanggal.Location = new System.Drawing.Point(175, 124);
            this.txt_tanggal.Name = "txt_tanggal";
            this.txt_tanggal.Size = new System.Drawing.Size(546, 20);
            this.txt_tanggal.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(33, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tanggal Ditambahkan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(33, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(33, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Harga Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kode Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(33, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nama";
            // 
            // txt_kode_barang
            // 
            this.txt_kode_barang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Kode_Barang", true));
            this.txt_kode_barang.Location = new System.Drawing.Point(175, 46);
            this.txt_kode_barang.Name = "txt_kode_barang";
            this.txt_kode_barang.Size = new System.Drawing.Size(356, 20);
            this.txt_kode_barang.TabIndex = 27;
            // 
            // txt_stok
            // 
            this.txt_stok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Stok", true));
            this.txt_stok.Location = new System.Drawing.Point(175, 98);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(547, 20);
            this.txt_stok.TabIndex = 26;
            // 
            // txt_harga
            // 
            this.txt_harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Harga", true));
            this.txt_harga.Location = new System.Drawing.Point(175, 72);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(547, 20);
            this.txt_harga.TabIndex = 25;
            // 
            // txt_nama
            // 
            this.txt_nama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataBarangBindingSource, "Nama", true));
            this.txt_nama.Location = new System.Drawing.Point(175, 20);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(547, 20);
            this.txt_nama.TabIndex = 24;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_edit.Location = new System.Drawing.Point(516, 239);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 37);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_hapus.Location = new System.Drawing.Point(647, 239);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(125, 37);
            this.btn_hapus.TabIndex = 3;
            this.btn_hapus.Text = "Delete";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_tambah.Location = new System.Drawing.Point(385, 239);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(125, 37);
            this.btn_tambah.TabIndex = 2;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(82, 248);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(191, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beta Mart";
            // 
            // dataBarangTableAdapter
            // 
            this.dataBarangTableAdapter.ClearBeforeFill = true;
            // 
            // dataBarangTableAdapter1
            // 
            this.dataBarangTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource dataBarangBindingSource;
        private Database1DataSet1TableAdapters.DataBarangTableAdapter dataBarangTableAdapter;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DateTimePicker txt_tanggal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_kode_barang;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_nama;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource dataBarangBindingSource1;
        private Database1DataSetTableAdapters.DataBarangTableAdapter dataBarangTableAdapter1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDitambahkanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_refresh;
    }
}