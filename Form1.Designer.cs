namespace gyumolcsok
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Gyumolcsok = new System.Windows.Forms.ListBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Gyumolcsok
            // 
            this.listBox_Gyumolcsok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Gyumolcsok.FormattingEnabled = true;
            this.listBox_Gyumolcsok.ItemHeight = 20;
            this.listBox_Gyumolcsok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Gyumolcsok.Name = "listBox_Gyumolcsok";
            this.listBox_Gyumolcsok.Size = new System.Drawing.Size(325, 485);
            this.listBox_Gyumolcsok.TabIndex = 0;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(404, 12);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(226, 53);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Betöltés";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(403, 83);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(227, 54);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Mentés";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(403, 250);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(227, 52);
            this.button_Update.TabIndex = 4;
            this.button_Update.Text = "Módósít";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(403, 160);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(227, 54);
            this.button_Insert.TabIndex = 3;
            this.button_Insert.Text = "Új";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(404, 338);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(226, 52);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.listBox_Gyumolcsok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gyümölcsök nyilvántartása";
            this.ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Gyumolcsok;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
    }
}

