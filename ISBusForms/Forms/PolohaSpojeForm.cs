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
    public partial class PolohaSpojeForm : Form
    {
        private Collection<Linka_Ridic> spoj_list;
        private Zastavka pristi_zast;
        public PolohaSpojeForm()
        {
            InitializeComponent();
            this.spoj_list = Linka_RidicTable.SelectAll();
        }

        private void PolohaSpojeForm_Load(object sender, EventArgs e)
        {
            foreach (var spoj in this.spoj_list)
            {
                comboSpoj.Items.Add(spoj.Id_spoje + " - " +spoj.Linka.Nazev_linky);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            listView1.Items.Clear();
            foreach (var spoj in spoj_list)
            {
                if (comboSpoj.SelectedItem.ToString().Equals(spoj.Id_spoje + " - " + spoj.Linka.Nazev_linky))
                {
                    this.pristi_zast = ZastavkaTable.PristiZastavka(spoj.Id_spoje);
                    break;
                }
            }
            var row = new string[] { this.pristi_zast.Cislo_zastavky.ToString(), this.pristi_zast.Nazev, this.pristi_zast.Ulice, this.pristi_zast.Tarifni_zona.ToString() };
            var item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsFill()
        {
            if (comboSpoj.Text.Equals("Vyberte spoj"))
                return false;
            else
                return true;
        }
    }
}
