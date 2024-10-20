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
        public TarifGüncelleForm(List<(string, string, int)> selectedTarif)
        {
            string secilenTarifAdi = selectedTarif[0].Item1;
            malzemeler = new List<string>();
            secilenMalzemeMiktarlari = new List<decimal>();
            InitializeComponent();
            LoadKategoriler();
            LoadMalzemeler();
            LoadTarifBilgileri(secilenTarifAdi);
            // LoadTarifBilgileri();
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
        private void LoadTarifBilgileri(string secilenTarifAdi)
        {
            // MessageBox.Show("Load tarif bilgilerine girdi");
            Context context = new Context();
            (string, string, int, string) tarifBilgileri = context.TarifBilgileriGetir(secilenTarifAdi);

            tarifAdiBox.Text = tarifBilgileri.Item1;
            kategoriComboBox.SelectedItem = tarifBilgileri.Item2;
            hazirlanmaSuresiBox.Text = tarifBilgileri.Item3.ToString();
            talimatlarBox.Text = tarifBilgileri.Item4;
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
            string secilenMalzeme = malzemeEkleComboBox.SelectedItem != null ? malzemeEkleComboBox.SelectedItem.ToString() : string.Empty;
            Context context = new Context();
            string birim = context.MalzemeBirimGetir(secilenMalzeme);

            if (!string.IsNullOrEmpty(birim))
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(birim);
            }

        }
        private void talimatlarBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void malzemeEkleButonu_Click(object sender, EventArgs e)
        {
            string secilenMalzeme = malzemeEkleComboBox.SelectedItem != null ? malzemeEkleComboBox.SelectedItem.ToString() : string.Empty;
            decimal malzemeMiktari;
            decimal.TryParse(malzemeMiktariBox.Text, out malzemeMiktari);

            malzemeler.Add(secilenMalzeme);
            secilenMalzemeMiktarlari.Add(malzemeMiktari);
            Context context = new Context();
            string birim = context.MalzemeBirimGetir(secilenMalzeme);
            malzemeEkleComboBox.SelectedItem = null;
            malzemeMiktariBox.Text = string.Empty;
            listBox1.Items.Clear(); // ListBox'ı temizle
            listBox2.Items.Clear();
            for (int i = 0; i < malzemeler.Count; i++)
            {
                string malzeme = malzemeler[i] + " - " + secilenMalzemeMiktarlari[i] + " " + birim;
                listBox1.Items.Add(malzeme); // Malzemeler listesindeki her bir malzemeyi ListBox'a ekle
            }

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
            string secilenMalzeme = malzemeEkleComboBox.SelectedItem != null ? malzemeEkleComboBox.SelectedItem.ToString() : string.Empty;
            decimal malzemeMiktari;
            decimal.TryParse(malzemeMiktariBox.Text, out malzemeMiktari);
            string talimatlar = talimatlarBox.Text;
            Context context = new Context();
            context.YeniTarifEkle(tarifAdi, secilenKategori, hazirlanmaSuresi, talimatlar);
            Context context1 = new Context();
            context1.EkleTarifMalzemeIliskisi(tarifAdi, malzemeler, secilenMalzemeMiktarlari);
            this.Close();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}