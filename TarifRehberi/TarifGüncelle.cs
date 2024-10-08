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
    public partial class TarifGüncelle : Form
    {
        public TarifGüncelle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void malzemeeklebutonu_Click(object sender, EventArgs e)
        {
            MalzemeEkle malzemeEkleForm = new MalzemeEkle();
            malzemeEkleForm.Show();
        }

        private void tarifigüncellebutonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            this.Close();
        }

        private void yeniKategoriEkleButonu_Click(object sender, EventArgs e)
        {
            YeniKategoriEkle yeniKategoriEkleForm = new YeniKategoriEkle();
            yeniKategoriEkleForm.Show();
        }
    }
}
