namespace UrenRegestratie
{
    partial class ADM_projectenForm
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
            this.btnProjAfsl = new System.Windows.Forms.Button();
            this.combProjecten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridviewProjecten = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridviewProjecten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjAfsl
            // 
            this.btnProjAfsl.Location = new System.Drawing.Point(559, 41);
            this.btnProjAfsl.Name = "btnProjAfsl";
            this.btnProjAfsl.Size = new System.Drawing.Size(96, 23);
            this.btnProjAfsl.TabIndex = 0;
            this.btnProjAfsl.Text = "Project Afsluiten";
            this.btnProjAfsl.UseVisualStyleBackColor = true;
            this.btnProjAfsl.Click += new System.EventHandler(this.btnProjAfsl_Click);
            // 
            // combProjecten
            // 
            this.combProjecten.FormattingEnabled = true;
            this.combProjecten.Location = new System.Drawing.Point(67, 43);
            this.combProjecten.Name = "combProjecten";
            this.combProjecten.Size = new System.Drawing.Size(121, 21);
            this.combProjecten.TabIndex = 1;
            this.combProjecten.SelectedIndexChanged += new System.EventHandler(this.combProjecten_SelectedIndexChanged);
            this.combProjecten.Enter += new System.EventHandler(this.combProjecten_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "projecten:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GridviewProjecten
            // 
            this.GridviewProjecten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewProjecten.Location = new System.Drawing.Point(0, 65);
            this.GridviewProjecten.Name = "GridviewProjecten";
            this.GridviewProjecten.Size = new System.Drawing.Size(656, 221);
            this.GridviewProjecten.TabIndex = 4;
            this.GridviewProjecten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridviewProjecten_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nieuw Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(464, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "wel";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(511, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "niet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Laat afgesloten projecten zien:";
            // 
            // ADM_projectenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridviewProjecten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combProjecten);
            this.Controls.Add(this.btnProjAfsl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADM_projectenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "projecten";
            this.Load += new System.EventHandler(this.projecten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridviewProjecten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProjAfsl;
        private System.Windows.Forms.ComboBox combProjecten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridviewProjecten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
    }
}