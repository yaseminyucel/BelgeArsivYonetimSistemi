using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisveAnasayfa
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void bttnKsayfasi_Click(object sender, EventArgs e)
        {
            FrmKullanicilar fr = new FrmKullanicilar();
            fr.Show();
        }
    }
}
