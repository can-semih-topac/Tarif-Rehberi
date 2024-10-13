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
            Context context = new Context();
            List<string> tarifler = context.TumTarifleriGetir();

            foreach (string tarif in tarifler)
            {
                tariflerListBox.Items.Add(tarif);
            }
        }
    }
}
