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
    public partial class MalzemeEkle : Form
    {
        public List<string> Malzemeler { get; private set; }
        public MalzemeEkle()
        {
            InitializeComponent();
            Malzemeler = new List<string>();
        }

        private void MalzemeEkle_Load(object sender, EventArgs e)
        {

        }

        private void malzemeEklemeyiTamamlaButonu_Click(object sender, EventArgs e)
        {
            // Save changes and close the form
            // TODO: Add code to save changes

            this.Close();
        }

        private void secilenMalzemeyiEkleButonu_Click(object sender, EventArgs e)
        {
            
        }

        private void yeniMalzemeEkleButonu_Click(object sender, EventArgs e)
        {
            YeniMalzemeEkle yeniMalzemeEkleFormu = new YeniMalzemeEkle();
            yeniMalzemeEkleFormu.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
