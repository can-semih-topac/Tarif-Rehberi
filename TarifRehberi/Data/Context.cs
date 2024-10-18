using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarifRehberi.Data;
using TarifRehberi.Models;


namespace TarifRehberi
{
    public class Context
    {
        // Veritabanı bağlantı dizesi
        private string Path = "C:\\DATA\\ConnectionString.txt";
        private string connectionString;
        private SqlConnection conn = null;

        public SqlConnection getConn { get { return conn; } }



        public Context()
        {
            try
            {
                connectionString = System.IO.File.ReadAllText(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            conn = new SqlConnection(connectionString);
        }
        public List<Tarif>  TariflerAra(string TarifAdi) {
            List<Tarif> tarifler = new List<Tarif>();
            using(conn)
            {
                conn.Open();
                string Equery1 = "Select * From Tarifler Where TarifAdi = @TarifAdi";
                SqlDataReader reader = null;
                using (SqlCommand command = new SqlCommand(Equery1,conn))
                {
                    command.Parameters.AddWithValue("@TarifAdi", TarifAdi);
                    try
                    {
                        reader=command.ExecuteReader();
                        
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu:(TarifArama) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                    while (reader.Read()) 
                    {
                        Tarif tarif = new Tarif(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                        tarifler.Add(tarif);    
                    }
                } 
            }
            return tarifler;
        }
        public List<Tarif> MalzemeTarifAra(string TarifAdi)
        {
            List<Tarif> tarifler=new List<Tarif>();
            using (conn)
            {
                
            }

            return tarifler;

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
                conn.Open ();
                using(SqlCommand command = new SqlCommand()) { 

                try
                {
                    
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
            }

            return reader;
        }
        public List<string> TumMalzemeleriGetir()
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
        public List<(string, string, int)> TumTarifleriGetir()
        {
            List<(string, string, int)> tarifler = new List<(string, string, int)>();

            conn.Close();
            conn.Open();
            string query = "SELECT TarifAdi, KategoriAdi, HazirlamaSuresi FROM Tarifler";

            using (conn)
            {
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string tarifAdi = reader.GetString(0);
                        string kategoriAdi = reader.GetString(1);
                        int hazirlamaSuresi = reader.GetInt32(2);
                        tarifler.Add((tarifAdi, kategoriAdi, hazirlamaSuresi));
                    }
                    Console.WriteLine("Tarif başarıyla gösterildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }

            }

            return tarifler;
        }
        public void EkleTarifMalzemeIliskisi(string tarifAdi, List<string> malzemeler, List<decimal> secilenMalzemeMiktarlari)
        {
            if (conn == null)
            {
                MessageBox.Show("conn openlarda sorun var.");
                return;
            }
            using (conn)
            {
                conn.Open();
                MessageBox.Show("conn openlarda sorun yok.");
                decimal maliyet = 0;
                int tarifID = -1;
                string query1 = "SELECT TarifID FROM Tarifler WHERE TarifAdi = @TarifAdi";

                using (SqlCommand command = new SqlCommand(query1, conn))
                {
                    command.Parameters.AddWithValue("@TarifAdi", tarifAdi);

                    try
                    {
                        tarifID = (int)command.ExecuteScalar(); // TarifID'yi alıyor
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu:1 " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }
                for (int i = 0; i < malzemeler.Count; i++)
                {
                    
                    string malzemeAdi = malzemeler[i];
                    decimal malzemeMiktar = secilenMalzemeMiktarlari[i];

                    int malzemeID = -1;
                    string query = "SELECT MalzemeID FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";
                    string queryEwiz1 = "SELECT BirimFiyat FROM Malzemeler WHERE MalzemeAdi = @MalzemeAdi";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                        try
                        {
                            malzemeID = (int)command.ExecuteScalar(); // MalzemeID'yi alıyor                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu: " + ex.Message);
                            Console.WriteLine("Bir hata oluştu: " + ex.Message);
                        }
                    }
                    // burada tarifAdi ni tanımlamak gerekiyor.
                    using (SqlCommand command = new SqlCommand(queryEwiz1, conn))
                    {
                        command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);

                        try
                        {
                            decimal fiyat = (decimal)command.ExecuteScalar(); // MalzemeID'yi alıyor
                            maliyet += fiyat * secilenMalzemeMiktarlari[i];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bir hata oluştu:(Maliyet) " + ex.Message);
                            Console.WriteLine("Bir hata oluştu: " + ex.Message);
                        }
                    }

                    if (malzemeID != -1)
                    {
                        string insertQuery = "INSERT INTO TarifMalzemeIliskisi (TarifID, MalzemeID, MalzemeMiktar) VALUES (@TarifID, @MalzemeID, @MalzemeMiktar)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                        {
                            insertCommand.Parameters.AddWithValue("@TarifID", tarifID);
                            insertCommand.Parameters.AddWithValue("@MalzemeID", malzemeID);
                            insertCommand.Parameters.AddWithValue("@MalzemeMiktar", malzemeMiktar);

                            try
                            {
                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show("Tarif malzeme ilişkisi başarıyla eklendi.");
                                Console.WriteLine("Tarif malzeme ilişkisi başarıyla eklendi.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Bir hata oluştu:2 " + ex.Message);
                                Console.WriteLine("Bir hata oluştu: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Malzeme bulunamadı: " + malzemeAdi);
                        Console.WriteLine("Malzeme bulunamadı: " + malzemeAdi);
                    }
                }
                string ewiz2query = "INSERT INTO Maliyet (TarifID, Maliyet) VALUES (@TarifID, @Maliyet)";
                using (SqlCommand insertCommand2 = new SqlCommand(ewiz2query, conn))
                {
                    insertCommand2.Parameters.AddWithValue("@TarifID", tarifID);
                    insertCommand2.Parameters.AddWithValue("@Maliyet", maliyet);
                    

                    try
                    {
                        insertCommand2.ExecuteNonQuery();
                        MessageBox.Show("Maliyet ilişkisi başarıyla eklendi.");
                        Console.WriteLine("Maliyet ilişkisi başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu:(Maliyet Tablosuna ekleme hatası) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }

                conn.Close();
            }

        }
        public void YeniTarifEkle(string tarifAdi, string kategoriAdi, int hazirlamaSuresi, string talimatlar)
        {
            if (conn == null)
            {
                MessageBox.Show("conn openlarda sorun var.");
                return;
            }

            

            using (conn)
            {
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
                        MessageBox.Show("Tarif başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }

                conn.Close();
            }
        }
    }
}