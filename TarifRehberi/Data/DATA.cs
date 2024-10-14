using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifRehberi.Data
{
    class DATA
    {
        public string DatabaseAdi = "TarifRehberiDB";
        public static string TarifTablosu = "Tarifler";
        string MalzemeTablosu = "Malzemeler";
        string Tarif_MalzemeTablosu = "";
        string KategorilerTablosu = "Kategoriler";

        string tarifID="TarifID";
        string tarifAdi="TarifAdi";
        string kategori="Kategori";
        string hazirlanmaSuresi="HazirlamaSuresi";
        string talimatlar = "Talimatlar";

        string malzemeID = "MalzemeID";
        string malzemeAdı = "MalzemeAdi";
        string toplamMiktar = "ToplamMiktar";
        string birimFiyat = "BirimFiyat";

        string malzemeMiktar = "MalzemeMiktar";


        static Context context=new Context();
        
        public DATA()
        {
            SqlConnection con = context.getConn;
            string query1 = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'TarifRehberiDB')\r\nBEGIN\r\n    CREATE DATABASE TarifRehberiDB;\r\nEND";

            string query2 = "";

            string query3 = "";
            using (con) {
                
                con.Close();
                con.Open();
                    SqlCommand command = new SqlCommand(query1,con);
                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Complated");
                }catch (Exception ex) { Console.WriteLine("Couldnt add database (query 1)"); }


            }

        }

    }
}
