using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Zastavka
    {
        public int Cislo_zastavky { get; set; }
        public string Nazev { get; set; }
        public string Ulice { get; set; }
        public int Tarifni_zona { get; set; }
    }
}
