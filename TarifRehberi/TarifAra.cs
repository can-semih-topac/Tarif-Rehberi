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
            List<(string, string, int)> tarifler = context.TumTarifleriGetir();

            foreach (var tarif in tarifler)
            {
                tariflerListBox.Items.Add(string.Format("{0,-10} {1,5}dk      {2,-10} ", tarif.Item1, tarif.Item3, tarif.Item2));
                tariflerListBox.Items.Add(""); // Add an empty item for spacing
            }

            tariflerListBox.Font = new Font(tariflerListBox.Font.FontFamily, 10);
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
            // Save changes and close the form
            // TODO: Add code to save changes

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

        }

        private void tariflerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
