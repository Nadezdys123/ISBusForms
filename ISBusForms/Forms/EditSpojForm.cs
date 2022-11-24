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
    public partial class EditSpojForm : Form
    {
        private Collection<Linka_Ridic> spoje;
        private Collection<Linka> linky;
        private Collection<Ridic> ridici;
        private Collection<Autobus> busses;
        public EditSpojForm()
        {
            InitializeComponent();
            this.linky = LinkaTable.SelectAll();
            this.ridici = RidicTable.SelectAll();
            this.busses = AutobusTable.SelectAll();
        }
        private void EditSpojForm_Load(object sender, EventArgs e)
        {
            foreach (var linka in this.linky)
                comboLinka.Items.Add(linka.Cislo_linky);
            foreach (var ridic in this.ridici)
                comboRidic.Items.Add(ridic.Jmeno + " " + ridic.Prijmeni);
            foreach (var bus in this.busses)
                comboBus.Items.Add(bus.VIN);

            listView1.Items.Clear();
            this.spoje = Linka_RidicTable.SelectAll();
            foreach (var spoj in this.spoje)
            {
                var row = new string[] { spoj.Id_spoje.ToString(), spoj.Cas_odjezdu.ToString(), spoj.Linka.Cislo_linky.ToString(), spoj.Bus.VIN, spoj.Ridic.Osobni_cislo.ToString(), spoj.Stav_spoje };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for(int i = 0; i < this.linky.Count; i++)
                {
                    if (this.linky[i].Cislo_linky == Int32.Parse(listView1.SelectedItems[0].SubItems[2].Text))
                    {
                        comboLinka.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < this.busses.Count; i++)
                {
                    if (this.busses[i].VIN.Equals(listView1.SelectedItems[0].SubItems[3].Text))
                    {
                        comboBus.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < this.ridici.Count; i++)
                {
                    if (this.ridici[i].Osobni_cislo == Int32.Parse(listView1.SelectedItems[0].SubItems[4].Text))
                    {
                        comboRidic.SelectedIndex = i;
                        break;
                    }
                }

                var selectedItem = listView1.SelectedItems[0];
                textBoxID.Text = selectedItem.SubItems[0].Text;
                textBoxStav.Text = selectedItem.SubItems[5].Text;
            }
            else
            {
                return;
            }
        }
        private void ZmenaRidiceButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Linka_RidicTable.ZmenaRidice(Int32.Parse(listView1.SelectedItems[0].Text));
                MessageBox.Show("Změna řidiče byla úspěšná.");
            }
            else
            {
                MessageBox.Show("Vyberte řádek v seznamu.");
                return;
            }
            this.EditSpojForm_Load(this, new EventArgs());
        }

        private void ZmenitBusButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Linka_RidicTable.ZmenaAutobusu(Int32.Parse(listView1.SelectedItems[0].Text));
                MessageBox.Show("Změna autobusu byla úspěšná.");
            }
            else
            {
                MessageBox.Show("Vyberte řádek v seznamu.");
                return;
            }
            this.EditSpojForm_Load(this, new EventArgs());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            string first = timeBox.Text.Substring(0, 2);
            string last = timeBox.Text.Substring(2, 2);
            Linka newLinka = new Linka();
            Ridic newRidic = new Ridic();
            Autobus newBus = new Autobus();

            foreach(var linka in this.linky)
            {
                if(linka.Cislo_linky == Int32.Parse(comboLinka.SelectedItem.ToString()))
                {
                    newLinka = linka;
                    break;
                }
            }
            foreach (var bus in this.busses)
            {
                if (bus.VIN.Equals(comboBus.SelectedItem.ToString()))
                {
                    newBus = bus;
                    break;
                }
            }
            foreach (var ridic in this.ridici)
            {
                if ((ridic.Jmeno + " " + ridic.Prijmeni).Equals(comboRidic.SelectedItem.ToString()))
                {
                    newRidic = ridic;
                    break;
                }
            }

            Linka_Ridic newSpoj = new Linka_Ridic
            {
                Id_spoje = Int32.Parse(textBoxID.Text),
                Cas_odjezdu = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, Int32.Parse(first), Int32.Parse(last), 0),
                Linka = newLinka,
                Bus = newBus,
                Ridic = newRidic,
                Stav_spoje = textBoxStav.Text
            };
            Linka_RidicTable.Insert(newSpoj);
            this.EditSpojForm_Load(this, new EventArgs());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }
            string first = timeBox.Text.Substring(0, 2);
            string last = timeBox.Text.Substring(2, 2);
            Linka newLinka = new Linka();
            Ridic newRidic = new Ridic();
            Autobus newBus = new Autobus();

            foreach (var linka in this.linky)
            {
                if (linka.Cislo_linky == Int32.Parse(comboLinka.SelectedItem.ToString()))
                {
                    newLinka = linka;
                    break;
                }
            }
            foreach (var bus in this.busses)
            {
                if (bus.VIN.Equals(comboBus.SelectedItem.ToString()))
                {
                    newBus = bus;
                    break;
                }
            }
            foreach (var ridic in this.ridici)
            {
                if ((ridic.Jmeno + " " + ridic.Prijmeni).Equals(comboRidic.SelectedItem.ToString()))
                {
                    newRidic = ridic;
                    break;
                }
            }

            Linka_Ridic newSpoj = new Linka_Ridic
            {
                Id_spoje = Int32.Parse(textBoxID.Text),
                Cas_odjezdu = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, Int32.Parse(first), Int32.Parse(last), 0),
                Linka = newLinka,
                Bus = newBus,
                Ridic = newRidic,
                Stav_spoje = textBoxStav.Text
            };
            Linka_RidicTable.Update(newSpoj);
            this.EditSpojForm_Load(this, new EventArgs());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Linka_RidicTable.Delete(Int32.Parse(listView1.SelectedItems[0].Text));
            }
            else
            {
                return;
            }
            this.EditSpojForm_Load(this, new EventArgs());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBoxStav_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch!='U' && ch != 'N' && ch != 'P')
                e.Handled = true;
        }

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(textBoxID.Text) || string.IsNullOrEmpty(timeBox.Text) || string.IsNullOrEmpty(textBoxStav.Text)
                || string.IsNullOrEmpty(comboLinka.Text) || string.IsNullOrEmpty(comboBus.Text) || string.IsNullOrEmpty(comboRidic.Text))
                return false;
            else
                return true;
        }
    }
}
