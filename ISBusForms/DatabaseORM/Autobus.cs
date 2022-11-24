using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class Autobus
    {
        public string VIN { get; set; }
        public string SPZ { get; set; }
        public string Model { get; set; }
        public string Vyrobce { get; set; }
        public int Pocet_mist { get; set; }

    }
}
