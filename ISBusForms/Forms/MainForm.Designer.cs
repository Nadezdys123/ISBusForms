namespace ISBusForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StatistikaLabel = new System.Windows.Forms.LinkLabel();
            this.archivLabel = new System.Windows.Forms.LinkLabel();
            this.EvidenceSpojLabel = new System.Windows.Forms.LinkLabel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.PolohaLabel = new System.Windows.Forms.LinkLabel();
            this.LinkyZastavkouLabel = new System.Windows.Forms.LinkLabel();
            this.SpojMeziLabel = new System.Windows.Forms.LinkLabel();
            this.SearchSpojLabel = new System.Windows.Forms.LinkLabel();
            this.EditaceLabel = new System.Windows.Forms.Label();
            this.EvidenceLabel = new System.Windows.Forms.Label();
            this.EditSpojLabel = new System.Windows.Forms.LinkLabel();
            this.EditBusLabel = new System.Windows.Forms.LinkLabel();
            this.EditZastavkaLabel = new System.Windows.Forms.LinkLabel();
            this.EditRidicLabel = new System.Windows.Forms.LinkLabel();
            this.EditLinkaLabel = new System.Windows.Forms.LinkLabel();
            this.EvidenceBusLabel = new System.Windows.Forms.LinkLabel();
            this.EvidenceZastavkaLabel = new System.Windows.Forms.LinkLabel();
            this.EvidenceRidicLabel = new System.Windows.Forms.LinkLabel();
            this.EvidenceLinkaLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informační systém dopravního podniku Přerov";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StatistikaLabel);
            this.panel2.Controls.Add(this.archivLabel);
            this.panel2.Controls.Add(this.EvidenceSpojLabel);
            this.panel2.Controls.Add(this.SearchLabel);
            this.panel2.Controls.Add(this.PolohaLabel);
            this.panel2.Controls.Add(this.LinkyZastavkouLabel);
            this.panel2.Controls.Add(this.SpojMeziLabel);
            this.panel2.Controls.Add(this.SearchSpojLabel);
            this.panel2.Controls.Add(this.EditaceLabel);
            this.panel2.Controls.Add(this.EvidenceLabel);
            this.panel2.Controls.Add(this.EditSpojLabel);
            this.panel2.Controls.Add(this.EditBusLabel);
            this.panel2.Controls.Add(this.EditZastavkaLabel);
            this.panel2.Controls.Add(this.EditRidicLabel);
            this.panel2.Controls.Add(this.EditLinkaLabel);
            this.panel2.Controls.Add(this.EvidenceBusLabel);
            this.panel2.Controls.Add(this.EvidenceZastavkaLabel);
            this.panel2.Controls.Add(this.EvidenceRidicLabel);
            this.panel2.Controls.Add(this.EvidenceLinkaLabel);
            this.panel2.Location = new System.Drawing.Point(15, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 317);
            this.panel2.TabIndex = 2;
            // 
            // StatistikaLabel
            // 
            this.StatistikaLabel.AutoSize = true;
            this.StatistikaLabel.BackColor = System.Drawing.Color.Linen;
            this.StatistikaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatistikaLabel.LinkColor = System.Drawing.Color.Black;
            this.StatistikaLabel.Location = new System.Drawing.Point(89, 241);
            this.StatistikaLabel.Name = "StatistikaLabel";
            this.StatistikaLabel.Size = new System.Drawing.Size(111, 18);
            this.StatistikaLabel.TabIndex = 22;
            this.StatistikaLabel.TabStop = true;
            this.StatistikaLabel.Text = "Statistika linek";
            this.StatistikaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StatistikaLabel_LinkClicked);
            // 
            // archivLabel
            // 
            this.archivLabel.AutoSize = true;
            this.archivLabel.BackColor = System.Drawing.Color.Linen;
            this.archivLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.archivLabel.LinkColor = System.Drawing.Color.Black;
            this.archivLabel.Location = new System.Drawing.Point(88, 209);
            this.archivLabel.Name = "archivLabel";
            this.archivLabel.Size = new System.Drawing.Size(164, 18);
            this.archivLabel.TabIndex = 21;
            this.archivLabel.TabStop = true;
            this.archivLabel.Text = "Nahlédnutí do archivu";
            this.archivLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.archivLabel_LinkClicked);
            // 
            // EvidenceSpojLabel
            // 
            this.EvidenceSpojLabel.AutoSize = true;
            this.EvidenceSpojLabel.BackColor = System.Drawing.Color.Linen;
            this.EvidenceSpojLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceSpojLabel.LinkColor = System.Drawing.Color.Black;
            this.EvidenceSpojLabel.Location = new System.Drawing.Point(88, 176);
            this.EvidenceSpojLabel.Name = "EvidenceSpojLabel";
            this.EvidenceSpojLabel.Size = new System.Drawing.Size(107, 18);
            this.EvidenceSpojLabel.TabIndex = 20;
            this.EvidenceSpojLabel.TabStop = true;
            this.EvidenceSpojLabel.Text = "Seznam spojů";
            this.EvidenceSpojLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EvidenceSpojLabel_LinkClicked);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Lime;
            this.SearchLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchLabel.Location = new System.Drawing.Point(291, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(137, 24);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Vyhledat spoj";
            // 
            // PolohaLabel
            // 
            this.PolohaLabel.AutoSize = true;
            this.PolohaLabel.BackColor = System.Drawing.Color.Linen;
            this.PolohaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PolohaLabel.LinkColor = System.Drawing.Color.Black;
            this.PolohaLabel.Location = new System.Drawing.Point(292, 143);
            this.PolohaLabel.Name = "PolohaLabel";
            this.PolohaLabel.Size = new System.Drawing.Size(100, 18);
            this.PolohaLabel.TabIndex = 18;
            this.PolohaLabel.TabStop = true;
            this.PolohaLabel.Text = "Poloha spoje";
            this.PolohaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PolohaLabel_LinkClicked);
            // 
            // LinkyZastavkouLabel
            // 
            this.LinkyZastavkouLabel.AutoSize = true;
            this.LinkyZastavkouLabel.BackColor = System.Drawing.Color.Linen;
            this.LinkyZastavkouLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LinkyZastavkouLabel.LinkColor = System.Drawing.Color.Black;
            this.LinkyZastavkouLabel.Location = new System.Drawing.Point(292, 110);
            this.LinkyZastavkouLabel.Name = "LinkyZastavkouLabel";
            this.LinkyZastavkouLabel.Size = new System.Drawing.Size(203, 18);
            this.LinkyZastavkouLabel.TabIndex = 17;
            this.LinkyZastavkouLabel.TabStop = true;
            this.LinkyZastavkouLabel.Text = "Linky projíždějící zastávkou";
            this.LinkyZastavkouLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkyZastavkouLabel_LinkClicked);
            // 
            // SpojMeziLabel
            // 
            this.SpojMeziLabel.AutoSize = true;
            this.SpojMeziLabel.BackColor = System.Drawing.Color.Linen;
            this.SpojMeziLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SpojMeziLabel.LinkColor = System.Drawing.Color.Black;
            this.SpojMeziLabel.Location = new System.Drawing.Point(292, 78);
            this.SpojMeziLabel.Name = "SpojMeziLabel";
            this.SpojMeziLabel.Size = new System.Drawing.Size(159, 18);
            this.SpojMeziLabel.TabIndex = 16;
            this.SpojMeziLabel.TabStop = true;
            this.SpojMeziLabel.Text = "Spoj mezi zastávkami";
            this.SpojMeziLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SpojMeziLabel_LinkClicked);
            // 
            // SearchSpojLabel
            // 
            this.SearchSpojLabel.AutoSize = true;
            this.SearchSpojLabel.BackColor = System.Drawing.Color.Linen;
            this.SearchSpojLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchSpojLabel.LinkColor = System.Drawing.Color.Black;
            this.SearchSpojLabel.Location = new System.Drawing.Point(292, 47);
            this.SearchSpojLabel.Name = "SearchSpojLabel";
            this.SearchSpojLabel.Size = new System.Drawing.Size(187, 18);
            this.SearchSpojLabel.TabIndex = 15;
            this.SearchSpojLabel.TabStop = true;
            this.SearchSpojLabel.Text = "Vyhledat spoj ze zastávky";
            this.SearchSpojLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchSpojLabel_LinkClicked);
            // 
            // EditaceLabel
            // 
            this.EditaceLabel.AutoSize = true;
            this.EditaceLabel.BackColor = System.Drawing.Color.Lime;
            this.EditaceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditaceLabel.Location = new System.Drawing.Point(548, 10);
            this.EditaceLabel.Name = "EditaceLabel";
            this.EditaceLabel.Size = new System.Drawing.Size(80, 24);
            this.EditaceLabel.TabIndex = 14;
            this.EditaceLabel.Text = "Editace";
            // 
            // EvidenceLabel
            // 
            this.EvidenceLabel.AutoSize = true;
            this.EvidenceLabel.BackColor = System.Drawing.Color.Lime;
            this.EvidenceLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceLabel.Location = new System.Drawing.Point(87, 10);
            this.EvidenceLabel.Name = "EvidenceLabel";
            this.EvidenceLabel.Size = new System.Drawing.Size(96, 24);
            this.EvidenceLabel.TabIndex = 13;
            this.EvidenceLabel.Text = "Evidence";
            // 
            // EditSpojLabel
            // 
            this.EditSpojLabel.AutoSize = true;
            this.EditSpojLabel.BackColor = System.Drawing.Color.Linen;
            this.EditSpojLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditSpojLabel.LinkColor = System.Drawing.Color.Black;
            this.EditSpojLabel.Location = new System.Drawing.Point(549, 176);
            this.EditSpojLabel.Name = "EditSpojLabel";
            this.EditSpojLabel.Size = new System.Drawing.Size(104, 18);
            this.EditSpojLabel.TabIndex = 11;
            this.EditSpojLabel.TabStop = true;
            this.EditSpojLabel.Text = "Editace spojů";
            this.EditSpojLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditSpojLabel_LinkClicked);
            // 
            // EditBusLabel
            // 
            this.EditBusLabel.AutoSize = true;
            this.EditBusLabel.BackColor = System.Drawing.Color.Linen;
            this.EditBusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditBusLabel.LinkColor = System.Drawing.Color.Black;
            this.EditBusLabel.Location = new System.Drawing.Point(549, 143);
            this.EditBusLabel.Name = "EditBusLabel";
            this.EditBusLabel.Size = new System.Drawing.Size(131, 18);
            this.EditBusLabel.TabIndex = 10;
            this.EditBusLabel.TabStop = true;
            this.EditBusLabel.Text = "Editace autobusů";
            this.EditBusLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditBusLabel_LinkClicked);
            // 
            // EditZastavkaLabel
            // 
            this.EditZastavkaLabel.AutoSize = true;
            this.EditZastavkaLabel.BackColor = System.Drawing.Color.Linen;
            this.EditZastavkaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditZastavkaLabel.LinkColor = System.Drawing.Color.Black;
            this.EditZastavkaLabel.Location = new System.Drawing.Point(549, 110);
            this.EditZastavkaLabel.Name = "EditZastavkaLabel";
            this.EditZastavkaLabel.Size = new System.Drawing.Size(128, 18);
            this.EditZastavkaLabel.TabIndex = 9;
            this.EditZastavkaLabel.TabStop = true;
            this.EditZastavkaLabel.Text = "Editace zastávek";
            this.EditZastavkaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditZastavkaLabel_LinkClicked);
            // 
            // EditRidicLabel
            // 
            this.EditRidicLabel.AutoSize = true;
            this.EditRidicLabel.BackColor = System.Drawing.Color.Linen;
            this.EditRidicLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditRidicLabel.LinkColor = System.Drawing.Color.Black;
            this.EditRidicLabel.Location = new System.Drawing.Point(549, 78);
            this.EditRidicLabel.Name = "EditRidicLabel";
            this.EditRidicLabel.Size = new System.Drawing.Size(105, 18);
            this.EditRidicLabel.TabIndex = 8;
            this.EditRidicLabel.TabStop = true;
            this.EditRidicLabel.Text = "Editace řidičů";
            this.EditRidicLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditRidicLabel_LinkClicked);
            // 
            // EditLinkaLabel
            // 
            this.EditLinkaLabel.AutoSize = true;
            this.EditLinkaLabel.BackColor = System.Drawing.Color.Linen;
            this.EditLinkaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditLinkaLabel.LinkColor = System.Drawing.Color.Black;
            this.EditLinkaLabel.Location = new System.Drawing.Point(549, 47);
            this.EditLinkaLabel.Name = "EditLinkaLabel";
            this.EditLinkaLabel.Size = new System.Drawing.Size(99, 18);
            this.EditLinkaLabel.TabIndex = 7;
            this.EditLinkaLabel.TabStop = true;
            this.EditLinkaLabel.Text = "Editace linek";
            this.EditLinkaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditLinkaLabel_LinkClicked);
            // 
            // EvidenceBusLabel
            // 
            this.EvidenceBusLabel.AutoSize = true;
            this.EvidenceBusLabel.BackColor = System.Drawing.Color.Linen;
            this.EvidenceBusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceBusLabel.LinkColor = System.Drawing.Color.Black;
            this.EvidenceBusLabel.Location = new System.Drawing.Point(88, 143);
            this.EvidenceBusLabel.Name = "EvidenceBusLabel";
            this.EvidenceBusLabel.Size = new System.Drawing.Size(134, 18);
            this.EvidenceBusLabel.TabIndex = 6;
            this.EvidenceBusLabel.TabStop = true;
            this.EvidenceBusLabel.Text = "Seznam autobusů";
            this.EvidenceBusLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EvidenceBusLabel_LinkClicked);
            // 
            // EvidenceZastavkaLabel
            // 
            this.EvidenceZastavkaLabel.AutoSize = true;
            this.EvidenceZastavkaLabel.BackColor = System.Drawing.Color.Linen;
            this.EvidenceZastavkaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceZastavkaLabel.LinkColor = System.Drawing.Color.Black;
            this.EvidenceZastavkaLabel.Location = new System.Drawing.Point(88, 110);
            this.EvidenceZastavkaLabel.Name = "EvidenceZastavkaLabel";
            this.EvidenceZastavkaLabel.Size = new System.Drawing.Size(131, 18);
            this.EvidenceZastavkaLabel.TabIndex = 5;
            this.EvidenceZastavkaLabel.TabStop = true;
            this.EvidenceZastavkaLabel.Text = "Seznam zastávek";
            this.EvidenceZastavkaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EvidenceZastavkaLabel_LinkClicked);
            // 
            // EvidenceRidicLabel
            // 
            this.EvidenceRidicLabel.AutoSize = true;
            this.EvidenceRidicLabel.BackColor = System.Drawing.Color.Linen;
            this.EvidenceRidicLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceRidicLabel.LinkColor = System.Drawing.Color.Black;
            this.EvidenceRidicLabel.Location = new System.Drawing.Point(88, 78);
            this.EvidenceRidicLabel.Name = "EvidenceRidicLabel";
            this.EvidenceRidicLabel.Size = new System.Drawing.Size(108, 18);
            this.EvidenceRidicLabel.TabIndex = 4;
            this.EvidenceRidicLabel.TabStop = true;
            this.EvidenceRidicLabel.Text = "Seznam řidičů";
            this.EvidenceRidicLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EvidenceRidicLabel_LinkClicked);
            // 
            // EvidenceLinkaLabel
            // 
            this.EvidenceLinkaLabel.AutoSize = true;
            this.EvidenceLinkaLabel.BackColor = System.Drawing.Color.Linen;
            this.EvidenceLinkaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EvidenceLinkaLabel.LinkColor = System.Drawing.Color.Black;
            this.EvidenceLinkaLabel.Location = new System.Drawing.Point(88, 47);
            this.EvidenceLinkaLabel.Name = "EvidenceLinkaLabel";
            this.EvidenceLinkaLabel.Size = new System.Drawing.Size(102, 18);
            this.EvidenceLinkaLabel.TabIndex = 3;
            this.EvidenceLinkaLabel.TabStop = true;
            this.EvidenceLinkaLabel.Text = "Seznam linek";
            this.EvidenceLinkaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EvidenceLinkaLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.Text = "IS dopravního podniku Přerov";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel EditSpojLabel;
        private System.Windows.Forms.LinkLabel EditBusLabel;
        private System.Windows.Forms.LinkLabel EditZastavkaLabel;
        private System.Windows.Forms.LinkLabel EditRidicLabel;
        private System.Windows.Forms.LinkLabel EditLinkaLabel;
        private System.Windows.Forms.LinkLabel EvidenceBusLabel;
        private System.Windows.Forms.LinkLabel EvidenceZastavkaLabel;
        private System.Windows.Forms.LinkLabel EvidenceRidicLabel;
        private System.Windows.Forms.LinkLabel EvidenceLinkaLabel;
        private System.Windows.Forms.Label EditaceLabel;
        private System.Windows.Forms.Label EvidenceLabel;
        private System.Windows.Forms.LinkLabel PolohaLabel;
        private System.Windows.Forms.LinkLabel LinkyZastavkouLabel;
        private System.Windows.Forms.LinkLabel SpojMeziLabel;
        private System.Windows.Forms.LinkLabel SearchSpojLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.LinkLabel EvidenceSpojLabel;
        private System.Windows.Forms.LinkLabel archivLabel;
        private System.Windows.Forms.LinkLabel StatistikaLabel;
    }
}