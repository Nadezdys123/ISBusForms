using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Linka_Zastavka
    {
        public int Poradi_zastavky { get; set; }
        public DateTime Relativni_cas_odjezdu { get; set; }
        public Linka Linka { get; set; }
        public Zastavka Zastavka { get; set; }
        public Linka_Ridic Spoj { get; set; }
        public string Stav_zastavky { get; set; }

    }
}
