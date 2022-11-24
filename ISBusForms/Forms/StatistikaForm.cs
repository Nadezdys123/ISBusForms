using ISBusForms.DatabaseORM;
using ISBusForms.DatabaseORM.slq_database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBusForms.Forms
{
    public partial class StatistikaForm : Form
    {
        private Collection<StatistikaLinek> statistika;
        public StatistikaForm()
        {
            InitializeComponent();
            this.statistika = LinkaTable.StatistikaLinek();
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {
            foreach (var stat in this.statistika)
            {
                var row = new string[] { stat.Cislo_linky.ToString(), stat.Min_doba_trasy.ToString(), stat.Max_doba_trasy.ToString(), stat.Avg_doba_trasy.ToString(), stat.Nejcastejsi_ridic.Osobni_cislo.ToString() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
