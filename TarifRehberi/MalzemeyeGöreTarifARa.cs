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

        }

        private void filtreEkleButonu_Click(object sender, EventArgs e)
        {
            FiltreEkle filtreekleform = new FiltreEkle();
            filtreekleform.Show();
        }

        private void MalzemeyeGöreTarifARa_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("C:\\Users\\canse\\source\\repos\\can-semih-topac\\TarifRehberi\\TarifRehberi\\Resources/resim6.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
