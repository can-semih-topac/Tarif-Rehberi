using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarifRehberi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tarifeklebutonu_Click(object sender, EventArgs e)
        {
            TarifEkleForm tarifEkleForm = new TarifEkleForm();
            tarifEkleForm.Show();
        }


        private void tarifguncellebutonu_Click(object sender, EventArgs e)
        {
            TarifGüncelleForm tarifGuncelleForm = new TarifGüncelleForm();
            tarifGuncelleForm.Show();
        }

        private void tarifsilbutonu_Click(object sender, EventArgs e)
        {
            TarifSil tarifSilForm = new TarifSil();
            tarifSilForm.Show();
        }

        private void oneriAlButonu_Click(object sender, EventArgs e)
        {
            EkleTulumbaTarifi();
            OneriAl oneriAlForm = new OneriAl();
            oneriAlForm.Show();
        }

        private void tarifAraButonu_Click(object sender, EventArgs e)
        {
            TarifAra tarifAraForm = new TarifAra();
            tarifAraForm.Show();
        }
        public void EkleTulumbaTarifi()
        {
            Context context = new Context();
            string tarifAdi = "tulumba";
            string kategoriAdi = "tatlılar";
            int  hazirlanmaSuresi = 20;
            string talimatlar = "bu bir denemedir";
            string secilenMalzeme = "un"; // Örnek malzeme adı
            decimal malzemeMiktari = 500; // Örnek malzeme miktarı

            // context.YeniTarifEkle(tarifAdi, kategoriAdi, hazirlanmaSuresi, talimatlar, secilenMalzeme, malzemeMiktari, malzemeler);
        }
    }
}
