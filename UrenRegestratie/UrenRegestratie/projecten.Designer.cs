namespace UrenRegestratie
{
    partial class projecten
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
            ((System.ComponentModel.ISupportInitialize)(this.GridviewProjecten)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjAfsl
            // 
            this.btnProjAfsl.Location = new System.Drawing.Point(547, 4);
            this.btnProjAfsl.Name = "btnProjAfsl";
            this.btnProjAfsl.Size = new System.Drawing.Size(96, 23);
            this.btnProjAfsl.TabIndex = 0;
            this.btnProjAfsl.Text = "Project Afsluiten";
            this.btnProjAfsl.UseVisualStyleBackColor = true;
            // 
            // combProjecten
            // 
            this.combProjecten.FormattingEnabled = true;
            this.combProjecten.Location = new System.Drawing.Point(72, 4);
            this.combProjecten.Name = "combProjecten";
            this.combProjecten.Size = new System.Drawing.Size(121, 21);
            this.combProjecten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "projecten:";
            // 
            // GridviewProjecten
            // 
            this.GridviewProjecten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridviewProjecten.Location = new System.Drawing.Point(-1, 31);
            this.GridviewProjecten.Name = "GridviewProjecten";
            this.GridviewProjecten.Size = new System.Drawing.Size(656, 257);
            this.GridviewProjecten.TabIndex = 4;
            // 
            // projecten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.GridviewProjecten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combProjecten);
            this.Controls.Add(this.btnProjAfsl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "projecten";
            this.Text = "projecten";
            ((System.ComponentModel.ISupportInitialize)(this.GridviewProjecten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProjAfsl;
        private System.Windows.Forms.ComboBox combProjecten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridviewProjecten;
    }
}