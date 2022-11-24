namespace ISBusForms.Forms
{
    partial class ZmenitTrasuForm
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
            this.comboLinka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBeforeButton = new System.Windows.Forms.Button();
            this.AddAfterButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.comboLinka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 50);
            this.panel1.TabIndex = 1;
            // 
            // comboLinka
            // 
            this.comboLinka.FormattingEnabled = true;
            this.comboLinka.Location = new System.Drawing.Point(92, 9);
            this.comboLinka.Name = "comboLinka";
            this.comboLinka.Size = new System.Drawing.Size(147, 24);
            this.comboLinka.TabIndex = 6;
            this.comboLinka.Text = "Vyberte linku";
            this.comboLinka.SelectedIndexChanged += new System.EventHandler(this.comboLinka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo linky";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 292);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pořadí zastávek";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zastávka";
            this.columnHeader1.Width = 203;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(458, 104);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(329, 292);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zastávka";
            this.columnHeader2.Width = 204;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zastávky linky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(560, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Všechny zastávky";
            // 
            // AddBeforeButton
            // 
            this.AddBeforeButton.Location = new System.Drawing.Point(353, 104);
            this.AddBeforeButton.Name = "AddBeforeButton";
            this.AddBeforeButton.Size = new System.Drawing.Size(99, 27);
            this.AddBeforeButton.TabIndex = 6;
            this.AddBeforeButton.Text = "Přidat před";
            this.AddBeforeButton.UseVisualStyleBackColor = true;
            this.AddBeforeButton.Click += new System.EventHandler(this.AddBeforeButton_Click);
            // 
            // AddAfterButton
            // 
            this.AddAfterButton.Location = new System.Drawing.Point(353, 148);
            this.AddAfterButton.Name = "AddAfterButton";
            this.AddAfterButton.Size = new System.Drawing.Size(99, 27);
            this.AddAfterButton.TabIndex = 7;
            this.AddAfterButton.Text = "Přidat za";
            this.AddAfterButton.UseVisualStyleBackColor = true;
            this.AddAfterButton.Click += new System.EventHandler(this.AddAfterButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(353, 370);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 26);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Odstranit";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 412);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 26);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Zpět";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddFirst
            // 
            this.AddFirst.Location = new System.Drawing.Point(353, 194);
            this.AddFirst.Name = "AddFirst";
            this.AddFirst.Size = new System.Drawing.Size(99, 27);
            this.AddFirst.TabIndex = 11;
            this.AddFirst.Text = "Přidat první";
            this.AddFirst.UseVisualStyleBackColor = true;
            this.AddFirst.Click += new System.EventHandler(this.AddFirst_Click);
            // 
            // ZmenitTrasuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddFirst);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddAfterButton);
            this.Controls.Add(this.AddBeforeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ZmenitTrasuForm";
            this.Text = "Změnit trasu linky";
            this.Load += new System.EventHandler(this.ZmenitTrasuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboLinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBeforeButton;
        private System.Windows.Forms.Button AddAfterButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button AddFirst;
    }
}