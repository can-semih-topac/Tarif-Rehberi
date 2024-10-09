using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarifRehberi.Models
{
    internal class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public virtual ICollection<Tarif> Tarifler { get; set; }
    }
}
