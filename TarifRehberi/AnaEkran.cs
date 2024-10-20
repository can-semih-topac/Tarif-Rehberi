using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarifRehberi
{
    public partial class AnaEkran : Form
    {

        private List<(string, string, int)> tarifler;

        public AnaEkran()
        {
            InitializeComponent();
            LoadTarifler();
        }

        private void LoadTarifler()
        {
            // Ensure columns are added
            dataGridView1.Columns.Add("Column1", "Column1 Header");
            dataGridView1.Columns.Add("Column2", "Column2 Header");
            dataGridView1.Columns.Add("Column3", "Column3 Header");

            Context context = new Context();
            tarifler = context.TumTarifleriGetir();

            foreach (var tarif in tarifler)
            {
                dataGridView1.Rows.Add(tarif.Item1, tarif.Item3, tarif.Item2);
            }

            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tarifeklebutonu_Click(object sender, EventArgs e)
        {
            TarifEkleForm tarifEkleForm = new TarifEkleForm();
            tarifEkleForm.Show();
        }

        private void tarifguncellebutonu_Click(object sender, EventArgs e)
        {

        }

        private void tarifsilbutonu_Click(object sender, EventArgs e)
        {
            TarifSil tarifSilForm = new TarifSil();
            tarifSilForm.Show();
        }

        private void oneriAlButonu_Click(object sender, EventArgs e)
        {

        }

        private void tarifAraButonu_Click(object sender, EventArgs e)
        {
            TarifAra tarifAraForm = new TarifAra();
            tarifAraForm.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (tarifler.Count > 0)
                {
                    List<(string, string, int)> selectedTarif = tarifler;
                    TarifGüncelleForm tarifGuncelleForm = new TarifGüncelleForm(selectedTarif);
                    tarifGuncelleForm.Show();
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (tarifler.Count > 0)
                {
                    List<(string, string, int)> selectedTarif = tarifler;
                    TarifGüncelleForm tarifGuncelleForm = new TarifGüncelleForm(selectedTarif);
                    tarifGuncelleForm.Show();
                }
            }
        }
    }
}