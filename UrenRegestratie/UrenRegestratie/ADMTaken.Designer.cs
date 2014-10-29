namespace UrenRegestratie
{
    partial class ADMTaken
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
            this.cmbProjecten = new System.Windows.Forms.ComboBox();
            this.dgvTaken = new System.Windows.Forms.DataGridView();
            this.btnNieuw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaken)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project:";
            // 
            // cmbProjecten
            // 
            this.cmbProjecten.FormattingEnabled = true;
            this.cmbProjecten.Location = new System.Drawing.Point(61, 51);
            this.cmbProjecten.Name = "cmbProjecten";
            this.cmbProjecten.Size = new System.Drawing.Size(190, 21);
            this.cmbProjecten.TabIndex = 2;
            this.cmbProjecten.SelectedIndexChanged += new System.EventHandler(this.cmbProjecten_SelectedIndexChanged);
            // 
            // dgvTaken
            // 
            this.dgvTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaken.Location = new System.Drawing.Point(15, 78);
            this.dgvTaken.Name = "dgvTaken";
            this.dgvTaken.Size = new System.Drawing.Size(628, 195);
            this.dgvTaken.TabIndex = 3;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(551, 49);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(92, 23);
            this.btnNieuw.TabIndex = 4;
            this.btnNieuw.Text = "Nieuwe Taak";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // ADMTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 285);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.dgvTaken);
            this.Controls.Add(this.cmbProjecten);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADMTaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMTaken";
            this.Load += new System.EventHandler(this.ADMTaken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProjecten;
        private System.Windows.Forms.DataGridView dgvTaken;
        private System.Windows.Forms.Button btnNieuw;
    }
}