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
        SqlConnection conn = context.getConn();
        public DATA()
        {
            string query=;

        }

    }
}
