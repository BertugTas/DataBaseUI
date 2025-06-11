using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBaseUI
{

    public partial class Form2 : Form
    {

        string connectionString = "Data Source=LAPTOP-DA1H5OLR\\SQLEXPRESS;Initial Catalog=Odev1;Integrated Security=True";
        DataTable urunListesi = new DataTable();
        decimal toplamTutar = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private DataTable TransposeTable(DataTable original)
        {
            DataTable transposed = new DataTable();
            transposed.Columns.Add("Özellik");

            // Her satır (ürün) için bir sütun oluştur
            for (int i = 0; i < original.Rows.Count; i++)
            {
                transposed.Columns.Add($"Ürün {i + 1}");
            }

            // Her orijinal sütunu dikey satıra çevir
            foreach (DataColumn col in original.Columns)
            {
                DataRow newRow = transposed.NewRow();
                newRow[0] = col.ColumnName;
                for (int i = 0; i < original.Rows.Count; i++)
                {
                    newRow[i + 1] = original.Rows[i][col];
                }
                transposed.Rows.Add(newRow);
            }

            return transposed;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Fatura Urunleri");
            comboBox1.Items.Add("Irsaliyeli Fatura");
            comboBox1.Items.Add("Taşıma İrsaliyesi");
            dataGridView1.AutoGenerateColumns = true;
            // Başlangıçta ilk tabloyu göstermek istersen:
            urunListesi.Columns.Add("MalCinsi");
            urunListesi.Columns.Add("Miktar", typeof(int));
            urunListesi.Columns.Add("BirimFiyat", typeof(decimal));
            urunListesi.Columns.Add("Tutar", typeof(decimal));

            dataGridView2.DataSource = TransposeTable(urunListesi);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenTablo = comboBox1.SelectedItem.ToString();

            switch (secilenTablo)
            {
                case "Fatura Urunleri":
                    VeriYukle("Fatura_Urunleri");
                    break;

                case "Irsaliyeli Fatura":
                    VeriYukle("Irsaliyeli_Fatura");
                    break;

                case "Taşıma İrsaliyesi":
                    VeriYukle("Tasima_Irsaliyesi");
                    break;
            }
        }

        private void VeriYukle(string tabloAdi)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    string sorgu = $"SELECT * FROM {tabloAdi}";
                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Test: Tablo saglikli yukleniyor mu?
                    // MessageBox.Show($"'{tabloAdi}' tablosundan {dt.Rows.Count} satır yüklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yükleme hatası: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mal = txtMalCinsi.Text;
            int miktar = (int)nudMiktar.Value;
            decimal fiyat = decimal.Parse(txtBirimFiyat.Text);
            decimal tutar = miktar * fiyat;

            urunListesi.Rows.Add(mal, miktar, fiyat, tutar);
            toplamTutar += tutar;

            dataGridView2.DataSource = TransposeTable(urunListesi);

            // temizle
            txtMalCinsi.Clear();
            txtBirimFiyat.Clear();
            nudMiktar.Value = 0;
        }

        private string GetYeniFaturaNo()
        {
            string yeniFaturaNo = "F001";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string sorgu = "SELECT TOP 1 FaturaNo FROM Irsaliyeli_Fatura ORDER BY FaturaNo DESC";

                SqlCommand cmd = new SqlCommand(sorgu, baglanti);

                try
                {
                    baglanti.Open();
                    object sonuc = cmd.ExecuteScalar();

                    if (sonuc != null)
                    {
                        string sonFaturaNo = sonuc.ToString(); // örn: "F009"
                        int sayi = int.Parse(sonFaturaNo.Substring(1));
                        sayi++; // örn: 10
                        yeniFaturaNo = "F" + sayi.ToString("D3"); // "F010"
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatura no alınırken hata: " + ex.Message);
                }
            }

            return yeniFaturaNo;
        }

        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            string seriNo = Guid.NewGuid().ToString().Substring(0, 5).ToUpper(); // veya txtFaturaSeriNo.Text;
            string satici = txtSaticiUnvan.Text;
            string alici = txtAliciUnvan.Text;
            DateTime faturaTarihi = dtpFatura.Value;
            DateTime irsaliyeTarihi = dtpIrsaliye.Value;
            string faturaNo = GetYeniFaturaNo();

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                SqlTransaction tran = baglanti.BeginTransaction();

                try
                {
                    // 1. Irsaliyeli_Fatura Ekle
                    string faturaSorgu = @"INSERT INTO Irsaliyeli_Fatura 
            (SeriNo, SaticiUnvan, AliciUnvan, FaturaTarihi, IrsaliyeTarihi, FaturaNo, ToplamTutar) 
            VALUES (@seri, @satici, @alici, @ft, @it, @fno, @toplam)";

                    SqlCommand faturaCmd = new SqlCommand(faturaSorgu, baglanti, tran);
                    faturaCmd.Parameters.AddWithValue("@seri", seriNo);
                    faturaCmd.Parameters.AddWithValue("@satici", satici);
                    faturaCmd.Parameters.AddWithValue("@alici", alici);
                    faturaCmd.Parameters.AddWithValue("@ft", faturaTarihi);
                    faturaCmd.Parameters.AddWithValue("@it", irsaliyeTarihi);
                    faturaCmd.Parameters.AddWithValue("@fno", faturaNo);
                    faturaCmd.Parameters.AddWithValue("@toplam", toplamTutar);
                    faturaCmd.ExecuteNonQuery();

                    // 2. Fatura_Urunleri Ekle — TUTAR YOK!
                    foreach (DataRow row in urunListesi.Rows)
                    {
                        string urunSorgu = @"INSERT INTO Fatura_Urunleri 
                (FaturaSeriNo, MalCinsi, Miktar, BirimFiyat) 
                VALUES (@fsn, @mal, @miktar, @fiyat)";

                        SqlCommand urunCmd = new SqlCommand(urunSorgu, baglanti, tran);
                        urunCmd.Parameters.AddWithValue("@fsn", seriNo);
                        urunCmd.Parameters.AddWithValue("@mal", row["MalCinsi"]);
                        urunCmd.Parameters.AddWithValue("@miktar", row["Miktar"]);
                        urunCmd.Parameters.AddWithValue("@fiyat", row["BirimFiyat"]);
                        urunCmd.ExecuteNonQuery();
                    }

                    // 3. Tasima_Irsaliyesi Ekle
                    string tasimaSorgu = @"INSERT INTO Tasima_Irsaliyesi 
            (SeriNo, FaturaSeriNo, TasiyiciFirma, Surucu, AracPlaka, Alici, Satici) 
            VALUES (@seri, @fsn, @firma, @surucu, @plaka, @alici, @satici)";

                    SqlCommand tasimaCmd = new SqlCommand(tasimaSorgu, baglanti, tran);
                    tasimaCmd.Parameters.AddWithValue("@seri", "T" + seriNo);
                    tasimaCmd.Parameters.AddWithValue("@fsn", seriNo);
                    tasimaCmd.Parameters.AddWithValue("@firma", txtFirma.Text);
                    tasimaCmd.Parameters.AddWithValue("@surucu", txtSurucu.Text);
                    tasimaCmd.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                    tasimaCmd.Parameters.AddWithValue("@alici", alici);
                    tasimaCmd.Parameters.AddWithValue("@satici", satici);
                    tasimaCmd.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Fatura başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
