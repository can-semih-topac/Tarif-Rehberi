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
    public partial class TarifGüncelleForm : Form
    {
        private List<string> malzemeler;
        private List<decimal> secilenMalzemeMiktarlari;
        public TarifGüncelleForm()
        {
            InitializeComponent();
            LoadKategoriler();
            LoadMalzemeler();
        }
        private void LoadKategoriler()
        {
            Context context = new Context();
            List<string> kategoriler = context.TumKategorileriGetir();

            kategoriComboBox.Items.AddRange(kategoriler.ToArray());
        }
        private void LoadMalzemeler()
        {
            Context context = new Context();
            List<string> malzemeler = context.TumMalzemeleriGetir();

            malzemeEkleComboBox.Items.AddRange(malzemeler.ToArray());
        }
        private void tarifAdiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TarifGüncelleForm_Load(object sender, EventArgs e)
        {

        }

        private void yeniMalzemeEkleButonu_Click(object sender, EventArgs e)
        {
            YeniMalzemeEkle yeniMalzemeEkleForm = new YeniMalzemeEkle();
            yeniMalzemeEkleForm.Show();
        }

        private void yeniKategoriEkleButonu_Click(object sender, EventArgs e)
        {
            YeniKategoriEkle yeniKategoriEkleForm = new YeniKategoriEkle();
            yeniKategoriEkleForm.Show();
        }

        private void hazirlanmaSuresiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Context context = new Context();
            List<string> kategoriler = context.TumKategorileriGetir();

            foreach (string kategori in kategoriler)
            {
                kategoriComboBox.Items.Add(kategori);
            }

        }
        private void malzemeEkleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Context context = new Context();
            List<string> malzemeler = context.TumMalzemeleriGetir();

            foreach (string malzeme in malzemeler)
            {
                malzemeEkleComboBox.Items.Add(malzeme);
            }

        }
        private void talimatlarBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void malzemeEkleButonu_Click(object sender, EventArgs e)
        {

        }
        private void malzemeMiktariBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void tarifitamamlabutonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            string tarifAdi = tarifAdiBox.Text;
            int hazirlanmaSuresi;
            int.TryParse(hazirlanmaSuresiBox.Text, out hazirlanmaSuresi);
            string secilenKategori = kategoriComboBox.SelectedItem.ToString();
            string secilenMalzeme = malzemeEkleComboBox.SelectedItem.ToString();
            decimal malzemeMiktari;
            decimal.TryParse(malzemeMiktariBox.Text, out malzemeMiktari);
            string talimatlar = talimatlarBox.Text;
            Context context = new Context();
            context.YeniTarifEkle(tarifAdi, secilenKategori, hazirlanmaSuresi, talimatlar);

            this.Close();
        }


    }
}

