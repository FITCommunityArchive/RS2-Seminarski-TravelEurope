namespace TravelEurope.WinUI.Rezervacija
{
    partial class frmRezervacija
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
            this.txtNazivRezervacije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuristRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaUslugePoDanu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaOsiguranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preuzimanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivRezervacije
            // 
            this.txtNazivRezervacije.Location = new System.Drawing.Point(144, 38);
            this.txtNazivRezervacije.Name = "txtNazivRezervacije";
            this.txtNazivRezervacije.Size = new System.Drawing.Size(143, 20);
            this.txtNazivRezervacije.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Naziv rezervacije";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(299, 36);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 16;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.AllowUserToAddRows = false;
            this.dgvRezervacija.AllowUserToDeleteRows = false;
            this.dgvRezervacija.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.TuristRuta,
            this.CijenaUslugePoDanu,
            this.CijenaOsiguranja,
            this.Preuzimanje,
            this.DatumVracanja,
            this.Klijent,
            this.Radnik});
            this.dgvRezervacija.Location = new System.Drawing.Point(20, 107);
            this.dgvRezervacija.MultiSelect = false;
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.ReadOnly = true;
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRezervacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacija.Size = new System.Drawing.Size(729, 235);
            this.dgvRezervacija.TabIndex = 15;
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            // 
            // TuristRuta
            // 
            this.TuristRuta.DataPropertyName = "TuristRuta";
            this.TuristRuta.HeaderText = "Turist ruta";
            this.TuristRuta.Name = "TuristRuta";
            this.TuristRuta.ReadOnly = true;
            // 
            // CijenaUslugePoDanu
            // 
            this.CijenaUslugePoDanu.DataPropertyName = "CijenaUslugePoDanu";
            this.CijenaUslugePoDanu.HeaderText = "Cijena/dan";
            this.CijenaUslugePoDanu.Name = "CijenaUslugePoDanu";
            this.CijenaUslugePoDanu.ReadOnly = true;
            this.CijenaUslugePoDanu.Width = 85;
            // 
            // CijenaOsiguranja
            // 
            this.CijenaOsiguranja.DataPropertyName = "CijenaOsiguranja";
            this.CijenaOsiguranja.HeaderText = "Osiguranje/dan";
            this.CijenaOsiguranja.Name = "CijenaOsiguranja";
            this.CijenaOsiguranja.ReadOnly = true;
            // 
            // Preuzimanje
            // 
            this.Preuzimanje.DataPropertyName = "DatumPreuzimanja";
            this.Preuzimanje.HeaderText = "Preuzimanje";
            this.Preuzimanje.Name = "Preuzimanje";
            this.Preuzimanje.ReadOnly = true;
            // 
            // DatumVracanja
            // 
            this.DatumVracanja.DataPropertyName = "DatumVracanja";
            this.DatumVracanja.HeaderText = "Vracanje";
            this.DatumVracanja.Name = "DatumVracanja";
            this.DatumVracanja.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            // 
            // Radnik
            // 
            this.Radnik.DataPropertyName = "Radnik";
            this.Radnik.HeaderText = "Radnik";
            this.Radnik.Name = "Radnik";
            this.Radnik.ReadOnly = true;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 363);
            this.Controls.Add(this.txtNazivRezervacije);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvRezervacija);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNazivRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaUslugePoDanu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaOsiguranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preuzimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radnik;
    }
}