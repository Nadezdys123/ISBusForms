
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBusForms.DatabaseORM
{
    class StatistikaLinek
    {
        public int Cislo_linky { get; set; }
        public int Min_doba_trasy { get; set; }
        public int Max_doba_trasy { get; set; }
        public int Avg_doba_trasy { get; set; }
        public Ridic Nejcastejsi_ridic { get; set; }
    }
}
