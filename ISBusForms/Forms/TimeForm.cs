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
    public partial class TimeForm : Form
    {
        private int cislo;
        private int volba;
        private int zast;
        private int poradi;
        private Collection<Linka_Zastavka> spoj_info;
        private Collection<Zastavka> zasts;
        private ListView listView1;
        private ComboBox comboLinka;
        public TimeForm(int cislo, int volba, int zast, int poradi, ListView list, ComboBox combo)
        {
            InitializeComponent();
            this.cislo = cislo;
            this.volba = volba;
            this.zast = zast;
            this.poradi = poradi;
            this.listView1 = list;
            this.comboLinka = combo;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            string first = timeBox.Text.Substring(0, 2);
            string last = timeBox.Text.Substring(2, 2);
            LinkaTable.ZmenitTrasuLinky(this.cislo, this.volba, this.zast, this.poradi, new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, Int32.Parse(first), Int32.Parse(last), 0));
            this.RefreshList();
            this.Close();
        }

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(timeBox.Text))
                return false;
            else
                return true;
        }
        private void RefreshList()
        {
            this.spoj_info = Linka_ZastavkaTable.SelectAll();
            this.zasts = ZastavkaTable.SelectAll();
            listView1.Items.Clear();
            var result = new List<Linka_Zastavka>();
            int id_spoje = 0;
            foreach (var row in this.spoj_info)
            {
                if (row.Linka.Cislo_linky == Int32.Parse(comboLinka.SelectedItem.ToString()))
                {
                    id_spoje = row.Spoj.Id_spoje;
                    break;
                }
            }
            foreach (var row in this.spoj_info)
            {
                if (row.Linka.Cislo_linky == Int32.Parse(comboLinka.SelectedItem.ToString()) && row.Spoj.Id_spoje == id_spoje)
                    result.Add(row);
            }
            result.Sort((x, y) => x.Poradi_zastavky.CompareTo(y.Poradi_zastavky));

            foreach (var x in result)
            {
                var row = new string[] { x.Poradi_zastavky.ToString(), x.Zastavka.Nazev };
                var i = new ListViewItem(row);
                listView1.Items.Add(i);
            }
        }
        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
