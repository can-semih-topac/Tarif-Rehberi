using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TarifRehberi
{
    public class Context
    {
        // Veritabanı bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-8MG4EKJ\\SQLEXPRESS;Initial Catalog=TarifRehberiDB;Integrated Security=True;Trust Server Certificate=True";
        private SqlConnection conn=null;

        public SqlConnection getConn { get { return conn; } }  
        
        

        public Context()
        {
            conn = new SqlConnection(connectionString);
        }

        public void YeniMalzemeEkle(string malzemeAdi, string malzemeBirimi, decimal birimFiyat, decimal toplamMiktar)
        {
            conn.Close();
            conn.Open();
            string query = "INSERT INTO Malzemeler (MalzemeAdi, MalzemeBirim, BirimFiyat, ToplamMiktar) VALUES (@MalzemeAdi, @MalzemeBirim, @BirimFiyat, @ToplamMiktar)";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                command.Parameters.AddWithValue("@MalzemeBirim", malzemeBirimi);
                command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                command.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Malzeme başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void YeniKategoriEkle(string kategoriAdi)
        {
            conn.Close();
            conn.Open();
            string query = "INSERT INTO Kategoriler (KategoriAdi) VALUES (@KategoriAdi)";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Kategori başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void YeniTarifEkle(string tarifAdi, string kategoriAdi, decimal hazirlanmaSuresi, string talimatlar)
        {
            conn.Close();
            conn.Open();
            string query = "INSERT INTO Tarifler (TarifAdi, KategoriAdi, HazirlanmaSuresi, Talimatlar) VALUES (@TarifAdi, @KategoriAdi, @HazirlanmaSuresi, @Talimatlar)";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                command.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                command.Parameters.AddWithValue("@HazirlanmaSuresi", hazirlanmaSuresi);
                command.Parameters.AddWithValue("@Talimatlar", talimatlar);

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Tarif başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    
                }
            }
        }
        SqlDataReader Sorgu(string select, string from, string where)
        {
            object[] sonuc = null;
            using (conn)
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = null;
                SqlCommand command = null;

                if (where == null)
                {
                     command = new SqlCommand("SELECT " + select + " FROM " + from, conn);
                }
                else
                {
                     command = new SqlCommand("SELECT " + select + " FROM " + from + " WHERE " + where, conn);
                }
                try
                {
                    reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }

                return reader; 
            }
            
        }


                public SqlDataReader LoadKategoriler()
        {
            string query = "SELECT KategoriAdi FROM Kategoriler";
            SqlDataReader reader = null;

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }

                if (reader != null)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("veriler " + reader["KategoriAdi"]);
                    }
                }

                conn.Close();
            }

            return reader;
        }
        public List<string> TumKategorileriGetir()
        {
            List<string> kategoriler = new List<string>();

            conn.Close();
            conn.Open();
            string query = "SELECT KategoriAdi FROM Kategoriler";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string kategoriAdi = reader.GetString(0);
                        kategoriler.Add(kategoriAdi);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return kategoriler;
        }

        internal SqlConnection getConn()
        {
            throw new NotImplementedException();
        }
    }
}
