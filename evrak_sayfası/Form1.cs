using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace belge_arşiv_yönetim_sistemi

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void filtreleme_TextChanged(object sender, EventArgs e)
        {
            // Filtreleme işlemlerini gerçekleştir
            string selectedFilter = Filtre.SelectedItem.ToString();
            string filterValue = Filtreleme.Text;

            FilterData(selectedFilter, filterValue);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Kategoriler";
            dataGridView1.Columns[1].Name = "Evrak Numarasi";
            dataGridView1.Columns[2].Name = "Bulundugu Raf";
            dataGridView1.Columns[3].Name = "Kayıt Eden Kisi";
            dataGridView1.Columns[4].Name = "Aciklama";
            dataGridView1.Columns[5].Name = "Tarih";
            dataGridView1.Columns[6].Name = "Saat";

            Filtre.Items.AddRange(new string[] { "Yıla Göre", "Aya Göre", "Kategoriye Göre", "Bulunduğu Rafa Göre", "Kayıt Eden Kişiye Göre" });
            Filtre.SelectedIndex = 0;
        }


        MySqlConnection connection = new MySqlConnection("Server=172.21.54.3; Database=Grup5-2023; Uid=Grup5-2023; Pwd=NyP:974.cc;");


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // DataGridView'e veriyi ekleme
            int rowIndex = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowIndex].Cells["Kategoriler"].Value = kategori.Text;
            dataGridView1.Rows[rowIndex].Cells["Evrak Numarasi"].Value = evrakNo.Text;
            dataGridView1.Rows[rowIndex].Cells["Bulundugu Raf"].Value = evrakRaf.Text;
            dataGridView1.Rows[rowIndex].Cells["Kayıt Eden Kisi"].Value = kayitEden.Text;
            dataGridView1.Rows[rowIndex].Cells["Aciklama"].Value = aciklama.Text;
            dataGridView1.Rows[rowIndex].Cells["Tarih"].Value = DateTime.Now.ToString("yyyy-MMMM-dd");
            dataGridView1.Rows[rowIndex].Cells["Saat"].Value = DateTime.Now.ToString("HH:mm:ss");

            // DataGridView'i güncelledikten sonra veritabanına bağlantıyı açma
            connection.Open();

            // Verileri ekleme sorgusu
            string query = "INSERT INTO evraklar (Kategoriler, `Evrak Numarası`, `Bulunduğu Raf`, `Kayıt Eden Kişi`, Acıklama, Tarih, Saat) VALUES (@Kategoriler, @EvrakNumarasi, @BulunduguRaf, @KayitEdenKisi, @Aciklama, @Tarih, @Saat)";

            // Sorguyu yürütmek için bir MySqlCommand nesnesi oluşturma
            MySqlCommand command = new MySqlCommand(query, connection);

            // Parametrelerin değerlerini belirleme
            command.Parameters.Add("@Kategoriler", MySqlDbType.VarChar).Value = kategori.Text;
            command.Parameters.Add("@EvrakNumarasi", MySqlDbType.VarChar).Value = evrakNo.Text;
            command.Parameters.Add("@BulunduguRaf", MySqlDbType.VarChar).Value = evrakRaf.Text;
            command.Parameters.Add("@KayitEdenKisi", MySqlDbType.VarChar).Value = kayitEden.Text;
            command.Parameters.Add("@Aciklama", MySqlDbType.VarChar).Value = aciklama.Text;
            command.Parameters.Add("@Tarih", MySqlDbType.Datetime).Value = DateTime.Now;
            command.Parameters.Add("@Saat", MySqlDbType.Datetime).Value = DateTime.Now;

            // Komutu yürütme
            command.ExecuteNonQuery();

            // Veritabanı bağlantısını kapatma
            connection.Close();

            // Gerekli diğer işlemleri gerçekleştirme
            kategori.SelectedIndex = -1;
            kategori.Text = "";
            evrakNo.Clear();
            evrakRaf.Clear();
            kayitEden.Clear();
            aciklama.Clear();
            kategori.Focus();
        }


        private void verileriGoster_Click(object sender, EventArgs e)
        {

            connection.Open();

            // Verileri seçme sorgusu
            string query = "SELECT * FROM evraklar";

            // Sorguyu yürütmek için bir MySqlCommand nesnesi oluşturma
            MySqlCommand command = new MySqlCommand(query, connection);

            // Verileri almak için bir MySqlDataReader nesnesi oluşturma
            MySqlDataReader reader = command.ExecuteReader();

            // DataGridView'i temizleme
            //dataGridView1.Rows.Clear();

            // Verileri DataGridView'e ekleme
            while (reader.Read())
            {
                string kategoriler = reader.GetString("Kategoriler");
                string evrakNumarasi = reader.GetString("Evrak Numarasi");
                string bulunduguRaf = reader.GetString("Bulundugu Raf");
                string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                string aciklama = reader.GetString("Aciklama");
                DateTime tarih = reader.GetDateTime("Tarih");
                DateTime saat = reader.GetDateTime("Saat");

                dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
            }

            // Veritabanı bağlantısını kapatma
            connection.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // Veritabanına bağlantıyı açma
            connection.Open();

            // Arama sorgusu
            string query = "SELECT * FROM evraklar WHERE `Evrak Numarası` LIKE @EvrakNumarasi";

            // Sorguyu yürütmek için bir MySqlCommand nesnesi oluşturma
            MySqlCommand command = new MySqlCommand(query, connection);

            // Parametreyi belirleme
            command.Parameters.AddWithValue("@evrakNumarasi", "%" + evrakAra.Text + "%");

            // Verileri almak için bir MySqlDataReader nesnesi oluşturma
            MySqlDataReader reader = command.ExecuteReader();

            // DataGridView'i temizleme
            dataGridView1.Rows.Clear();

            // Verileri DataGridView'e ekleme
            while (reader.Read())
            {
                string kategoriler = reader.GetString("Kategoriler");
                string evrakNumarasi = reader.GetString("Evrak Numarasi");
                string bulunduguRaf = reader.GetString("Bulundugu Raf");
                string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                string aciklama = reader.GetString("Aciklama");
                DateTime tarih = reader.GetDateTime("Tarih");
                DateTime saat = reader.GetDateTime("Saat");

                dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
            }

            // Veritabanı bağlantısını kapatma
            connection.Close();

        }
        private void Filtre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'ın seçili öğesine göre filtreleme işlemini gerçekleştir
            string selectedFilter = Filtre.SelectedItem.ToString();
            string filterValue = Filtreleme.Text;

            FilterData(selectedFilter, filterValue);
        }



        private void textBoxFiltreleme_TextChanged(object sender, EventArgs e)
        {

            // TextBox'a her yazıldığında filtreleme işlemini gerçekleştir
            string selectedFilter = Filtre.SelectedItem.ToString();
            string filterValue = Filtreleme.Text;

            FilterData(selectedFilter, filterValue);
        }





        private void FilterData(string selectedFilter, string filterValue)
        {
            if (selectedFilter == "Yıla Göre")
            {
                connection.Open();
                string query = "SELECT * FROM evraklar WHERE YEAR(Tarih) = @FilterValue";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterValue", filterValue);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string kategoriler = reader.GetString("Kategoriler");
                    string evrakNumarasi = reader.GetString("Evrak Numarasi");
                    string bulunduguRaf = reader.GetString("Bulundugu Raf");
                    string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                    string aciklama = reader.GetString("Aciklama");
                    DateTime tarih = reader.GetDateTime("Tarih");
                    DateTime saat = reader.GetDateTime("Saat");

                    dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
                }

                connection.Close();
            }
            else if (selectedFilter == "Aya Göre")
            {
                connection.Open();
                string query = "SELECT * FROM evraklar WHERE Month(Tarih) = @FilterValue";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterValue", filterValue);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string kategoriler = reader.GetString("Kategoriler");
                    string evrakNumarasi = reader.GetString("Evrak Numarasi");
                    string bulunduguRaf = reader.GetString("Bulundugu Raf");
                    string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                    string aciklama = reader.GetString("Aciklama");
                    DateTime tarih = reader.GetDateTime("Tarih");
                    DateTime saat = reader.GetDateTime("Saat");

                    dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
                }

                connection.Close();
            }
            else if (selectedFilter == "Kategoriye Göre")
            {
                connection.Open();
                string query = "SELECT * FROM evraklar WHERE Kategoriler = @FilterValue";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterValue", filterValue);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string kategoriler = reader.GetString("Kategoriler");
                    string evrakNumarasi = reader.GetString("Evrak Numarasi");
                    string bulunduguRaf = reader.GetString("Bulundugu Raf");
                    string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                    string aciklama = reader.GetString("Aciklama");
                    DateTime tarih = reader.GetDateTime("Tarih");
                    DateTime saat = reader.GetDateTime("Saat");

                    dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
                }

                connection.Close();
            }
            else if (selectedFilter == "Bulunduğu Rafa Göre")
            {
                connection.Open();
                string query = "SELECT * FROM evraklar WHERE `Bulundugu Raf` = @FilterValue";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterValue", filterValue);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string kategoriler = reader.GetString("Kategoriler");
                    string evrakNumarasi = reader.GetString("Evrak Numarasi");
                    string bulunduguRaf = reader.GetString("Bulundugu Raf");
                    string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                    string aciklama = reader.GetString("Aciklama");
                    DateTime tarih = reader.GetDateTime("Tarih");
                    DateTime saat = reader.GetDateTime("Saat");

                    dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
                }

                connection.Close();
            }
            else if (selectedFilter == "Kayıt Eden Kişiye Göre")
            {
                connection.Open();
                string query = "SELECT * FROM evraklar WHERE `Kayit Eden Kisi` = @FilterValue";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FilterValue", filterValue);
                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    string kategoriler = reader.GetString("Kategoriler");
                    string evrakNumarasi = reader.GetString("Evrak Numarasi");
                    string bulunduguRaf = reader.GetString("Bulundugu Raf");
                    string kayitEdenKisi = reader.GetString("Kayit Eden Kisi");
                    string aciklama = reader.GetString("Aciklama");
                    DateTime tarih = reader.GetDateTime("Tarih");
                    DateTime saat = reader.GetDateTime("Saat");

                    dataGridView1.Rows.Add(kategoriler, evrakNumarasi, bulunduguRaf, kayitEdenKisi, aciklama, tarih, saat);
                }
                connection.Close();
            }

        }

    }
}
       