namespace UrenRegestratie
{
    partial class UrenRegestratieForm
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
            this.combUser = new System.Windows.Forms.ComboBox();
            this.combProject = new System.Windows.Forms.ComboBox();
            this.combTaak = new System.Windows.Forms.ComboBox();
            this.txtVerantwoording = new System.Windows.Forms.TextBox();
            this.txtAantalUren = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // combUser
            // 
            this.combUser.FormattingEnabled = true;
            this.combUser.Location = new System.Drawing.Point(56, 36);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(121, 21);
            this.combUser.TabIndex = 0;
            // 
            // combProject
            // 
            this.combProject.FormattingEnabled = true;
            this.combProject.Location = new System.Drawing.Point(56, 63);
            this.combProject.Name = "combProject";
            this.combProject.Size = new System.Drawing.Size(121, 21);
            this.combProject.TabIndex = 1;
            // 
            // combTaak
            // 
            this.combTaak.FormattingEnabled = true;
            this.combTaak.Location = new System.Drawing.Point(225, 63);
            this.combTaak.Name = "combTaak";
            this.combTaak.Size = new System.Drawing.Size(121, 21);
            this.combTaak.TabIndex = 2;
            // 
            // txtVerantwoording
            // 
            this.txtVerantwoording.Location = new System.Drawing.Point(15, 145);
            this.txtVerantwoording.Multiline = true;
            this.txtVerantwoording.Name = "txtVerantwoording";
            this.txtVerantwoording.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVerantwoording.Size = new System.Drawing.Size(363, 75);
            this.txtVerantwoording.TabIndex = 3;
            // 
            // txtAantalUren
            // 
            this.txtAantalUren.Location = new System.Drawing.Point(82, 226);
            this.txtAantalUren.Name = "txtAantalUren";
            this.txtAantalUren.Size = new System.Drawing.Size(100, 20);
            this.txtAantalUren.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "user:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "taak:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "verantwoording:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "aantal uren:";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(20, 252);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 32;
            this.btnOpslaan.Text = "opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // UrenRegestratieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAantalUren);
            this.Controls.Add(this.txtVerantwoording);
            this.Controls.Add(this.combTaak);
            this.Controls.Add(this.combProject);
            this.Controls.Add(this.combUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrenRegestratieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrenRegestratieForm";
            this.Load += new System.EventHandler(this.UrenRegestratieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.ComboBox combProject;
        private System.Windows.Forms.ComboBox combTaak;
        private System.Windows.Forms.TextBox txtVerantwoording;
        private System.Windows.Forms.TextBox txtAantalUren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}