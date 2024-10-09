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
    public partial class TarifEkleForm : Form
    {
        private List<string> malzemeler;
        public TarifEkleForm()
        {
            InitializeComponent();
            LoadKategoriler();
        }
        private void LoadKategoriler()
        {
            Context context = new Context();
            List<string> kategoriler = context.TumKategorileriGetir();

            kategoriComboBox.Items.AddRange(kategoriler.ToArray());
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

        private void TarifEkleForm_Load(object sender, EventArgs e)
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
                // Kategorileri göstermek için uygun bir kontrolü kullanın, örneğin ListBox
                kategoriComboBox.Items.Add(kategori);
            }
            
            


        }
        private void talimatlarBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void tarifitamamlabutonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            string tarifAdi = tarifAdiBox.Text;
            decimal hazirlanmasuresi;
            decimal.TryParse(hazirlanmaSuresiBox.Text, out hazirlanmasuresi);
            string secilenKategori = kategoriComboBox.SelectedItem.ToString();

            string talimatlar = talimatlarBox.Text;

            this.Close();
        }

        
    }
}

