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
            this.prevozniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrevoznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.državeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDržavuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turističkiVodičiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregl = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTurističkogVodičaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledVozačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.prevozniciToolStripMenuItem,
            this.turističkiVodičiToolStripMenuItem,
            this.rezervacijeToolStripMenuItem1});
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
            this.pregledToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pregledToolStripMenuItem1.Text = "Pregled";
            this.pregledToolStripMenuItem1.Click += new System.EventHandler(this.PregledDrzavaToolStripMenuItem1_Click);
            // 
            // dodajDržavuToolStripMenuItem
            // 
            this.dodajDržavuToolStripMenuItem.Name = "dodajDržavuToolStripMenuItem";
            this.dodajDržavuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // rezervacijeToolStripMenuItem1
            // 
            this.rezervacijeToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.rezervacijeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem6,
            this.pregledVozilaToolStripMenuItem,
            this.pregledVozačaToolStripMenuItem});
            this.rezervacijeToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezervacijeToolStripMenuItem1.Name = "rezervacijeToolStripMenuItem1";
            this.rezervacijeToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.rezervacijeToolStripMenuItem1.Text = "Rezervacije";
            // 
            // pregledToolStripMenuItem6
            // 
            this.pregledToolStripMenuItem6.Name = "pregledToolStripMenuItem6";
            this.pregledToolStripMenuItem6.Size = new System.Drawing.Size(153, 22);
            this.pregledToolStripMenuItem6.Text = "Pregled ruta";
            // 
            // pregledVozilaToolStripMenuItem
            // 
            this.pregledVozilaToolStripMenuItem.Name = "pregledVozilaToolStripMenuItem";
            this.pregledVozilaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledVozilaToolStripMenuItem.Text = "Pregled vozila";
            // 
            // pregledVozačaToolStripMenuItem
            // 
            this.pregledVozačaToolStripMenuItem.Name = "pregledVozačaToolStripMenuItem";
            this.pregledVozačaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledVozačaToolStripMenuItem.Text = "Pregled vozača";
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem5});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledToolStripMenuItem5
            // 
            this.pregledToolStripMenuItem5.Name = "pregledToolStripMenuItem5";
            this.pregledToolStripMenuItem5.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem5.Text = "Pregled";
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
        private System.Windows.Forms.ToolStripMenuItem turističkiVodičiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregl;
        private System.Windows.Forms.ToolStripMenuItem dodajTurističkogVodičaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pregledVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledVozačaToolStripMenuItem;
    }
}