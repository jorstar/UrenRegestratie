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
            this.lbGebruikers = new System.Windows.Forms.ListBox();
            this.rdbDeactief = new System.Windows.Forms.RadioButton();
            this.rdbActief = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActieveer = new System.Windows.Forms.Button();
            this.btnDeactiveer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbWw = new System.Windows.Forms.TextBox();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblActief = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGebruikers
            // 
            this.lbGebruikers.FormattingEnabled = true;
            this.lbGebruikers.Location = new System.Drawing.Point(12, 49);
            this.lbGebruikers.Name = "lbGebruikers";
            this.lbGebruikers.Size = new System.Drawing.Size(202, 225);
            this.lbGebruikers.TabIndex = 5;
            // 
            // rdbDeactief
            // 
            this.rdbDeactief.AutoSize = true;
            this.rdbDeactief.Location = new System.Drawing.Point(220, 51);
            this.rdbDeactief.Name = "rdbDeactief";
            this.rdbDeactief.Size = new System.Drawing.Size(36, 17);
            this.rdbDeactief.TabIndex = 6;
            this.rdbDeactief.Text = "Ja";
            this.rdbDeactief.UseVisualStyleBackColor = true;
            // 
            // rdbActief
            // 
            this.rdbActief.AutoSize = true;
            this.rdbActief.Checked = true;
            this.rdbActief.Location = new System.Drawing.Point(220, 74);
            this.rdbActief.Name = "rdbActief";
            this.rdbActief.Size = new System.Drawing.Size(45, 17);
            this.rdbActief.TabIndex = 7;
            this.rdbActief.TabStop = true;
            this.rdbActief.Text = "Nee";
            this.rdbActief.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gedeactiveerd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gebruikers:";
            // 
            // btnActieveer
            // 
            this.btnActieveer.Location = new System.Drawing.Point(220, 102);
            this.btnActieveer.Name = "btnActieveer";
            this.btnActieveer.Size = new System.Drawing.Size(75, 23);
            this.btnActieveer.TabIndex = 10;
            this.btnActieveer.Text = "Activeren";
            this.btnActieveer.UseVisualStyleBackColor = true;
            // 
            // btnDeactiveer
            // 
            this.btnDeactiveer.Location = new System.Drawing.Point(220, 131);
            this.btnDeactiveer.Name = "btnDeactiveer";
            this.btnDeactiveer.Size = new System.Drawing.Size(75, 23);
            this.btnDeactiveer.TabIndex = 11;
            this.btnDeactiveer.Text = "Deactiveren";
            this.btnDeactiveer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Informatie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Voornaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Achternaam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gebruikersnaam";
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(418, 50);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.ReadOnly = true;
            this.tbVoornaam.Size = new System.Drawing.Size(149, 20);
            this.tbVoornaam.TabIndex = 16;
            // 
            // tbWw
            // 
            this.tbWw.Location = new System.Drawing.Point(418, 128);
            this.tbWw.Name = "tbWw";
            this.tbWw.ReadOnly = true;
            this.tbWw.Size = new System.Drawing.Size(149, 20);
            this.tbWw.TabIndex = 17;
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(418, 102);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.ReadOnly = true;
            this.tbGebruikersnaam.Size = new System.Drawing.Size(149, 20);
            this.tbGebruikersnaam.TabIndex = 18;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(418, 76);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.ReadOnly = true;
            this.tbAchternaam.Size = new System.Drawing.Size(149, 20);
            this.tbAchternaam.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Wachtwoord";
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(415, 159);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(0, 13);
            this.lblActief.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Geactiveerd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Aanpassen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Opslaan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Annuleren";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ADM_Gebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAchternaam);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.tbWw);
            this.Controls.Add(this.tbVoornaam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeactiveer);
            this.Controls.Add(this.btnActieveer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbActief);
            this.Controls.Add(this.rdbDeactief);
            this.Controls.Add(this.lbGebruikers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM_Gebruiker";
            this.Text = "Gebruiker";
            this.Load += new System.EventHandler(this.Gebruiker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGebruikers;
        private System.Windows.Forms.RadioButton rdbDeactief;
        private System.Windows.Forms.RadioButton rdbActief;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActieveer;
        private System.Windows.Forms.Button btnDeactiveer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbWw;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}