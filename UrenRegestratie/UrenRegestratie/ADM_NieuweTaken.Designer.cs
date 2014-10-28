namespace UrenRegestratie
{
    partial class ADM_NieuweTaken
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTakenNaam = new System.Windows.Forms.TextBox();
            this.txtTakenOmschrijving = new System.Windows.Forms.TextBox();
            this.combProjecten = new System.Windows.Forms.ComboBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "projecten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "taak naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "taak omschrijving:";
            // 
            // txtTakenNaam
            // 
            this.txtTakenNaam.Location = new System.Drawing.Point(78, 72);
            this.txtTakenNaam.Name = "txtTakenNaam";
            this.txtTakenNaam.Size = new System.Drawing.Size(115, 20);
            this.txtTakenNaam.TabIndex = 3;
            // 
            // txtTakenOmschrijving
            // 
            this.txtTakenOmschrijving.Location = new System.Drawing.Point(12, 132);
            this.txtTakenOmschrijving.Multiline = true;
            this.txtTakenOmschrijving.Name = "txtTakenOmschrijving";
            this.txtTakenOmschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTakenOmschrijving.Size = new System.Drawing.Size(451, 110);
            this.txtTakenOmschrijving.TabIndex = 4;
            // 
            // combProjecten
            // 
            this.combProjecten.FormattingEnabled = true;
            this.combProjecten.Location = new System.Drawing.Point(78, 36);
            this.combProjecten.Name = "combProjecten";
            this.combProjecten.Size = new System.Drawing.Size(115, 21);
            this.combProjecten.TabIndex = 5;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(15, 250);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 6;
            this.btnOpslaan.Text = "opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // ADM_NieuweTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.combProjecten);
            this.Controls.Add(this.txtTakenOmschrijving);
            this.Controls.Add(this.txtTakenNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM_NieuweTaken";
            this.Text = "NieuweTaken";
            this.Load += new System.EventHandler(this.NieuweTaken_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTakenNaam;
        private System.Windows.Forms.TextBox txtTakenOmschrijving;
        private System.Windows.Forms.ComboBox combProjecten;
        private System.Windows.Forms.Button btnOpslaan;
    }
}