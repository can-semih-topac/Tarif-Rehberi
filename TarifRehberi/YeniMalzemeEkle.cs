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

namespace TarifRehberi
{
    public partial class YeniMalzemeEkle : Form
    {
        public YeniMalzemeEkle()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void malzemeAdıBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void malzemeBirimiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birimFiyatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depodakiMiktarBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void yeniMalzemeEkleButonu_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri değişkenlere atama
            string malzemeAdi = malzemeAdıBox.Text;
            string malzemeBirimi = malzemeBirimiBox.Text;
            decimal birimFiyat;
            decimal.TryParse(birimFiyatBox.Text, out birimFiyat);
            decimal toplamMiktar;
            decimal.TryParse(depodakiMiktarBox.Text, out toplamMiktar);
            


             Context context = new Context();
            context.YeniMalzemeEkle(malzemeAdi, malzemeBirimi, birimFiyat, toplamMiktar);

            // Formu kapatma
            this.Close();
        }

        private void YeniMalzemeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
