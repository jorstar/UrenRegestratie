namespace UrenRegestratie
{
    partial class ADM_Gebruiker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combGebruikers
            // 
            this.combGebruikers.FormattingEnabled = true;
            this.combGebruikers.Location = new System.Drawing.Point(77, 27);
            this.combGebruikers.Name = "combGebruikers";
            this.combGebruikers.Size = new System.Drawing.Size(121, 21);
            this.combGebruikers.TabIndex = 0;
            this.combGebruikers.SelectedIndexChanged += new System.EventHandler(this.combGebruikers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "gebruikers:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnVerwijderGebruiker
            // 
            this.btnVerwijderGebruiker.Location = new System.Drawing.Point(518, 25);
            this.btnVerwijderGebruiker.Name = "btnVerwijderGebruiker";
            this.btnVerwijderGebruiker.Size = new System.Drawing.Size(125, 23);
            this.btnVerwijderGebruiker.TabIndex = 3;
            this.btnVerwijderGebruiker.Text = "deactiveer Gebruiker";
            this.btnVerwijderGebruiker.UseVisualStyleBackColor = true;
            this.btnVerwijderGebruiker.Click += new System.EventHandler(this.btnVerwijderGebruiker_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ADM_Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.btnVerwijderGebruiker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combGebruikers);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADM_Gebruiker";
            this.Text = "Gebruiker";
            this.Load += new System.EventHandler(this.Gebruiker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combGebruikers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerwijderGebruiker;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}