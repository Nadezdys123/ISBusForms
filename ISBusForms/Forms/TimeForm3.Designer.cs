namespace ISBusForms.Forms
{
    partial class TimeForm3
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(34, 29);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 22);
            this.datePicker.TabIndex = 20;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(89, 85);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 19;
            this.ConfirmButton.Text = "Potvrdit";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(77, 57);
            this.timeBox.Mask = "90:00";
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(100, 22);
            this.timeBox.TabIndex = 18;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.timeBox.UseWaitCursor = true;
            this.timeBox.ValidatingType = typeof(System.DateTime);
            this.timeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Zadejte čas odjezdu";
            // 
            // TimeForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 127);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(280, 174);
            this.MinimumSize = new System.Drawing.Size(280, 174);
            this.Name = "TimeForm3";
            this.Text = "Čas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.MaskedTextBox timeBox;
        private System.Windows.Forms.Label label1;
    }
}