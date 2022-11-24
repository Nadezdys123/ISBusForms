namespace ISBusForms.Forms
{
    partial class EditSpojForm
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
            this.comboBus = new System.Windows.Forms.ComboBox();
            this.comboRidic = new System.Windows.Forms.ComboBox();
            this.comboLinka = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timeBox = new System.Windows.Forms.MaskedTextBox();
            this.ZmenitBusButton = new System.Windows.Forms.Button();
            this.ZmenaRidiceButton = new System.Windows.Forms.Button();
            this.textBoxStav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBus);
            this.panel1.Controls.Add(this.comboRidic);
            this.panel1.Controls.Add(this.comboLinka);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.timeBox);
            this.panel1.Controls.Add(this.ZmenitBusButton);
            this.panel1.Controls.Add(this.ZmenaRidiceButton);
            this.panel1.Controls.Add(this.textBoxStav);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 132);
            this.panel1.TabIndex = 54;
            // 
            // comboBus
            // 
            this.comboBus.FormattingEnabled = true;
            this.comboBus.Location = new System.Drawing.Point(297, 55);
            this.comboBus.Name = "comboBus";
            this.comboBus.Size = new System.Drawing.Size(121, 24);
            this.comboBus.TabIndex = 71;
            // 
            // comboRidic
            // 
            this.comboRidic.FormattingEnabled = true;
            this.comboRidic.Location = new System.Drawing.Point(70, 91);
            this.comboRidic.Name = "comboRidic";
            this.comboRidic.Size = new System.Drawing.Size(121, 24);
            this.comboRidic.TabIndex = 70;
            // 
            // comboLinka
            // 
            this.comboLinka.FormattingEnabled = true;
            this.comboLinka.Location = new System.Drawing.Point(70, 55);
            this.comboLinka.Name = "comboLinka";
            this.comboLinka.Size = new System.Drawing.Size(121, 24);
            this.comboLinka.TabIndex = 69;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(304, 20);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 68;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(510, 20);
            this.timeBox.Mask = "90:00";
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 22);
            this.timeBox.TabIndex = 67;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.timeBox.UseWaitCursor = true;
            this.timeBox.ValidatingType = typeof(System.DateTime);
            this.timeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // ZmenitBusButton
            // 
            this.ZmenitBusButton.Location = new System.Drawing.Point(471, 92);
            this.ZmenitBusButton.Name = "ZmenitBusButton";
            this.ZmenitBusButton.Size = new System.Drawing.Size(161, 23);
            this.ZmenitBusButton.TabIndex = 66;
            this.ZmenitBusButton.Text = "Změna busu";
            this.ZmenitBusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZmenitBusButton.UseVisualStyleBackColor = true;
            this.ZmenitBusButton.Click += new System.EventHandler(this.ZmenitBusButton_Click);
            // 
            // ZmenaRidiceButton
            // 
            this.ZmenaRidiceButton.Location = new System.Drawing.Point(471, 56);
            this.ZmenaRidiceButton.Name = "ZmenaRidiceButton";
            this.ZmenaRidiceButton.Size = new System.Drawing.Size(161, 23);
            this.ZmenaRidiceButton.TabIndex = 65;
            this.ZmenaRidiceButton.Text = "Změna řidiče";
            this.ZmenaRidiceButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ZmenaRidiceButton.UseVisualStyleBackColor = true;
            this.ZmenaRidiceButton.Click += new System.EventHandler(this.ZmenaRidiceButton_Click);
            // 
            // textBoxStav
            // 
            this.textBoxStav.Location = new System.Drawing.Point(297, 91);
            this.textBoxStav.Name = "textBoxStav";
            this.textBoxStav.Size = new System.Drawing.Size(40, 22);
            this.textBoxStav.TabIndex = 64;
            this.textBoxStav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStav_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Stav spoje*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Řidič*";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(654, 92);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(89, 23);
            this.DeleteButton.TabIndex = 60;
            this.DeleteButton.Text = "Odstranit";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(654, 56);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 23);
            this.SaveButton.TabIndex = 59;
            this.SaveButton.Text = "Uložit";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Autobus*";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(654, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 23);
            this.AddButton.TabIndex = 57;
            this.AddButton.Text = "Vytvořit";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(70, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 53;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Čas odjezdu*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Linka*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "ID spoje*";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 282);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID spoje";
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Čas odjezdu";
            this.columnHeader7.Width = 162;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Číslo linky";
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "VIN";
            this.columnHeader9.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Osobní číslo";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Stav spoje";
            this.columnHeader11.Width = 85;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 444);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 55;
            this.CancelButton.Text = "Zpět";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditSpojForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 487);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(826, 534);
            this.MinimumSize = new System.Drawing.Size(826, 534);
            this.Name = "EditSpojForm";
            this.Text = "Editace spoje";
            this.Load += new System.EventHandler(this.EditSpojForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ZmenitBusButton;
        private System.Windows.Forms.Button ZmenaRidiceButton;
        private System.Windows.Forms.TextBox textBoxStav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBus;
        private System.Windows.Forms.ComboBox comboRidic;
        private System.Windows.Forms.ComboBox comboLinka;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.MaskedTextBox timeBox;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button CancelButton;
    }
}