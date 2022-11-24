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
    public partial class ListBusForm : Form
    {
        private Collection<Autobus> busses;
        public ListBusForm()
        {
            InitializeComponent();
            this.busses = AutobusTable.SelectAll();
        }

        private void ListBusForm_Load(object sender, EventArgs e)
        {
            foreach (var bus in this.busses)
            {
                var row = new string[] { bus.VIN, bus.SPZ, bus.Model, bus.Vyrobce, bus.Pocet_mist.ToString() };
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
