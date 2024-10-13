using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TarifRehberi
{
    public class Context
    {
        // Veritabanı bağlantı dizesi
        private string Path = "C:\\DATA\\ConnectionString.txt";
        private string connectionString;
        private SqlConnection conn=null;

        public SqlConnection getConn { get { return conn; } }  
        
        

        public Context()
        {
            try
            {
                connectionString = System.IO.File.ReadAllText(Path);
            }catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
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
                    MessageBox.Show("Kategori başarıyla eklendi.");
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
        public void YeniTarifEkle(string tarifAdi, string kategoriAdi, int hazirlamaSuresi, string talimatlar, decimal malzemeMiktari)
        {
            using (conn)
            {
                conn.Close();
                conn.Open();
                string query0 = "INSERT INTO Tarifler (TarifAdi, KategoriAdi, HazirlamaSuresi, Talimatlar) VALUES (@TarifAdi, @KategoriAdi, @HazirlamaSuresi, @Talimatlar)";

                using (SqlCommand command = new SqlCommand(query0, conn))
                {
                    command.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                    command.Parameters.AddWithValue("@KategoriAdi", kategoriAdi);
                    command.Parameters.AddWithValue("@HazirlamaSuresi", hazirlamaSuresi);
                    command.Parameters.AddWithValue("@Talimatlar", talimatlar);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Tarif başarıyla eklendi.");
                        MessageBox.Show("Tarif başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
                /*
                string query2 = "INSERT INTO TarifMalzemeler (SecilenMalzeme, MalzemeMiktari, TarifAdi) VALUES (@MalzemeAdi, @MalzemeMiktar, @TarifAdi)";

                using (SqlCommand command = new SqlCommand(query2, conn))
                {
                    // command.Parameters.AddWithValue("@MalzemeAdi", secilenMalzeme);
                    command.Parameters.AddWithValue("@MalzemeMiktar", malzemeMiktari);
                    command.Parameters.AddWithValue("@TarifAdi", tarifAdi);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Malzeme başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }
                */
                conn.Close();
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
                conn.Close();
            }

            return kategoriler;
        }
        public SqlDataReader LoadMalzemeler()
        {
            string query2 = "SELECT MalzemeAdi FROM Malzemeler";
            SqlDataReader reader = null;

            using (conn)
            {
                SqlCommand command = new SqlCommand(query2, conn);

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
                        MessageBox.Show("veriler " + reader["MalzemeAdi"]);
                    }
                }

                conn.Close();
            }

            return reader;
        }
         public List<string> TumMalzemeleriGetir() // burada yalnızca malzeme adını getiriyoruz ama diğer bilgiler de gelmeli
        {
            List<string> malzemeler = new List<string>();

            conn.Close();
            conn.Open();
            string query2 = "SELECT MalzemeAdi FROM Malzemeler";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query2, conn);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string malzemeAdi = reader.GetString(0);
                        malzemeler.Add(malzemeAdi);
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

            return malzemeler;
        }

        public SqlDataReader LoadTarifler()
        {
            string query = "SELECT TarifAdi FROM Tarifler";
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
        public List<string> TumTarifleriGetir()
        {
            List<string> tarifler = new List<string>();

            conn.Close();
            conn.Open();
            string query = "SELECT TarifAdi FROM Tarifler";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tarifAdi = reader.GetString(0);
                        tarifler.Add(tarifAdi);
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
                conn.Close();
            }

            return tarifler;
        }
    }
}
