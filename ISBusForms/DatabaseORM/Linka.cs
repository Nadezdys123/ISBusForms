using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Linka
    {
        public int Cislo_linky { get; set; }
        public string Nazev_linky { get; set; }
        public int? Delka_trasy { get; set; }
        public int? Predepsana_doba_trasy { get; set; }

    }
}
