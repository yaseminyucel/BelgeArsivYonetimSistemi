using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace girisveAnasayfa
{
    public partial class FrmKullanicilar : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=172.21.54.3; Database=Grup5-2023; Uid=Grup5-2023; Pwd=NyP:974.cc");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt;

        public FrmKullanicilar()
        {
            InitializeComponent();
        }
        void kullanicilariGetir()
        {
            dt = new DataTable();
            connection.Open();
            adapter = new MySqlDataAdapter("SELECT kullanici_id AS 'Kullanıcı id', kullanici_adSoyad AS 'İsim ve Soyisim', kullanici_mail AS 'Mail Adresi', kullanici_sifre AS 'Şifre', kullanici_departman AS 'Departman', kullanici_telefonNo AS 'Telefon No' FROM kullanicilar", connection);
            adapter.Fill(dt);
            dgvKullanicilar.DataSource = dt;
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kullanicilariGetir();
        }

        private void buttnKlistele_Click(object sender, EventArgs e)
        {
            kullanicilariGetir();
        }

        private void dgvKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textKid.Text = dgvKullanicilar.CurrentRow.Cells[0].Value.ToString();
            textKad.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
            textKmail.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
            textKsifre.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
            textKdepartman.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
            textKtel.Text = dgvKullanicilar.CurrentRow.Cells[5].Value.ToString();
        }

        private void bttnKekle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO kullanicilar(kullanici_adSoyad,kullanici_mail,kullanici_sifre,kullanici_departman,kullanici_telefonNo)VALUES(@adSoyad,@mail,@sifre,@departman,@telNo)";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@adSoyad", textKad.Text);
            command.Parameters.AddWithValue("@mail", textKmail.Text);
            command.Parameters.AddWithValue("@sifre", textKsifre.Text);
            command.Parameters.AddWithValue("@departman", textKdepartman.Text);
            command.Parameters.AddWithValue("@telNo", textKtel.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kullanicilariGetir();
            MessageBox.Show("Kullanıcı Kaydedildi!");
        }

        private void bttnKsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM kullanicilar WHERE kullanici_id=@kId";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kId", textKid.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kullanicilariGetir();
            MessageBox.Show("Kullanıcı Silindi!");
        }

        private void bttnKguncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE kullanicilar SET kullanici_adSoyad=@adSoyad,kullanici_mail=@mail,kullanici_sifre=@sifre,kullanici_departman=@departman,kullanici_telefonNo=@telNo WHERE kullanici_id=@kId";
            command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@adSoyad", textKad.Text);
            command.Parameters.AddWithValue("@mail", textKmail.Text);
            command.Parameters.AddWithValue("@sifre", textKsifre.Text);
            command.Parameters.AddWithValue("@departman", textKdepartman.Text);
            command.Parameters.AddWithValue("@telNo", textKtel.Text);
            command.Parameters.AddWithValue("@kId", textKid.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            kullanicilariGetir();
            MessageBox.Show("Kullanıcı Bilgileri Güncellendi!");
        }
    }
}
