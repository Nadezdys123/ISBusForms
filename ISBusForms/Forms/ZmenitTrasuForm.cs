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
    public partial class ZmenitTrasuForm : Form
    {
        private Collection<Linka> linky;
        private Collection<Linka_Zastavka> spoj_info;
        private Collection<Linka_Ridic> spoje;
        private Collection<Zastavka> zasts;
        private List<Linka_Zastavka> result;
        public ZmenitTrasuForm()
        {
            InitializeComponent();
            this.linky = LinkaTable.SelectAll();
            this.spoj_info = Linka_ZastavkaTable.SelectAll();
            this.spoje = Linka_RidicTable.SelectAll();
            this.zasts = ZastavkaTable.SelectAll();
            this.result = new List<Linka_Zastavka>();
        }
        private void ZmenitTrasuForm_Load(object sender, EventArgs e)
        {
            foreach (var linka in this.linky)
            {
                comboLinka.Items.Add(linka.Cislo_linky);
            }
            foreach (var zast in this.zasts)
            {
                var row = new string[] { zast.Nazev };
                var i = new ListViewItem(row);
                listView2.Items.Add(i);
            }

            comboLinka.SelectedIndex = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboLinka_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.result.Clear();
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
                    this.result.Add(row);
            }
            this.result.Sort((x, y) => x.Poradi_zastavky.CompareTo(y.Poradi_zastavky));

            foreach (var x in this.result)
            {
                var row = new string[] { x.Poradi_zastavky.ToString(), x.Zastavka.Nazev };
                var i = new ListViewItem(row);
                listView1.Items.Add(i);
            }
        }

        private void AddAfterButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateZast())
            {
                MessageBox.Show("Vybraná zastávka se již nachází v seznamu.");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView2.SelectedItems.Count > 0)
            {
                int zast = 0;
                int poradi = Int32.Parse(listView1.SelectedItems[0].Text);
                foreach (var i in this.zasts)
                {
                    if (i.Nazev.Equals(listView2.SelectedItems[0].Text))
                        zast = i.Cislo_zastavky; 
                }

                var timeform = new TimeForm(Int32.Parse(comboLinka.SelectedItem.ToString()), 1, zast, poradi+1, listView1, comboLinka);
                timeform.Show();
            }
            else
            {
                MessageBox.Show("Vyberte řádek.");
                return;
            }
        }
        private void AddBeforeButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateZast())
            {
                MessageBox.Show("Vybraná zastávka se již nachází v seznamu.");
                return;
            }
            if (listView1.SelectedItems.Count > 0 && listView2.SelectedItems.Count > 0)
            {
                int zast = 0;
                int poradi = Int32.Parse(listView1.SelectedItems[0].Text);
                foreach (var i in this.zasts)
                {
                    if (i.Nazev.Equals(listView2.SelectedItems[0].Text))
                        zast = i.Cislo_zastavky;
                }

                var timeform = new TimeForm2(Int32.Parse(comboLinka.SelectedItem.ToString()), 1, zast, poradi, listView1, comboLinka);
                timeform.Show();
            }
            else
            {
                MessageBox.Show("Vyberte řádek.");
                return;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int zast = 0;
                foreach (var i in this.zasts)
                {
                    if (i.Nazev.Equals(listView1.SelectedItems[0].SubItems[1].Text))
                        zast = i.Cislo_zastavky;
                }
                LinkaTable.ZmenitTrasuLinky(Int32.Parse(comboLinka.SelectedItem.ToString()), 0, zast);
                this.RefreshList();
            }
            else
            {
                MessageBox.Show("Vyberte řádek.");
                return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private bool ValidateZast()
        {
            foreach(var x in this.result)
            {
                if (listView2.SelectedItems[0].Text.Equals(x.Zastavka.Nazev))
                    return false;
            }
            return true;   
        }

        private void AddFirst_Click(object sender, EventArgs e)
        {
            if (this.ValidateSpoj())
            {
                MessageBox.Show("Tato linka nemá přiřazený spoj. Vytvořte nový nebo upravte stávající.");
                return;
            }
            if (!this.ValidateFirst())
            {
                MessageBox.Show("Tato linka již má přiřazenou první zastávku.");
                return;
            }
            if (listView2.SelectedItems.Count > 0)
            {
                int zast = 0;
                int id_spoje = 0;
                foreach (var i in this.zasts)
                {
                    if (i.Nazev.Equals(listView2.SelectedItems[0].Text))
                        zast = i.Cislo_zastavky;
                }
                foreach (var x in this.spoje)
                {
                    if (Int32.Parse(comboLinka.SelectedItem.ToString()) == x.Linka.Cislo_linky)
                        id_spoje = x.Id_spoje;
                }
       
                var timeform = new TimeForm3(Int32.Parse(comboLinka.SelectedItem.ToString()), zast, id_spoje);
                timeform.Show();
            }
            else
            {
                MessageBox.Show("Vyberte řádek v druhém sloupci.");
                return;
            }
        }
        private bool ValidateSpoj()
        {
            foreach (var x in this.spoje)
            {
                if (Int32.Parse(comboLinka.SelectedItem.ToString()) == x.Linka.Cislo_linky)
                    return false;
            }
            return true;
        }
        private bool ValidateFirst()
        {
            foreach (var x in this.spoj_info)
            {
                if (Int32.Parse(comboLinka.SelectedItem.ToString()) == x.Linka.Cislo_linky)
                    return false;
            }
            return true;
        }
    }
}
