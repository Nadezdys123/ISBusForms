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
    public partial class ListArchivForm : Form
    {
        private Collection<Archiv_doby_trasy> archiv;
        public ListArchivForm()
        {
            InitializeComponent();
            this.archiv = Archiv_doby_trasyTable.SelectAll();
        }

        private void ListArchivForm_Load(object sender, EventArgs e)
        {
            foreach (var arch in this.archiv)
            {
                var row = new string[] { arch.Realna_doba_trasy.ToString(), arch.Datum_zmeny.ToString(), arch.Linka.Cislo_linky.ToString(), arch.Spoj.Id_spoje.ToString()};
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
