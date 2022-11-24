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

namespace ISBusForms
{
    public partial class SearchSpojForm : Form
    {
        private Collection<Zastavka> zast_list;
        private Collection<SpojZjednoduseny> search_list;
        private Collection<Linka_Zastavka> spoj_info;
        public SearchSpojForm()
        {
            InitializeComponent();
            this.zast_list = ZastavkaTable.SelectAll();
            this.spoj_info = Linka_ZastavkaTable.SelectAll();
        }
        private void SearchSpojForm_Load(object sender, EventArgs e)
        {
            foreach(var zast in this.zast_list)
            {
                comboFrom.Items.Add(zast.Nazev);
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            var result = new List<Linka_Zastavka>();
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                foreach (var row in this.spoj_info)
                {
                    if (Int32.Parse(selectedItem.Text) == row.Spoj.Id_spoje && Int32.Parse(selectedItem.SubItems[1].Text) == row.Linka.Cislo_linky)
                        result.Add(row);
                }
                result.Sort((x, y) => x.Poradi_zastavky.CompareTo(y.Poradi_zastavky));
                foreach (var x in result)
                {
                    var row = new string[] { x.Zastavka.Nazev, x.Relativni_cas_odjezdu.TimeOfDay.ToString() };
                    var i = new ListViewItem(row);
                    listView2.Items.Add(i);
                }
            }
            else
            {
                return;
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
           foreach(var zast in zast_list)
            {
                if(comboFrom.SelectedItem.ToString().Equals(zast.Nazev))
                {
                    string first = timeBox.Text.Substring(0, 2);
                    string last = timeBox.Text.Substring(2, 2);
                    this.search_list = Linka_RidicTable.Prvnich10Spoju(zast.Cislo_zastavky, new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, Int32.Parse(first), Int32.Parse(last), 0));
                    break;
                }
            }
           
           foreach(var spoj in this.search_list)
            {
                var row = new string[] { spoj.Id_spoje.ToString(), spoj.Linka.Cislo_linky.ToString(), spoj.Linka.Nazev_linky, spoj.Cas_odjezdu.TimeOfDay.ToString() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
        private bool IsFill()
        {
            if (string.IsNullOrEmpty(timeBox.Text) || comboFrom.Text.Equals("Vyberte zastávku"))
                return false;
            else
                return true;
        }
    }
}
