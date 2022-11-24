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
    public partial class EditLinkaForm : Form
    {
        private Collection<Linka> linky;
        public EditLinkaForm()
        {
            InitializeComponent();
        }

        private void EditLinkaForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.linky = LinkaTable.SelectAll();
            foreach (var linka in this.linky)
            {
                var row = new string[] { linka.Cislo_linky.ToString(), linka.Nazev_linky, linka.Delka_trasy.ToString(), linka.Predepsana_doba_trasy.ToString() };
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

            int? delka, doba;
            if (String.IsNullOrEmpty(textBoxDelka.Text))
                delka = null;
            else
                delka = Int32.Parse(textBoxDelka.Text);

            if (String.IsNullOrEmpty(textBoxDoba.Text))
                doba = null;
            else
                doba = Int32.Parse(textBoxDoba.Text);

            Linka newlinka = new Linka
            {
                Cislo_linky = Int32.Parse(textBoxCislo.Text),
                Nazev_linky = textBoxNazev.Text,
                Delka_trasy = delka,
                Predepsana_doba_trasy = doba
            };
            LinkaTable.Insert(newlinka);
            this.EditLinkaForm_Load(this, new EventArgs());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }

            int? delka, doba;
            if (String.IsNullOrEmpty(textBoxDelka.Text))
                delka = null;
            else
                delka = Int32.Parse(textBoxDelka.Text);

            if (String.IsNullOrEmpty(textBoxDoba.Text))
                doba = null;
            else
                doba = Int32.Parse(textBoxDoba.Text);

            Linka updateLinka = new Linka
            {
                Cislo_linky = Int32.Parse(textBoxCislo.Text),
                Nazev_linky = textBoxNazev.Text,
                Delka_trasy = delka,
                Predepsana_doba_trasy = doba
            };
            LinkaTable.Update(updateLinka);
            this.EditLinkaForm_Load(this, new EventArgs());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                LinkaTable.Delete(Int32.Parse(listView1.SelectedItems[0].Text));  
            }
            else
            {
                return;
            }
            this.EditLinkaForm_Load(this, new EventArgs());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                textBoxCislo.Text = selectedItem.SubItems[0].Text;
                textBoxNazev.Text = selectedItem.SubItems[1].Text;
                textBoxDelka.Text = selectedItem.SubItems[2].Text;
                textBoxDoba.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                return;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            var changeform = new ZmenitTrasuForm();
            changeform.Show();
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
            if (string.IsNullOrEmpty(textBoxCislo.Text) || string.IsNullOrEmpty(textBoxNazev.Text))
                return false;
            else
                return true;
        }

        private void textBoxDelka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBoxDoba_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
