using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifRehberi.Models
{
    public class TarifMalzemeIliskisi
    {
        public int TarifID { get; set; }
        public int MalzemeID { get; set; }
        public float MalzemeMiktar { get; set; }
        public virtual Tarif Tarif { get; set; }
        public virtual Malzeme Malzeme { get; set; }
    }
}
