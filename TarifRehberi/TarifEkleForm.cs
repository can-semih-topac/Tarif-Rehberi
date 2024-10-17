﻿using System;
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
        private List<string> kategoriler;
        private List<decimal> secilenMalzemeMiktarlari;
        // private List<string> eklenenmalzemeler;

        public TarifEkleForm()
        {
            malzemeler = new List<string>();
            secilenMalzemeMiktarlari = new List<decimal>();
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
        private void TarifEkleForm_Load(object sender, EventArgs e)
        {
            Context context = new Context();
           /* List<string> kategoriler = context.TumKategorileriGetir();
            Context context2 = new Context();
            List<string> malzemeler = context2.TumMalzemeleriGetir();*/
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

        }
        private void malzemeEkleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             

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
            malzemeEkleComboBox.SelectedItem = null;
            malzemeMiktariBox.Text = string.Empty;
            listBox1.Items.Clear(); // ListBox'ı temizle
            for (int i = 0; i < malzemeler.Count; i++)
            {
                string malzeme = malzemeler[i] + " - " + secilenMalzemeMiktarlari[i];
                listBox1.Items.Add(malzeme); // Malzemeler listesindeki her bir malzemeyi ListBox'a ekle
                MessageBox.Show(malzeme); // Her bir malzemeyi mesaj olarak göster
            }
        }
        private void malzemeMiktariBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void tarifitamamlabutonu_Click(object sender, EventArgs e)
        {
            
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

