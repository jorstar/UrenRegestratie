namespace UrenRegestratie
{
    partial class Gebruiker
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
            this.combGebruikers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerwijderGebruiker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combGebruikers
            // 
            this.combGebruikers.FormattingEnabled = true;
            this.combGebruikers.Location = new System.Drawing.Point(78, 9);
            this.combGebruikers.Name = "combGebruikers";
            this.combGebruikers.Size = new System.Drawing.Size(121, 21);
            this.combGebruikers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "gebruikers:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 249);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnVerwijderGebruiker
            // 
            this.btnVerwijderGebruiker.Location = new System.Drawing.Point(534, 7);
            this.btnVerwijderGebruiker.Name = "btnVerwijderGebruiker";
            this.btnVerwijderGebruiker.Size = new System.Drawing.Size(109, 23);
            this.btnVerwijderGebruiker.TabIndex = 3;
            this.btnVerwijderGebruiker.Text = "Verwijder Gebruiker";
            this.btnVerwijderGebruiker.UseVisualStyleBackColor = true;
            this.btnVerwijderGebruiker.Click += new System.EventHandler(this.btnVerwijderGebruiker_Click);
            // 
            // Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.btnVerwijderGebruiker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combGebruikers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gebruiker";
            this.Text = "Gebruiker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combGebruikers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerwijderGebruiker;
    }
}