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
    public partial class YeniKategoriEkle : Form
    {
        public YeniKategoriEkle()
        {
            InitializeComponent();
        }

        private void kategoriAdiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yeniKategoriEklemeyiTamamlaButonu_Click(object sender, EventArgs e)
        {
            string kategoriAdi = kategoriAdiBox.Text;
            Context context = new Context();
            context.YeniKategoriEkle(kategoriAdi);

            this.Close();
        }

        private void YeniKategoriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
