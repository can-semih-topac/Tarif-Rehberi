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
        public TarifEkleForm()
        {
            InitializeComponent();
            // LoadKategoriler();
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

        private void malzemeeklebutonu_Click(object sender, EventArgs e)
        {
            MalzemeEkle malzemeEkleForm = new MalzemeEkle();
            malzemeEkleForm.Show();
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
        
    }
}
