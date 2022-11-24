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
    public partial class ListZastForm : Form
    {
        private Collection<Zastavka> zasts;
        public ListZastForm()
        {
            InitializeComponent();
            this.zasts = ZastavkaTable.SelectAll();
        }

        private void ListZastForm_Load(object sender, EventArgs e)
        {
            foreach (var zast in this.zasts)
            {
                var row = new string[] { zast.Cislo_zastavky.ToString(), zast.Nazev, zast.Ulice, zast.Tarifni_zona.ToString() };
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
