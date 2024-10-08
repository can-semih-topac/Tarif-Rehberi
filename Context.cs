using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TarifRehberi
{
    public class Context
    {
        private string connectionString;

        public Context(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertMalzeme(string malzemeAdi, string malzemeBirimi, decimal birimFiyat, decimal toplamMiktar)
        {
            string query = "INSERT INTO Malzemeler (MalzemeAdi, MalzemeBirim, BirimFiyat, ToplamMiktar) VALUES (@MalzemeAdi, @MalzemeBirim, @BirimFiyat, @ToplamMiktar)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MalzemeAdi", malzemeAdi);
                command.Parameters.AddWithValue("@MalzemeBirim", malzemeBirimi);
                command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                command.Parameters.AddWithValue("@ToplamMiktar", toplamMiktar);

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Malzeme baþarýyla eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluþtu: " + ex.Message);
                }
            }
        }
    }
}
