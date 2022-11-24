using System;

namespace ISBusForms.DatabaseORM
{
    class SpojZjednoduseny
    {
        public int Id_spoje { get; set; }
        public DateTime Cas_odjezdu { get; set; }
        public Linka Linka { get; set; }
    }
}
