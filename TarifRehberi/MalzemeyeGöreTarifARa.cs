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
    public partial class MalzemeyeGöreTarifARa : Form
    {
        public MalzemeyeGöreTarifARa()
        {
            InitializeComponent();
        }

        private void aramayıBitirButonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            this.Close();
        }

        private void araButonu_Click(object sender, EventArgs e)
        {

        }

        private void ekleButonu_Click(object sender, EventArgs e)
        {
            string malzemeisim = textBox1.Text;
            Context context = new Context();
            List<Tarif> tarifler = context.MalzemeTarifAra(malzemeisim);
            listBox2.Items.Clear();
            foreach ( Tarif tarif in tarifler)
            {
                listBox2.Items.Add(tarif.Kategori);
            }
        }

        

        private void filtreEkleButonu_Click(object sender, EventArgs e)
        {
            FiltreEkle filtreekleform = new FiltreEkle();
            filtreekleform.Show();
        }

        private void MalzemeyeGöreTarifARa_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:\\DATA\\foto/resim6.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
