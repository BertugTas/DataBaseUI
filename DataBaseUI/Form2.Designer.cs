namespace DataBaseUI
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciUnvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırsaliyeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırsaliyeliFaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odev1DataSet = new DataBaseUI.Odev1DataSet();
            this.faturaUrunleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fatura_UrunleriTableAdapter = new DataBaseUI.Odev1DataSetTableAdapters.Fatura_UrunleriTableAdapter();
            this.irsaliyeli_FaturaTableAdapter = new DataBaseUI.Odev1DataSetTableAdapters.Irsaliyeli_FaturaTableAdapter();
            this.tasimaIrsaliyesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasima_IrsaliyesiTableAdapter = new DataBaseUI.Odev1DataSetTableAdapters.Tasima_IrsaliyesiTableAdapter();
            this.txtSaticiUnvan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAliciUnvan = new System.Windows.Forms.TextBox();
            this.dtpFatura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIrsaliye = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMalCinsi = new System.Windows.Forms.TextBox();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.sofor = new System.Windows.Forms.Label();
            this.txtSurucu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ırsaliyeliFaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaUrunleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasimaIrsaliyesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(573, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tablo seçim menüsü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seriNoDataGridViewTextBoxColumn,
            this.saticiUnvanDataGridViewTextBoxColumn,
            this.aliciUnvanDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.ırsaliyeTarihiDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ırsaliyeliFaturaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 194);
            this.dataGridView1.TabIndex = 4;
            // 
            // seriNoDataGridViewTextBoxColumn
            // 
            this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.HeaderText = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
            this.seriNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // saticiUnvanDataGridViewTextBoxColumn
            // 
            this.saticiUnvanDataGridViewTextBoxColumn.DataPropertyName = "SaticiUnvan";
            this.saticiUnvanDataGridViewTextBoxColumn.HeaderText = "SaticiUnvan";
            this.saticiUnvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saticiUnvanDataGridViewTextBoxColumn.Name = "saticiUnvanDataGridViewTextBoxColumn";
            this.saticiUnvanDataGridViewTextBoxColumn.Width = 125;
            // 
            // aliciUnvanDataGridViewTextBoxColumn
            // 
            this.aliciUnvanDataGridViewTextBoxColumn.DataPropertyName = "AliciUnvan";
            this.aliciUnvanDataGridViewTextBoxColumn.HeaderText = "AliciUnvan";
            this.aliciUnvanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aliciUnvanDataGridViewTextBoxColumn.Name = "aliciUnvanDataGridViewTextBoxColumn";
            this.aliciUnvanDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            this.faturaTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ırsaliyeTarihiDataGridViewTextBoxColumn
            // 
            this.ırsaliyeTarihiDataGridViewTextBoxColumn.DataPropertyName = "IrsaliyeTarihi";
            this.ırsaliyeTarihiDataGridViewTextBoxColumn.HeaderText = "IrsaliyeTarihi";
            this.ırsaliyeTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ırsaliyeTarihiDataGridViewTextBoxColumn.Name = "ırsaliyeTarihiDataGridViewTextBoxColumn";
            this.ırsaliyeTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            this.faturaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // ırsaliyeliFaturaBindingSource
            // 
            this.ırsaliyeliFaturaBindingSource.DataMember = "Irsaliyeli_Fatura";
            this.ırsaliyeliFaturaBindingSource.DataSource = this.odev1DataSet;
            // 
            // odev1DataSet
            // 
            this.odev1DataSet.DataSetName = "Odev1DataSet";
            this.odev1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faturaUrunleriBindingSource
            // 
            this.faturaUrunleriBindingSource.DataMember = "Fatura_Urunleri";
            this.faturaUrunleriBindingSource.DataSource = this.odev1DataSet;
            // 
            // fatura_UrunleriTableAdapter
            // 
            this.fatura_UrunleriTableAdapter.ClearBeforeFill = true;
            // 
            // irsaliyeli_FaturaTableAdapter
            // 
            this.irsaliyeli_FaturaTableAdapter.ClearBeforeFill = true;
            // 
            // tasimaIrsaliyesiBindingSource
            // 
            this.tasimaIrsaliyesiBindingSource.DataMember = "Tasima_Irsaliyesi";
            this.tasimaIrsaliyesiBindingSource.DataSource = this.odev1DataSet;
            // 
            // tasima_IrsaliyesiTableAdapter
            // 
            this.tasima_IrsaliyesiTableAdapter.ClearBeforeFill = true;
            // 
            // txtSaticiUnvan
            // 
            this.txtSaticiUnvan.Location = new System.Drawing.Point(12, 236);
            this.txtSaticiUnvan.Name = "txtSaticiUnvan";
            this.txtSaticiUnvan.Size = new System.Drawing.Size(188, 22);
            this.txtSaticiUnvan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Satıcı Ünvanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alıcı Ünvan";
            // 
            // txtAliciUnvan
            // 
            this.txtAliciUnvan.Location = new System.Drawing.Point(12, 298);
            this.txtAliciUnvan.Name = "txtAliciUnvan";
            this.txtAliciUnvan.Size = new System.Drawing.Size(188, 22);
            this.txtAliciUnvan.TabIndex = 7;
            // 
            // dtpFatura
            // 
            this.dtpFatura.Location = new System.Drawing.Point(247, 236);
            this.dtpFatura.Name = "dtpFatura";
            this.dtpFatura.Size = new System.Drawing.Size(200, 22);
            this.dtpFatura.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fatura Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Irsaliye Tarihi";
            // 
            // dtpIrsaliye
            // 
            this.dtpIrsaliye.Location = new System.Drawing.Point(247, 298);
            this.dtpIrsaliye.Name = "dtpIrsaliye";
            this.dtpIrsaliye.Size = new System.Drawing.Size(200, 22);
            this.dtpIrsaliye.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(7, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fatura Ürünleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mal Cinsi";
            // 
            // txtMalCinsi
            // 
            this.txtMalCinsi.Location = new System.Drawing.Point(15, 393);
            this.txtMalCinsi.Name = "txtMalCinsi";
            this.txtMalCinsi.Size = new System.Drawing.Size(188, 22);
            this.txtMalCinsi.TabIndex = 14;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(247, 429);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(84, 22);
            this.nudMiktar.TabIndex = 16;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(247, 392);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(188, 22);
            this.txtBirimFiyat.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Mal Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Toplam Fiyat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(7, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Taşıma Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Taşıyıcı Firma";
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(12, 515);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(188, 22);
            this.txtFirma.TabIndex = 22;
            // 
            // sofor
            // 
            this.sofor.AutoSize = true;
            this.sofor.Location = new System.Drawing.Point(249, 496);
            this.sofor.Name = "sofor";
            this.sofor.Size = new System.Drawing.Size(39, 16);
            this.sofor.TabIndex = 25;
            this.sofor.Text = "Şoför";
            // 
            // txtSurucu
            // 
            this.txtSurucu.Location = new System.Drawing.Point(247, 515);
            this.txtSurucu.Name = "txtSurucu";
            this.txtSurucu.Size = new System.Drawing.Size(188, 22);
            this.txtSurucu.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Araç Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(15, 578);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(188, 22);
            this.txtPlaka.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Birim Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fatura No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(584, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Fatura Ürünleri:";
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.Location = new System.Drawing.Point(247, 578);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(188, 23);
            this.btnFaturaKaydet.TabIndex = 30;
            this.btnFaturaKaydet.Text = "Faturayı Ekle";
            this.btnFaturaKaydet.UseVisualStyleBackColor = true;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(521, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(267, 303);
            this.dataGridView2.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 657);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.sofor);
            this.Controls.Add(this.txtSurucu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMalCinsi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpIrsaliye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAliciUnvan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaticiUnvan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ırsaliyeliFaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odev1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaUrunleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasimaIrsaliyesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Odev1DataSet odev1DataSet;
        private System.Windows.Forms.BindingSource faturaUrunleriBindingSource;
        private Odev1DataSetTableAdapters.Fatura_UrunleriTableAdapter fatura_UrunleriTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ırsaliyeliFaturaBindingSource;
        private Odev1DataSetTableAdapters.Irsaliyeli_FaturaTableAdapter irsaliyeli_FaturaTableAdapter;
        private System.Windows.Forms.BindingSource tasimaIrsaliyesiBindingSource;
        private Odev1DataSetTableAdapters.Tasima_IrsaliyesiTableAdapter tasima_IrsaliyesiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciUnvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ırsaliyeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSaticiUnvan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAliciUnvan;
        private System.Windows.Forms.DateTimePicker dtpFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIrsaliye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMalCinsi;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label sofor;
        private System.Windows.Forms.TextBox txtSurucu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}