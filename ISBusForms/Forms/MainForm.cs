using ISBusForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISBusForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SearchSpojLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var searchform = new SearchSpojForm();
            searchform.Show();
        }

        private void EvidenceLinkaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListLinkaForm();
            listform.Show();
        }

        private void EvidenceRidicLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListRidicForm();
            listform.Show();
        }

        private void EvidenceZastavkaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListZastForm();
            listform.Show();
        }

        private void EvidenceBusLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListBusForm();
            listform.Show();
        }

        private void SpojMeziLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var searchform = new SearchSpojForm2();
            searchform.Show();
        }

        private void EvidenceSpojLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListSpojForm();
            listform.Show();
        }

        private void LinkyZastavkouLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var searchform = new LinkyZastavkouForm();
            searchform.Show();
        }

        private void PolohaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var searchform = new PolohaSpojeForm();
            searchform.Show();
        }

        private void EditLinkaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editform = new EditLinkaForm();
            editform.Show();
        }

        private void EditRidicLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editform = new EditRidicForm();
            editform.Show();
        }

        private void EditZastavkaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editform = new EditZastForm();
            editform.Show();
        }

        private void EditBusLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editform = new EditBusForm();
            editform.Show();
        }

        private void EditSpojLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editform = new EditSpojForm();
            editform.Show();
        }

        private void archivLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new ListArchivForm();
            listform.Show();
        }

        private void StatistikaLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var listform = new StatistikaForm();
            listform.Show();
        }
    }
}
