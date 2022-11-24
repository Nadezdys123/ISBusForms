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
    public partial class EditZastForm : Form
    {
        private Collection<Zastavka> zasts;
        public EditZastForm()
        {
            InitializeComponent();
        }

        private void EditZastForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.zasts = ZastavkaTable.SelectAll();
            foreach (var zast in this.zasts)
            {
                var row = new string[] { zast.Cislo_zastavky.ToString(), zast.Nazev, zast.Ulice, zast.Tarifni_zona.ToString() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                textBoxCislo.Text = selectedItem.SubItems[0].Text;
                textBoxNazev.Text = selectedItem.SubItems[1].Text;
                textBoxUlice.Text = selectedItem.SubItems[2].Text;
                textBoxZona.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                return;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            Zastavka newZast = new Zastavka
            {
                Cislo_zastavky = Int32.Parse(textBoxCislo.Text),
                Nazev = textBoxNazev.Text,
                Ulice = textBoxUlice.Text,
                Tarifni_zona = Int32.Parse(textBoxZona.Text)
            };
            ZastavkaTable.Insert(newZast);
            this.EditZastForm_Load(this, new EventArgs());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            Zastavka updateZast = new Zastavka
            {
                Cislo_zastavky = Int32.Parse(textBoxCislo.Text),
                Nazev = textBoxNazev.Text,
                Ulice = textBoxUlice.Text,
                Tarifni_zona = Int32.Parse(textBoxZona.Text)
            };
            ZastavkaTable.Update(updateZast);
            this.EditZastForm_Load(this, new EventArgs());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ZastavkaTable.Delete(Int32.Parse(listView1.SelectedItems[0].Text));
            }
            else
            {
                return;
            }
            this.EditZastForm_Load(this, new EventArgs());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCislo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBoxZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(textBoxCislo.Text) || string.IsNullOrEmpty(textBoxNazev.Text) || string.IsNullOrEmpty(textBoxZona.Text))
                return false;
            else
                return true;
        }
    }
}
