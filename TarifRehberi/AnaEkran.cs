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
using TarifRehberi.Models;

namespace TarifRehberi
{
    public partial class AnaEkran : Form
    {

        private List<Tarif> tarifler;

        public AnaEkran()
        {
            InitializeComponent();
            LoadTarifler();
        }

        private void LoadTarifler()
        {
            // Ensure columns are added
            dataGridView1.Columns.Add("Column0", "TarifID");
            dataGridView1.Columns.Add("Column1", "Tarif Adı");
            dataGridView1.Columns.Add("Column2", "Hazırlanma süresi (dk)");
            dataGridView1.Columns.Add("Column3", "Kategori");
            dataGridView1.Columns.Add("Column4", "Maliyet");

            Context context = new Context();
            tarifler = context.TumTarifleriGetir();
            MessageBox.Show(tarifler.Count.ToString());
            foreach (var tarif in tarifler)
            {
                dataGridView1.Rows.Add( tarif.TarifID,tarif.TarifAdi, tarif.HazirlamaSuresi, tarif.Kategori, 1);
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

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (tarifler.Count > 0)
                {
                    List<Tarif> selectedTarif = tarifler;
                    //TarifGüncelleForm tarifGuncelleForm = new TarifGüncelleForm(selectedTarif);
                    //tarifGuncelleForm.Show();
                }
            }
            else
            {
                var selectedTarif = tarifler[e.RowIndex];
                //TarifGüncelleForm tarifGuncelleForm = new TarifGüncelleForm(new List<(string, string, int)> { selectedTarif });
                //tarifGuncelleForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Seçili satırdaki verileri alalım
                int selectedIndex = dataGridView1.CurrentRow.Index;

                // Örneğin: ilk sütunda işçi ID'si var
                int TarifID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);

                // Diğer sütunlardan veri alabilirsiniz
               

                // Yeni formu oluşturup veriyi gönder
               // Form2 yeniForm = new Form2(isciId, isciAdi, pozisyon);
                //yeniForm.Show(); // Yeni formu göster
                //TarifGüncelleForm tarifGüncelleForm = new TarifGüncelleForm(TarifID);
                MessageBox.Show(TarifID+"");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }

        }

    }
}