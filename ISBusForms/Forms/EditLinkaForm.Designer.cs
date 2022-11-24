namespace ISBusForms.Forms
{
    partial class EditLinkaForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxDoba = new System.Windows.Forms.TextBox();
            this.textBoxDelka = new System.Windows.Forms.TextBox();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.textBoxCislo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 282);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Číslo linky";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Název linky";
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Délka trasy";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doba trasy";
            this.columnHeader4.Width = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Doba trasy";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(496, 79);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Vytvořit";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxDoba
            // 
            this.textBoxDoba.Location = new System.Drawing.Point(356, 80);
            this.textBoxDoba.Name = "textBoxDoba";
            this.textBoxDoba.Size = new System.Drawing.Size(100, 22);
            this.textBoxDoba.TabIndex = 16;
            this.textBoxDoba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoba_KeyPress);
            // 
            // textBoxDelka
            // 
            this.textBoxDelka.Location = new System.Drawing.Point(356, 32);
            this.textBoxDelka.Name = "textBoxDelka";
            this.textBoxDelka.Size = new System.Drawing.Size(100, 22);
            this.textBoxDelka.TabIndex = 15;
            this.textBoxDelka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDelka_KeyPress);
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(114, 80);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(100, 22);
            this.textBoxNazev.TabIndex = 14;
            // 
            // textBoxCislo
            // 
            this.textBoxCislo.Location = new System.Drawing.Point(114, 32);
            this.textBoxCislo.Name = "textBoxCislo";
            this.textBoxCislo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCislo.TabIndex = 13;
            this.textBoxCislo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCislo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Délka trasy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Název linky*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Číslo nové linky*";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(592, 79);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Uložit";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(687, 79);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Odstranit";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(557, 32);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(146, 23);
            this.ChangeButton.TabIndex = 21;
            this.ChangeButton.Text = "Změnit trasu linky";
            this.ChangeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.ChangeButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.textBoxCislo);
            this.panel1.Controls.Add(this.textBoxNazev);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxDoba);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxDelka);
            this.panel1.Location = new System.Drawing.Point(12, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 132);
            this.panel1.TabIndex = 22;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(13, 451);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 32);
            this.CancelButton.TabIndex = 54;
            this.CancelButton.Text = "Zpět";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditLinkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(818, 539);
            this.MinimumSize = new System.Drawing.Size(818, 539);
            this.Name = "EditLinkaForm";
            this.Text = "Editace linky";
            this.Load += new System.EventHandler(this.EditLinkaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBoxDoba;
        private System.Windows.Forms.TextBox textBoxDelka;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.TextBox textBoxCislo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button CancelButton;
    }
}