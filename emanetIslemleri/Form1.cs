using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emanetIslemleri
{
    public partial class Form1 : Form
    {
        readonly MySqlConnection conn = new MySqlConnection("Server=172.21.54.3; Database=Grup5-2023; Uid=Grup5-2023; Pwd=NyP:974.cc;");
        
        MySqlCommand cmd;

        MySqlDataAdapter adapter;
        MySqlDataAdapter adapter2;
        DataTable dt;
        DataTable dt2;

        
        public Form1()
        {
            InitializeComponent();

        }


        void VeriGetir()
        {
            dt = new DataTable();

            conn.Open();

            adapter = new MySqlDataAdapter("SELECT *FROM emanet", conn);
            adapter.Fill(dt);
            DataGridViewEmanet.DataSource = dt;
            
            conn.Close();
            

        }

        void TxtBoxTemizle()
        {
            evrakNoTxt.Text = " ";
            evrakTuruCbox.Text = " ";
            rafTxt.Text = " ";

            emanetVerenAdTxt.Text = " ";
            emanetVerenSoyadTxt.Text = " ";
            emanetAlanAdTxt.Text = " ";
            emanetAlanSoyadTxt.Text = " ";
            emanetAlanTelTxt.Text = " ";
            aciklamaTxt.Text = " ";
        } 

        void GecmisVeriGetir()
        { 
            dt2 = new DataTable();

            conn.Open();

            adapter2 = new MySqlDataAdapter("SELECT * FROM emanetGecmisi", conn);
            adapter2.Fill(dt2);
            dgvGecmis.DataSource = dt2;

            conn.Close();

           
            
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          

            VeriGetir();
            GecmisVeriGetir();
     
            TxtBoxTemizle();

            
        }



        private void BttnKaydet_Click(object sender, EventArgs e)
        {

            //emanetleri eklemek için veritabanı sorgusu
            string sql = "INSERT INTO emanet (evrakNo, kategoriler, raf, kullaniciAd, kullaniciSoyad, emanetciAd, emanetciSoyad, iletisim, aciklama, tarih)" +
            "VALUES (@evrakNo,@kategori, @raf, @userAd,@userSoyad,@emanetciAd,@emanetciSoyad, @iletisim, @aciklama, @tarih)";




            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakNo", evrakNoTxt.Text);
            cmd.Parameters.AddWithValue("@kategori", evrakTuruCbox.Text);
            cmd.Parameters.AddWithValue("@raf", rafTxt.Text);
            cmd.Parameters.AddWithValue("@userAd", emanetVerenAdTxt.Text);
            cmd.Parameters.AddWithValue("@userSoyad", emanetVerenSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@emanetciAd", emanetAlanAdTxt.Text);
            cmd.Parameters.AddWithValue("@emanetciSoyad", emanetAlanSoyadTxt.Text);
            cmd.Parameters.AddWithValue("@iletisim", emanetAlanTelTxt.Text);
            cmd.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);




            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            VeriGetir();
            TxtBoxTemizle();

            MessageBox.Show("Emanet Kaydı Gerçekleştirildi.", "Bilgi");

            

            



        }
       

        void KayıtSil(int emanetId)
        {
            string sql3 = "DELETE FROM emanet WHERE emanetId =@emntId";
            cmd = new MySqlCommand(sql3, conn);
            cmd.Parameters.AddWithValue("@emntId", emanetId );

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        } 
        void GecmisSil (int teslimId)
        {
            string sql4 = "DELETE FROM emanetGecmisi WHERE teslimId = @teslimId";
            cmd = new MySqlCommand(sql4, conn);
            cmd.Parameters.AddWithValue("@teslimId", teslimId);

            conn.Open();   
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        


        private void BttnEmanetSil_Click(object sender, EventArgs e)
        {

           

            {
                foreach (DataGridViewRow drow in DataGridViewEmanet.SelectedRows)  //Seçili satırları 
                {

                    int emanetId = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(emanetId);
                    MessageBox.Show("Kayıt Silindi.");
                }
                VeriGetir();
            }

            TxtBoxTemizle();
           

        }

        private void DataGridViewEmanet_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            try //datagridview dakileri textbox vs. ye aktarmak (emanet geçmiş sayfasındaki datagridview a çekmek amacıyla)
            {
                TxtEmanetId.Text = DataGridViewEmanet.CurrentRow.Cells[0].Value.ToString();
                evrakNoTxt.Text = DataGridViewEmanet.CurrentRow.Cells[1].Value.ToString();
                evrakTuruCbox.Text = DataGridViewEmanet.CurrentRow.Cells[2].Value.ToString();
                rafTxt.Text = DataGridViewEmanet.CurrentRow.Cells[3].Value.ToString();
                emanetVerenAdTxt.Text = DataGridViewEmanet.CurrentRow.Cells[4].Value.ToString();
                emanetVerenSoyadTxt.Text = DataGridViewEmanet.CurrentRow.Cells[5].Value.ToString();
                emanetAlanAdTxt.Text = DataGridViewEmanet.CurrentRow.Cells[6].Value.ToString();
                emanetAlanSoyadTxt.Text = DataGridViewEmanet.CurrentRow.Cells[7].Value.ToString();
                emanetAlanTelTxt.Text = DataGridViewEmanet.CurrentRow.Cells[8].Value.ToString();
                aciklamaTxt.Text = DataGridViewEmanet.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {

            }



        }
        private void BttnTeslimAl_Click(object sender, EventArgs e)
        {
            try //datagridview dakileri textbox vs. ye aktarmak (emanet geçmiş sayfasındaki datagridview a çekmek amacıyla)
            {
                TxtEmanetId.Text = DataGridViewEmanet.CurrentRow.Cells[0].Value.ToString();
                evrakNoTxt.Text = DataGridViewEmanet.CurrentRow.Cells[1].Value.ToString();
                evrakTuruCbox.Text = DataGridViewEmanet.CurrentRow.Cells[2].Value.ToString();
                rafTxt.Text = DataGridViewEmanet.CurrentRow.Cells[3].Value.ToString();
                emanetVerenAdTxt.Text = DataGridViewEmanet.CurrentRow.Cells[4].Value.ToString();
                emanetVerenSoyadTxt.Text = DataGridViewEmanet.CurrentRow.Cells[5].Value.ToString();
                emanetAlanAdTxt.Text = DataGridViewEmanet.CurrentRow.Cells[6].Value.ToString();
                emanetAlanSoyadTxt.Text = DataGridViewEmanet.CurrentRow.Cells[7].Value.ToString();
                emanetAlanTelTxt.Text = DataGridViewEmanet.CurrentRow.Cells[8].Value.ToString();
                aciklamaTxt.Text = DataGridViewEmanet.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {

            }
            

            try
            {
                
                string sql2 = "INSERT INTO emanetGecmisi (evrakNo, kategoriler, raf, kullaniciAd, kullaniciSoyad, emanetciAd, emanetciSoyad, iletisim, aciklama, teslimTarihi)" +
          "VALUES (@evrakNo,@kategori, @raf, @userAd,@userSoyad,@emanetciAd,@emanetciSoyad, @iletisim, @aciklama, @teslimTarihi)";




                cmd = new MySqlCommand(sql2, conn);
               
                cmd.Parameters.AddWithValue("@evrakNo", evrakNoTxt.Text);
                cmd.Parameters.AddWithValue("@kategori", evrakTuruCbox.Text);
                cmd.Parameters.AddWithValue("@raf", rafTxt.Text);
                cmd.Parameters.AddWithValue("@userAd", emanetVerenAdTxt.Text);
                cmd.Parameters.AddWithValue("@userSoyad", emanetVerenSoyadTxt.Text);
                cmd.Parameters.AddWithValue("@emanetciAd", emanetAlanAdTxt.Text);
                cmd.Parameters.AddWithValue("@emanetciSoyad", emanetAlanSoyadTxt.Text);
                cmd.Parameters.AddWithValue("@iletisim", emanetAlanTelTxt.Text);
                cmd.Parameters.AddWithValue("@aciklama", aciklamaTxt.Text);

                cmd.Parameters.AddWithValue("@teslimTarihi", DateTime.Now);



                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();


                foreach (DataGridViewRow drow in DataGridViewEmanet.SelectedRows)  //Seçili satırları 
                {

                    int emanetId = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(emanetId);
                    MessageBox.Show("Emanet Teslim Alındı.");
                }
                VeriGetir();
                GecmisVeriGetir();
                TxtBoxTemizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }

            //
           
        }

        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt2.DefaultView;
            dv.RowFilter = "evrakNo LIKE '" + TxtAra.Text + "%'";
            dgvGecmis.DataSource = dv;
        }
        
        public System.Windows.Forms.DataGridViewSelectionMode SelectionMode { get; set; }
        private void bttnGecmisSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgvGecmis.SelectedRows)  //Seçili satırları 
            {

                int teslimId = Convert.ToInt32(drow.Cells[0].Value);
                GecmisSil(teslimId);
                MessageBox.Show("Emanet Geçmişi Silindi.");
            }
            GecmisVeriGetir();
        }
    }




       
}



