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
    public partial class ListSpojForm : Form
    {
        private Collection<Linka_Ridic> spoje;
        public ListSpojForm()
        {
            InitializeComponent();
            this.spoje = Linka_RidicTable.SelectAll();
        }

        private void ListSpojForm_Load(object sender, EventArgs e)
        {
            foreach (var spoj in this.spoje)
            {
                var row = new string[] { spoj.Id_spoje.ToString(), spoj.Cas_odjezdu.TimeOfDay.ToString(), spoj.Linka.Cislo_linky.ToString(), spoj.Ridic.Osobni_cislo.ToString(), spoj.Bus.VIN, spoj.Stav_spoje };
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
