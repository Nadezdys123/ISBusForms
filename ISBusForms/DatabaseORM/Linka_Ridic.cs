using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Linka_Ridic
    {
        public int Id_spoje { get; set; }
        public DateTime Cas_odjezdu { get; set; }
        public Linka Linka { get; set; }
        public Ridic Ridic { get; set; }
        public Autobus Bus { get; set; }
        public String Stav_spoje { get; set; }

    }
}


