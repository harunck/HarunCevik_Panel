using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriErisimKatmani.Dbİslemleri;

namespace SunumKatmanı.Giris
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            KullaniciGiris k = new KullaniciGiris();

            bool sonuc = k.GirisYap(tKulAdi.Text,tSifre.Text);

            if (sonuc)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!!!!!");
            }
        }
    }
}
