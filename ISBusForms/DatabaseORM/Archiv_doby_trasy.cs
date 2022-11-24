using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Archiv_doby_trasy
    {
        public int Realna_doba_trasy { get; set; }
        public DateTime Datum_zmeny { get; set; }
        public Linka Linka { get; set; }
        public Linka_Ridic Spoj { get; set; }

    }
}
