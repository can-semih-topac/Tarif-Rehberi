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
        Dictionary<int, decimal> Maliyetler;

        public AnaEkran()
        {
            InitializeComponent();
            LoadTarifler();
        }


        private void LoadTarifler()
        {
            // Ensure columns are added
            Context context = new Context();
            Context context2 = new Context();
            tarifler = context.TumTarifleriGetir();
            dataGridView1.Columns.Add("Column0", "TarifID");
            dataGridView1.Columns.Add("Column1", "Tarif Adı");
            dataGridView1.Columns.Add("Column2", "Hazırlanma süresi (dk)");
            dataGridView1.Columns.Add("Column3", "Kategori");
            dataGridView1.Columns.Add("Column4", "Maliyet");

            Maliyetler = context2.MaliyetleriGetir();
            foreach (Tarif tarif in tarifler)
            {
                int rowIndex = dataGridView1.Rows.Add(tarif.TarifID, tarif.TarifAdi, tarif.HazirlamaSuresi, tarif.Kategori, Maliyetler[tarif.TarifID]);
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                Context context1 = new Context();
                if (context1.TarifeMalzemeYetiyormuKontrol(tarif.TarifID))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }

            /*
            dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 10);
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            */
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
            
            BackgroundImage = Image.FromFile("C:\\DATA\\foto/yemekresmianaekran.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            /*
            void  InitializeIcon()
            {
                this.Icon = new Icon("C:\\Users\\canse\\source\\repos\\can-semih-topac\\TarifRehberi\\TarifRehberi\\Resources\\indir.jpg"); // ikon ekleme olmadı
            }
            */
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
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                int selectedIndex = dataGridView1.CurrentRow.Index;


                int TarifID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells[0].Value);
                
                TarifGüncelleForm tarifGüncelleForm = new TarifGüncelleForm(TarifID);
                tarifGüncelleForm.Show();
                

            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }

        }

    }
}