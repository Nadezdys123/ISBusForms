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
    public partial class ListRidicForm : Form
    {
        private Collection<Ridic> ridici;
        public ListRidicForm()
        {
            InitializeComponent();
            this.ridici = RidicTable.SelectAll();
        }

        private void ListRidicForm_Load(object sender, EventArgs e)
        {
            foreach(var ridic in this.ridici)
            {
                var row = new string[] { ridic.Osobni_cislo.ToString(), ridic.Jmeno, ridic.Prijmeni, ridic.Bydliste, ridic.Telefon };
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
