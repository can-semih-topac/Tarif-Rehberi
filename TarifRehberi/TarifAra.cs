using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarifRehberi.Models;

namespace TarifRehberi
{
    public partial class TarifAra : Form
    {
        public TarifAra()
        {
            InitializeComponent();
            LoadTarifler();
        }
        private void LoadTarifler()
        {
            Context context = new Context();
            List<Tarif> tarifler = context.TumTarifleriGetir();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void malzemeyeGöreTarifAraButonu_Click(object sender, EventArgs e)
        {
            MalzemeyeGöreTarifARa malzemeyegöretarifAraFormu = new MalzemeyeGöreTarifARa();
            malzemeyegöretarifAraFormu.Show();
        }

        private void aramayıBitirButonu_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void filtreEkleButonu_Click(object sender, EventArgs e)
        {
            FiltreEkle filtreekleform = new FiltreEkle();
            filtreekleform.Show();
        }

        private void tarifAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TarifAra_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:\\DATA\\foto/resim2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // tarifAdi TextBox'ının KeyDown olayını burada bağlayın
            this.tarifAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tarifAdi_KeyDown);
        }

        private void tariflerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaGoreTarifAraButonu_Click(object sender, EventArgs e)
        {
            this.tarifAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tarifAdi_KeyDown);
            string arananTarifAdi = tarifAdi.Text;

            Context context = new Context();
            List<Tarif> tarifler = context.TariflerAra(arananTarifAdi);
            Context context1 = new Context();
            List<Tarif> tarifler1 = context1.MalzemeTarifAra(arananTarifAdi);

            // İki listeyi birleştir
            List<Tarif> birlesikTarifler = tarifler.Concat(tarifler1).ToList();

            // Birleşik listeyi DataGridView'e ata
            dataGridView1.DataSource = birlesikTarifler;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void tarifAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adaGoreTarifAraButonu_Click(adaGoreTarifAraButonu, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
