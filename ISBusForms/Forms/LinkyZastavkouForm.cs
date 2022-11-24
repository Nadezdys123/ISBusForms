﻿using ISBusForms.DatabaseORM;
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
    public partial class LinkyZastavkouForm : Form
    {
        private Collection<Zastavka> zast_list;
        private Collection<Linka> search_list;
        public LinkyZastavkouForm()
        {
            InitializeComponent();
            this.zast_list = ZastavkaTable.SelectAll();   
        }

        private void LinkyZastavkouForm_Load(object sender, EventArgs e)
        {
            foreach (var zast in this.zast_list)
            {
                comboZast.Items.Add(zast.Nazev);
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
                if(comboZast.SelectedItem.ToString().Equals(zast.Nazev))
                {
                    this.search_list = LinkaTable.LinkyProjizdejiciZastavkou(zast.Cislo_zastavky);
                    break;
                }
            }
           
           foreach(var linka in this.search_list)
            {
                var row = new string[] { linka.Cislo_linky.ToString(), linka.Nazev_linky, linka.Delka_trasy.ToString(), linka.Predepsana_doba_trasy.ToString() };
                var item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsFill()
        {
            if (comboZast.Text.Equals("Vyberte zastávku"))
                return false;
            else
                return true;
        }
    }
}
