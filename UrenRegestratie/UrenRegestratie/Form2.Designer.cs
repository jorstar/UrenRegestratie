﻿namespace UrenRegestratie
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deProjectenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urenregistratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deGebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuweGebruikerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.projectenToolStripMenuItem,
            this.urenregistratieToolStripMenuItem,
            this.gebruikersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.homeToolStripMenuItem.Text = "home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // projectenToolStripMenuItem
            // 
            this.projectenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deProjectenToolStripMenuItem,
            this.nieuwProjectToolStripMenuItem});
            this.projectenToolStripMenuItem.Name = "projectenToolStripMenuItem";
            this.projectenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.projectenToolStripMenuItem.Text = "Projecten";
            // 
            // deProjectenToolStripMenuItem
            // 
            this.deProjectenToolStripMenuItem.Name = "deProjectenToolStripMenuItem";
            this.deProjectenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deProjectenToolStripMenuItem.Text = "de projecten";
            this.deProjectenToolStripMenuItem.Click += new System.EventHandler(this.deProjectenToolStripMenuItem_Click);
            // 
            // nieuwProjectToolStripMenuItem
            // 
            this.nieuwProjectToolStripMenuItem.Name = "nieuwProjectToolStripMenuItem";
            this.nieuwProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nieuwProjectToolStripMenuItem.Text = "nieuw project";
            this.nieuwProjectToolStripMenuItem.Click += new System.EventHandler(this.nieuwProjectToolStripMenuItem_Click);
            // 
            // urenregistratieToolStripMenuItem
            // 
            this.urenregistratieToolStripMenuItem.Name = "urenregistratieToolStripMenuItem";
            this.urenregistratieToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.urenregistratieToolStripMenuItem.Text = "Urenregistratie";
            this.urenregistratieToolStripMenuItem.Click += new System.EventHandler(this.urenregistratieToolStripMenuItem_Click);
            // 
            // gebruikersToolStripMenuItem
            // 
            this.gebruikersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deGebruikersToolStripMenuItem,
            this.nieuweGebruikerToolStripMenuItem});
            this.gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            this.gebruikersToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.gebruikersToolStripMenuItem.Text = "Gebruikers";
            // 
            // deGebruikersToolStripMenuItem
            // 
            this.deGebruikersToolStripMenuItem.Name = "deGebruikersToolStripMenuItem";
            this.deGebruikersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deGebruikersToolStripMenuItem.Text = "de gebruikers";
            this.deGebruikersToolStripMenuItem.Click += new System.EventHandler(this.deGebruikersToolStripMenuItem_Click);
            // 
            // nieuweGebruikerToolStripMenuItem
            // 
            this.nieuweGebruikerToolStripMenuItem.Name = "nieuweGebruikerToolStripMenuItem";
            this.nieuweGebruikerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nieuweGebruikerToolStripMenuItem.Text = "nieuwe gebruiker";
            this.nieuweGebruikerToolStripMenuItem.Click += new System.EventHandler(this.nieuweGebruikerToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 312);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Taken Urenregistratie";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deProjectenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urenregistratieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gebruikersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deGebruikersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuweGebruikerToolStripMenuItem;

    }
}