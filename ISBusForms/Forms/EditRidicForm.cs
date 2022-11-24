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
    public partial class EditRidicForm : Form
    {
        private Collection<Ridic> ridici;
        public EditRidicForm()
        {
            InitializeComponent();
        }

        private void EditRidicForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.ridici = RidicTable.SelectAll();
            foreach (var ridic in this.ridici)
            {
                var row = new string[] { ridic.Osobni_cislo.ToString(), ridic.Jmeno, ridic.Prijmeni, ridic.Bydliste, ridic.Telefon };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            Ridic newRidic = new Ridic
            {
                Osobni_cislo = Int32.Parse(textBoxCislo.Text),
                Jmeno = textBoxJmeno.Text,
                Prijmeni = textBoxPrijmeni.Text,
                Bydliste = textBoxBydliste.Text,
                Telefon = textBoxTelefon.Text
            };
            RidicTable.Insert(newRidic);
            this.EditRidicForm_Load(this, new EventArgs());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            Ridic updateRidic = new Ridic
            {
                Osobni_cislo = Int32.Parse(textBoxCislo.Text),
                Jmeno = textBoxJmeno.Text,
                Prijmeni = textBoxPrijmeni.Text,
                Bydliste = textBoxBydliste.Text,
                Telefon = textBoxTelefon.Text
            };
            RidicTable.Update(updateRidic);
            this.EditRidicForm_Load(this, new EventArgs());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                RidicTable.Delete(Int32.Parse(listView1.SelectedItems[0].Text));
            }
            else
            {
                return;
            }
            this.EditRidicForm_Load(this, new EventArgs());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                textBoxCislo.Text = selectedItem.SubItems[0].Text;
                textBoxJmeno.Text = selectedItem.SubItems[1].Text;
                textBoxPrijmeni.Text = selectedItem.SubItems[2].Text;
                textBoxBydliste.Text = selectedItem.SubItems[3].Text;
                textBoxTelefon.Text = selectedItem.SubItems[4].Text;
            }
            else
            {
                return;
            }
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

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(textBoxCislo.Text) || string.IsNullOrEmpty(textBoxJmeno.Text) || string.IsNullOrEmpty(textBoxPrijmeni.Text)
                || string.IsNullOrEmpty(textBoxBydliste.Text))
                return false;
            else
                return true;
        }
    }
}
