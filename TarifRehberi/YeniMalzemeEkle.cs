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
    public partial class YeniMalzemeEkle : Form
    {
        public YeniMalzemeEkle()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void malzemeAdıBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void malzemeBirimiBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birimFiyatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depodakiMiktarBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void yeniMalzemeEkleButonu_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan bilgileri değişkenlere atama
            string malzemeAdi = malzemeAdıBox.Text;
            string malzemeBirimi = malzemeBirimiBox.Text;
            decimal birimFiyat;
            decimal.TryParse(birimFiyatBox.Text, out birimFiyat);
            decimal toplamMiktar;
            decimal.TryParse(depodakiMiktarBox.Text, out toplamMiktar);

            // Veritabanı bağlantı dizesi
            string connectionString = "Data Source=CAN-TOPAC-PC;Initial Catalog=TarifRehberiDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False";

            // SQL sorgusu
            string query = "INSERT INTO Malzemeler (MalzemeAdi, MalzemeBirim, BirimFiyat, ToplamMiktar) VALUES (@MalzemeAdi, @MalzemeBirim, @BirimFiyat, @ToplamMiktar)";

            // Veritabanına bağlanma ve sorguyu çalıştırma
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                command.Parameters.AddWithValue("@MalzemeBirim", malzemeBirimi);
                command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                command.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);

                try
                {
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("Malzeme başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            

            // Formu kapatma
            this.Close();
        }
    }
}
