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
    public partial class EditBusForm : Form
    {
        private Collection<Autobus> busses;
        public EditBusForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                textBoxVIN.Text = selectedItem.SubItems[0].Text;
                textBoxSPZ.Text = selectedItem.SubItems[1].Text;
                textBoxModel.Text = selectedItem.SubItems[2].Text;
                textBoxVyrobce.Text = selectedItem.SubItems[3].Text;
                textBoxPocet.Text = selectedItem.SubItems[4].Text;
            }
            else
            {
                return;
            }
        }

        private void EditBusForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.busses = AutobusTable.SelectAll();
            foreach (var bus in this.busses)
            {
                var row = new string[] { bus.VIN, bus.SPZ, bus.Model, bus.Vyrobce, bus.Pocet_mist.ToString() };
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
                
            Autobus newBus = new Autobus
            {
                VIN = textBoxVIN.Text,
                SPZ = textBoxSPZ.Text,
                Model = textBoxModel.Text,
                Vyrobce = textBoxVyrobce.Text,
                Pocet_mist = Int32.Parse(textBoxPocet.Text)
            };
            AutobusTable.Insert(newBus);
            this.EditBusForm_Load(this, new EventArgs());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!this.IsFill())
            {
                MessageBox.Show("Vyplnte všechna povinná pole");
                return;
            }

            Autobus updateBus = new Autobus
            {
                VIN = textBoxVIN.Text,
                SPZ = textBoxSPZ.Text,
                Model = textBoxModel.Text,
                Vyrobce = textBoxVyrobce.Text,
                Pocet_mist = Int32.Parse(textBoxPocet.Text)
            };
            AutobusTable.Update(updateBus);
            this.EditBusForm_Load(this, new EventArgs());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                AutobusTable.Delete(listView1.SelectedItems[0].Text);
            }
            else
            {
                return;
            }
            this.EditBusForm_Load(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPocet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(textBoxVIN.Text) || string.IsNullOrEmpty(textBoxSPZ.Text) || string.IsNullOrEmpty(textBoxModel.Text)
                || string.IsNullOrEmpty(textBoxVyrobce.Text) || string.IsNullOrEmpty(textBoxPocet.Text))
                return false;
            else
                return true;
        }
    }
}
