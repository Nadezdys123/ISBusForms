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
    public partial class ListLinkaForm : Form
    {
        private Collection<Linka> linky;
        public ListLinkaForm()
        {
            InitializeComponent();
            this.linky = LinkaTable.SelectAll();
        }

        private void ListLinkaForm_Load(object sender, EventArgs e)
        {
            foreach(var linka in this.linky)
            {
                var row = new string[] { linka.Cislo_linky.ToString(), linka.Nazev_linky, linka.Delka_trasy.ToString(), linka.Predepsana_doba_trasy.ToString() };
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
