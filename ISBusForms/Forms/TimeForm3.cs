using ISBusForms.DatabaseORM;
using ISBusForms.DatabaseORM.slq_database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBusForms.Forms
{
    public partial class TimeForm3 : Form
    {
        private int linka;
        private int zast;
        private int spoj;
        public TimeForm3(int cislo, int zast, int spoj)
        {
            InitializeComponent();
            this.linka = cislo;
            this.spoj = spoj;
            this.zast = zast;
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
            Linka_Zastavka row = new Linka_Zastavka
            {
                Poradi_zastavky = 1,
                Relativni_cas_odjezdu = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, Int32.Parse(first), Int32.Parse(last), 0),
                Linka = LinkaTable.SelectOne(this.linka),
                Zastavka = ZastavkaTable.SelectOne(this.zast),
                Spoj = Linka_RidicTable.SelectOne(this.spoj),
                Stav_zastavky = "0"
            };
            Linka_ZastavkaTable.Insert(row);
            this.Close();
        }

        private bool IsFill()
        {
            if (string.IsNullOrEmpty(timeBox.Text))
                return false;
            else
                return true;
        }

        private void timeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
