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
        private List<string> secilenMalzemeler = new List<string>();
        public MalzemeyeGöreTarifARa()
        {
            InitializeComponent();
            LoadMalzemeler();
        }

        private void LoadMalzemeler()
        {
            Context context = new Context();
            List<string> malzemeler = context.TumMalzemeleriGetir();

            comboBox1.Items.AddRange(malzemeler.ToArray());
        }
        private void aramayıBitirButonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            this.Close();
        }

        private void araButonu_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            List<Tarif> tarifler = context.MalzemelerdenEslesmeYuzdesiBul(secilenMalzemeler);

            dataGridView1.DataSource = tarifler;
        }

        private void ekleButonu_Click(object sender, EventArgs e)
        {
            string malzemeisim = comboBox1.Text;

            if (!string.IsNullOrEmpty(malzemeisim))
            {
                if (!listBox1.Items.Contains(malzemeisim))
                {
                    listBox1.Items.Add(malzemeisim);
                    secilenMalzemeler.Add(malzemeisim);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

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




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}