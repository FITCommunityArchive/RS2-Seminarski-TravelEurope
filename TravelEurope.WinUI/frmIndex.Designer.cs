namespace TravelEurope.WinUI
{
    partial class frmIndex
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.državeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDržavuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turističkiVodičiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregl = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTurističkogVodičaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevozniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrevoznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajVozačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Black;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.državeToolStripMenuItem,
            this.turističkiVodičiToolStripMenuItem,
            this.prevozniciToolStripMenuItem,
            this.vozilaToolStripMenuItem,
            this.vozačiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(714, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.PregledKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // državeToolStripMenuItem
            // 
            this.državeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem1,
            this.dodajDržavuToolStripMenuItem});
            this.državeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.državeToolStripMenuItem.Name = "državeToolStripMenuItem";
            this.državeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.državeToolStripMenuItem.Text = "Države";
            // 
            // pregledToolStripMenuItem1
            // 
            this.pregledToolStripMenuItem1.Name = "pregledToolStripMenuItem1";
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.PregledDrzavaToolStripMenuItem1_Click);
            // 
            // dodajDržavuToolStripMenuItem
            // 
            this.dodajDržavuToolStripMenuItem.Name = "dodajDržavuToolStripMenuItem";
            this.dodajDržavuToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dodajDržavuToolStripMenuItem.Text = "Dodaj državu";
            this.dodajDržavuToolStripMenuItem.Click += new System.EventHandler(this.dodajDržavuToolStripMenuItem_Click);
            // 
            // turističkiVodičiToolStripMenuItem
            // 
            this.turističkiVodičiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregl,
            this.dodajTurističkogVodičaToolStripMenuItem});
            this.turističkiVodičiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turističkiVodičiToolStripMenuItem.Name = "turističkiVodičiToolStripMenuItem";
            this.turističkiVodičiToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.turističkiVodičiToolStripMenuItem.Text = "Turistički vodiči";
            // 
            // pregl
            // 
            this.pregl.Name = "pregl";
            this.pregl.Size = new System.Drawing.Size(202, 22);
            this.pregl.Text = "Pregled";
            this.pregl.Click += new System.EventHandler(this.pregl_Click);
            // 
            // dodajTurističkogVodičaToolStripMenuItem
            // 
            this.dodajTurističkogVodičaToolStripMenuItem.Name = "dodajTurističkogVodičaToolStripMenuItem";
            this.dodajTurističkogVodičaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.dodajTurističkogVodičaToolStripMenuItem.Text = "Dodaj turističkog vodiča";
            this.dodajTurističkogVodičaToolStripMenuItem.Click += new System.EventHandler(this.dodajTurističkogVodičaToolStripMenuItem_Click);
            // 
            // prevozniciToolStripMenuItem
            // 
            this.prevozniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem3,
            this.dodajPrevoznikaToolStripMenuItem});
            this.prevozniciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prevozniciToolStripMenuItem.Name = "prevozniciToolStripMenuItem";
            this.prevozniciToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.prevozniciToolStripMenuItem.Text = "Turističke rute";
            // 
            // pregledToolStripMenuItem3
            // 
            this.pregledToolStripMenuItem3.Name = "pregledToolStripMenuItem3";
            this.pregledToolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.pregledToolStripMenuItem3.Text = "Pregled";
            this.pregledToolStripMenuItem3.Click += new System.EventHandler(this.pregledToolStripMenuItem3_Click);
            // 
            // dodajPrevoznikaToolStripMenuItem
            // 
            this.dodajPrevoznikaToolStripMenuItem.Name = "dodajPrevoznikaToolStripMenuItem";
            this.dodajPrevoznikaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dodajPrevoznikaToolStripMenuItem.Text = "Dodaj turističku rutu";
            this.dodajPrevoznikaToolStripMenuItem.Click += new System.EventHandler(this.dodajTuristRutuToolStripMenuItem_Click);
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem2,
            this.dodajVoziloToolStripMenuItem});
            this.vozilaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // pregledToolStripMenuItem2
            // 
            this.pregledToolStripMenuItem2.Name = "pregledToolStripMenuItem2";
            this.pregledToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.pregledToolStripMenuItem2.Text = "Pregled";
            this.pregledToolStripMenuItem2.Click += new System.EventHandler(this.pregledToolStripMenuItem2_Click);
            // 
            // dodajVoziloToolStripMenuItem
            // 
            this.dodajVoziloToolStripMenuItem.Name = "dodajVoziloToolStripMenuItem";
            this.dodajVoziloToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dodajVoziloToolStripMenuItem.Text = "Dodaj vozilo";
            this.dodajVoziloToolStripMenuItem.Click += new System.EventHandler(this.dodajVoziloToolStripMenuItem_Click);
            // 
            // vozačiToolStripMenuItem
            // 
            this.vozačiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem4,
            this.dodajVozačaToolStripMenuItem});
            this.vozačiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vozačiToolStripMenuItem.Name = "vozačiToolStripMenuItem";
            this.vozačiToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.vozačiToolStripMenuItem.Text = "Vozači";
            // 
            // pregledToolStripMenuItem4
            // 
            this.pregledToolStripMenuItem4.Name = "pregledToolStripMenuItem4";
            this.pregledToolStripMenuItem4.Size = new System.Drawing.Size(144, 22);
            this.pregledToolStripMenuItem4.Text = "Pregled";
            this.pregledToolStripMenuItem4.Click += new System.EventHandler(this.pregledToolStripMenuItem4_Click);
            // 
            // dodajVozačaToolStripMenuItem
            // 
            this.dodajVozačaToolStripMenuItem.Name = "dodajVozačaToolStripMenuItem";
            this.dodajVozačaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dodajVozačaToolStripMenuItem.Text = "Dodaj vozača";
            this.dodajVozačaToolStripMenuItem.Click += new System.EventHandler(this.dodajVozačaToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 361);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem državeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajDržavuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevozniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dodajPrevoznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dodajVoziloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turističkiVodičiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregl;
        private System.Windows.Forms.ToolStripMenuItem dodajTurističkogVodičaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem dodajVozačaToolStripMenuItem;
    }
}