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
            LoadTarifler();
        }
        private void LoadTarifler()
        {
            Context context = new Context();
            List<(string, string, int)> tarifler = context.TumTarifleriGetir();

            foreach (var tarif in tarifler)
            {
                listBox1.Items.Add(string.Format("{0,-10} {1,5}dk      {2,-10} ", tarif.Item1, tarif.Item3, tarif.Item2));
                listBox1.Items.Add(""); // Add an empty item for spacing
            }

            listBox1.Font = new Font(listBox1.Font.FontFamily, 10);
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

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
