using System;

namespace gyumolcsok
{
    partial class Form_Gyumolcs
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
            this.label_Termekkod = new System.Windows.Forms.Label();
            this.textBox_Termekkod = new System.Windows.Forms.TextBox();
            this.label_Nev = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label_Mennyiseg = new System.Windows.Forms.Label();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Termekkod
            // 
            this.label_Termekkod.AutoSize = true;
            this.label_Termekkod.Location = new System.Drawing.Point(43, 58);
            this.label_Termekkod.Name = "label_Termekkod";
            this.label_Termekkod.Size = new System.Drawing.Size(88, 20);
            this.label_Termekkod.TabIndex = 0;
            this.label_Termekkod.Text = "Termékkód";
            // 
            // textBox_Termekkod
            // 
            this.textBox_Termekkod.Location = new System.Drawing.Point(203, 58);
            this.textBox_Termekkod.Name = "textBox_Termekkod";
            this.textBox_Termekkod.Size = new System.Drawing.Size(100, 26);
            this.textBox_Termekkod.TabIndex = 1;
            // 
            // label_Nev
            // 
            this.label_Nev.AutoSize = true;
            this.label_Nev.Location = new System.Drawing.Point(43, 108);
            this.label_Nev.Name = "label_Nev";
            this.label_Nev.Size = new System.Drawing.Size(36, 20);
            this.label_Nev.TabIndex = 2;
            this.label_Nev.Text = "Név";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(203, 108);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(100, 26);
            this.textBox_Nev.TabIndex = 3;
            // 
            // label_Mennyiseg
            // 
            this.label_Mennyiseg.AutoSize = true;
            this.label_Mennyiseg.Location = new System.Drawing.Point(43, 154);
            this.label_Mennyiseg.Name = "label_Mennyiseg";
            this.label_Mennyiseg.Size = new System.Drawing.Size(85, 20);
            this.label_Mennyiseg.TabIndex = 4;
            this.label_Mennyiseg.Text = "Mennyiség";
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(203, 154);
            this.numericUpDown_Mennyiseg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_Mennyiseg.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Gyumolcs
            // 
            this.ClientSize = new System.Drawing.Size(1150, 784);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_Mennyiseg);
            this.Controls.Add(this.label_Mennyiseg);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label_Nev);
            this.Controls.Add(this.textBox_Termekkod);
            this.Controls.Add(this.label_Termekkod);
            this.Name = "Form_Gyumolcs";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Termekkod;
        private System.Windows.Forms.TextBox textBox_Termekkod;
        private System.Windows.Forms.Label label_Nev;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label_Mennyiseg;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.Button button1;
    }
}