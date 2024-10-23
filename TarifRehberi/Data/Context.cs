using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata var (Context)", ex.Message);

            }
        }
        public List<Tarif> TariflerAra(string TarifAdi)
        {
            List<Tarif> tarifler = new List<Tarif>();
            using (conn)
            {
                conn.Open();
                string Equery1 = "Select * From Tarifler Where TarifAdi LIKE @TarifAdi";
                SqlDataReader reader = null;
                using (SqlCommand command = new SqlCommand(Equery1, conn))
                {
                    command.Parameters.AddWithValue("@TarifAdi", "%" + TarifAdi + "%");
                    try
                    {
                        reader = command.ExecuteReader();

                    }
                    catch (Exception ex)
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
        public List<Tarif> MalzemeTarifAra(string MalzemeAdi)
        {
            List<Tarif> tarifler = new List<Tarif>();

            using (conn)
            {
                conn.Open();
                int MalzemeID = -1;
                string Equery1 = "Select MalzemeID From Malzemeler Where MalzemeAdi = @MalzemeAdi";

                string Equery2 = "SELECT t.* FROM Tarifler t " +
                   "INNER JOIN TarifMalzemeIliskisi tm ON t.TarifID = tm.TarifID " +
                   "INNER JOIN Malzemeler m ON tm.MalzemeID = m.MalzemeID " +
                   "WHERE m.MalzemeID = @MalzemeId"; ;
                using (SqlCommand command = new SqlCommand(Equery1, conn))
                {
                    command.Parameters.AddWithValue("@MalzemeAdi", MalzemeAdi);
                    try
                    {
                        //MessageBox.Show("ilk try hatasız");
                        var Id= command.ExecuteScalar();
                        if (Id != null)
                            MalzemeID = (int)Id;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("MalzemeId alınırken hata yaşandı (MalzemeAratarif)", ex.Message);
                    }
                }
                if (MalzemeID != -1)
                {
                    using (SqlCommand command = new SqlCommand(Equery2, conn))
                    {
                        command.Parameters.AddWithValue("@MalzemeId", MalzemeID);
                        try
                        {

                            SqlDataReader reader = command.ExecuteReader();
                            //MessageBox.Show("ikinci try hatasız");
                            while (reader.Read())
                            {
                                Tarif tarif = new Tarif(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                                tarifler.Add(tarif);
                            }

                        }
                        catch (Exception ex) { MessageBox.Show("Malzemeden Tarif alırken bir hata yaşandı (MalzemeTarifAra)" + ex.Message); }


                    }
                }
               
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
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {

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
                    SqlDataReader reader = command.ExecuteReader(); // test
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
        public string MalzemeBirimGetir(string malzeme)
        {
            string query = "SELECT MalzemeBirim FROM Malzemeler WHERE MalzemeAdi = @malzeme";
            string birim = "";
            using (conn)

            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@malzeme", malzeme);

                    try
                    {
                        conn.Open();
                        birim = (string)cmd.ExecuteScalar();

                    }
                    catch (Exception ex) { MessageBox.Show("hata var (MalzemeBirimGetir)" + ex.Message); }


                }

                conn.Close();
            }
            return birim;

        }
        public SqlDataReader LoadeTarifler()
        {
            string query = "SELECT TarifAdi FROM Tarifler";
            SqlDataReader reader = null;

            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
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
                            MessageBox.Show("veriler " + reader["KategoriAdi"]);
                        }
                    }
                }

                conn.Close();
            }

            return reader;
        }
        public List<Tarif> TumTarifleriGetir()
        {
            List<Tarif> tarifler = new List<Tarif>();

            string query = "SELECT * FROM Tarifler";

            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string tarifAdi = reader.GetString(1);
                            string kategoriAdi = reader.GetString(2);
                            int hazirlamaSuresi = reader.GetInt32(3);
                            string talimatlar = reader.GetString(4);
                            tarifler.Add(new Tarif(id, tarifAdi, kategoriAdi, hazirlamaSuresi, talimatlar));
                        }
                        Console.WriteLine("Tarif başarıyla gösterildi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu:(Tum Tarifleri Getir) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }
                conn.Close();

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
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            tarifID = (int)result;
                        }
                        else
                        {
                            MessageBox.Show("Tarif bulunamadı: " + tarifAdi);
                            Console.WriteLine("Tarif bulunamadı: " + tarifAdi);
                            return;
                        }
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
        public void YeniTarifEkle(string tarifAdi, string kategori, int hazirlamaSuresi, string talimatlar)
        {
            if (conn == null)
            {
                MessageBox.Show("conn openlarda sorun var.");
                return;
            }

            using (conn)
            {
                conn.Open();
                string query0 = "INSERT INTO Tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar) VALUES (@TarifAdi, @Kategori, @HazirlamaSuresi, @Talimatlar)";

                using (SqlCommand command = new SqlCommand(query0, conn))
                {
                    command.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                    command.Parameters.AddWithValue("@Kategori", kategori);
                    command.Parameters.AddWithValue("@HazirlamaSuresi", hazirlamaSuresi);
                    command.Parameters.AddWithValue("@Talimatlar", talimatlar);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Tarif başarıyla eklendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: (yeni tarif eklerken) " + ex.Message);
                    }
                }

                conn.Close();
            }
        }
        public void TarifGüncelleMethodu(string tarifAdi)
        {
            string query = "SELECT * FROM Tarifler WHERE TarifAdi = @TarifAdi";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@TarifAdi", tarifAdi);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string kategoriAdi = reader.GetString(reader.GetOrdinal("KategoriAdi"));
                    int hazirlamaSuresi = reader.GetInt32(reader.GetOrdinal("HazirlamaSuresi"));
                    string talimatlar = reader.GetString(reader.GetOrdinal("Talimatlar"));

                    // Tarifin bilgilerini kullanarak istediğiniz işlemleri yapabilirsiniz
                    // Örneğin, bu bilgileri bir nesne içinde saklayabilir veya başka bir yönteme aktarabilirsiniz

                    Console.WriteLine("Tarif Adı: " + tarifAdi);
                    Console.WriteLine("Kategori Adı: " + kategoriAdi);
                    Console.WriteLine("Hazırlama Süresi: " + hazirlamaSuresi);
                    Console.WriteLine("Talimatlar: " + talimatlar);
                }
                else
                {
                    Console.WriteLine("Tarif bulunamadı.");
                }
                conn.Close();
            }
        } // kullanmıyoruz
        public Tarif TarifBilgileriGetir(int tarifID)
        {
            string query = "SELECT TarifAdi, KategoriAdi, HazirlamaSuresi, Talimatlar FROM Tarifler WHERE TarifID = @TarifID";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@TarifID", tarifID);
                conn.Close();
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string tarifAdi = reader.GetString(reader.GetOrdinal("TarifAdi"));
                    string kategoriAdi = reader.GetString(reader.GetOrdinal("KategoriAdi"));
                    int hazirlamaSuresi = reader.GetInt32(reader.GetOrdinal("HazirlamaSuresi"));
                    string talimatlar = reader.GetString(reader.GetOrdinal("Talimatlar"));

                    return new Tarif(tarifID, tarifAdi, kategoriAdi, hazirlamaSuresi, talimatlar);
                }
                else
                {
                    return null;
                }
            }
        }
        public Tarif TumTarifiGetir(int tarifID)
        {
            Tarif tarif = null;

            string query = "SELECT * FROM Tarifler WHERE TarifID = @TarifID";
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@TarifID", tarifID);

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int tarifId = reader.GetInt32(0);
                            string tarifAdi = reader.GetString(1);
                            string kategori = reader.GetString(2);
                            int hazirlamaSuresi = reader.GetInt32(3);
                            string talimatlar = reader.GetString(4);

                            tarif = new Tarif(tarifID, tarifAdi, kategori, hazirlamaSuresi, talimatlar);
                        }
                        else
                        {
                            Console.WriteLine("Tarif bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: (TumTarifiGetir) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }
            }


            return tarif;
        }
        public List<Malzeme> GetEskiMalzemeler(int tarifID)
        {
            List<Malzeme> malzemeler = new List<Malzeme>();

            using (conn)
            {
                conn.Open();
                string query = "SELECT m.*,tm.MalzemeMiktar FROM Malzemeler m " +
                               "INNER JOIN TarifMalzemeIliskisi tm ON m.MalzemeID = tm.MalzemeID " +
                               "WHERE tm.TarifID = @TarifID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@TarifID", tarifID);

                    try
                    {
                        
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int MalzemeID = reader.GetInt32(0);
                            string malzemeAdi = reader.GetString(1);
                            decimal malzemeMiktar = reader.GetDecimal(5);
                            string malzemeBirim = reader.GetString(3);
                            decimal birimFiyat = reader.GetDecimal(4);


                            malzemeler.Add(new Malzeme(MalzemeID,malzemeAdi,malzemeMiktar,malzemeBirim,birimFiyat));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: (GetEskiMalzemeler) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                    conn.Close();
                }
            }

            return malzemeler;
        }
        public Dictionary<int, decimal> MaliyetleriGetir()
        {
            Dictionary<int, decimal> Maliyetler = new Dictionary<int, decimal>();
            using (conn)
            {
                conn.Open();
                string Equery1 = "SELECT * FROM Maliyet";
                using (SqlCommand command = new SqlCommand(Equery1, conn))
                {
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Maliyetler.Add(reader.GetInt32(0), reader.GetDecimal(1));

                        }
                    }
                    catch (Exception ex) { MessageBox.Show("hata var (MaliyetleriGetir)" + ex.Message); }

                }

            }



            return Maliyetler;
        }
        public decimal MaliyetGetir(int tarifID)
        {
            decimal maliyet = 0;

            using (conn)
            {
                conn.Open();
                string query = "SELECT Maliyet FROM Maliyetler WHERE TarifID = @TarifID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    MessageBox.Show("Çalıştı");
                    try
                    {
                        command.Parameters.AddWithValue("@TarifID", tarifID);
                        decimal result = (decimal)command.ExecuteScalar();
                        if (result != null)
                        {
                            maliyet = result;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: (MaliyetiGetir)" + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                        conn.Close();
                    }
                }
                conn.Close();
            }


            return maliyet;
        }
        public bool TarifeMalzemeYetiyormuKontrol(int tarifID)
        {
            bool yeterliMalzeme = true;

            string query = "SELECT tm.MalzemeID, tm.MalzemeMiktar, m.ToplamMiktar " +
                           "FROM TarifMalzemeIliskisi tm " +
                           "INNER JOIN Malzemeler m ON tm.MalzemeID = m.MalzemeID " +
                           "WHERE tm.TarifID = @TarifID";

            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@TarifID", tarifID);

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            decimal malzemeMiktar = reader.GetDecimal(reader.GetOrdinal("MalzemeMiktar"));
                            decimal toplamMiktar = reader.GetDecimal(reader.GetOrdinal("ToplamMiktar"));

                            if (toplamMiktar < malzemeMiktar)
                            {
                                yeterliMalzeme = false;
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: (TarifMalzemeKontrol) " + ex.Message);
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                        yeterliMalzeme = false;
                    }
                }
                conn.Close();
            }

            return yeterliMalzeme;
        }

        

    }
}