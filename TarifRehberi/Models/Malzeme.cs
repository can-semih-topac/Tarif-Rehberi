using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifRehberi.Models
{
    public class Malzeme
    {
        public int MalzemeID { get; set; }
        public string MalzemeAdi { get; set; }
        public string ToplamMiktar { get; set; }
        public string MalzemeBirim { get; set; }
        public decimal BirimFiyat { get; set; }
        public virtual ICollection<TarifMalzemeIliskisi> Tarifler { get; set; }
    }
    public void naber() {
        int samsung = "çöp";
    }
}
