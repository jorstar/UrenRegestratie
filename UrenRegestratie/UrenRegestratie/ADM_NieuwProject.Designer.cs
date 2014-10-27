namespace UrenRegestratie
{
    partial class ADM_NieuwProject
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
            this.txtProjectnaam = new System.Windows.Forms.TextBox();
            this.txtProjectomschrijving = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projectnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Omschrijving:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Begindatum:";
            // 
            // txtProjectnaam
            // 
            this.txtProjectnaam.Location = new System.Drawing.Point(87, 32);
            this.txtProjectnaam.Name = "txtProjectnaam";
            this.txtProjectnaam.Size = new System.Drawing.Size(267, 20);
            this.txtProjectnaam.TabIndex = 4;
            // 
            // txtProjectomschrijving
            // 
            this.txtProjectomschrijving.Location = new System.Drawing.Point(12, 85);
            this.txtProjectomschrijving.Multiline = true;
            this.txtProjectomschrijving.Name = "txtProjectomschrijving";
            this.txtProjectomschrijving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProjectomschrijving.Size = new System.Drawing.Size(339, 86);
            this.txtProjectomschrijving.TabIndex = 5;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(15, 250);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 24;
            this.btnOpslaan.Text = "opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(87, 193);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimeBegin.TabIndex = 25;
            // 
            // ADM_NieuwProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.txtProjectomschrijving);
            this.Controls.Add(this.txtProjectnaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM_NieuwProject";
            this.Text = "NieuwProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectnaam;
        private System.Windows.Forms.TextBox txtProjectomschrijving;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
    }
}