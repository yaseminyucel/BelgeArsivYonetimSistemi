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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        MySqlConnection connection  = new MySqlConnection("Server=172.21.54.3; Database=Grup5-2023; Uid=Grup5-2023; Pwd=NyP:974.cc");

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            if (rbttnfakulteS.Checked)
            {
                fr.bttnKsayfasi.Visible = true;
            }
            
            
            
                connection.Open();
                string sql = "SELECT * FROM kullanicilar WHERE kullanici_mail=@kmail AND kullanici_sifre=@ksifre";
                MySqlParameter params1 = new MySqlParameter("kmail", textGirisMail.Text);
                MySqlParameter params2 = new MySqlParameter("ksifre", textGirisSifre.Text);
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.Add(params1);
                command.Parameters.Add(params2);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                                 
                    fr.Show();
                    
                }
                else
                {

                MessageBox.Show("Hatalı Giriş");
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
