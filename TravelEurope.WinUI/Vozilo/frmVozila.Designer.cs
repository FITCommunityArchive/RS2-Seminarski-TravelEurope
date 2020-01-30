namespace TravelEurope.WinUI.Vozilo
{
    partial class frmVozila
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
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.VoziloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaProizvodnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaGoriva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojVrata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.Black;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(358, 32);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(99, 23);
            this.btnDodajKorisnika.TabIndex = 14;
            this.btnDodajKorisnika.Text = "Dodaj vozilo";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajVozilo);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(106, 33);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(143, 20);
            this.txtNaziv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv vozila";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(266, 32);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoziloId,
            this.Naziv,
            this.TipVozila,
            this.GodinaProizvodnje,
            this.MarkaVozila,
            this.StatusVozila,
            this.VrstaGoriva,
            this.BrojSjedista,
            this.BrojVrata,
            this.Boja});
            this.dgvVozila.Location = new System.Drawing.Point(14, 115);
            this.dgvVozila.MultiSelect = false;
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvVozila.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(735, 235);
            this.dgvVozila.TabIndex = 10;
            // 
            // VoziloId
            // 
            this.VoziloId.DataPropertyName = "VoziloId";
            this.VoziloId.FillWeight = 70F;
            this.VoziloId.HeaderText = "VoziloId";
            this.VoziloId.Name = "VoziloId";
            this.VoziloId.ReadOnly = true;
            this.VoziloId.Visible = false;
            this.VoziloId.Width = 10;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 80;
            // 
            // TipVozila
            // 
            this.TipVozila.DataPropertyName = "TipVozila";
            this.TipVozila.HeaderText = "Tip";
            this.TipVozila.Name = "TipVozila";
            this.TipVozila.ReadOnly = true;
            this.TipVozila.Width = 80;
            // 
            // GodinaProizvodnje
            // 
            this.GodinaProizvodnje.DataPropertyName = "GodinaProizvodnje";
            this.GodinaProizvodnje.HeaderText = "Godina ";
            this.GodinaProizvodnje.Name = "GodinaProizvodnje";
            this.GodinaProizvodnje.ReadOnly = true;
            this.GodinaProizvodnje.Width = 80;
            // 
            // MarkaVozila
            // 
            this.MarkaVozila.DataPropertyName = "MarkaVozila";
            this.MarkaVozila.HeaderText = "Marka";
            this.MarkaVozila.Name = "MarkaVozila";
            this.MarkaVozila.ReadOnly = true;
            this.MarkaVozila.Width = 80;
            // 
            // StatusVozila
            // 
            this.StatusVozila.DataPropertyName = "StatusVozila";
            this.StatusVozila.HeaderText = "Status";
            this.StatusVozila.Name = "StatusVozila";
            this.StatusVozila.ReadOnly = true;
            this.StatusVozila.Width = 80;
            // 
            // VrstaGoriva
            // 
            this.VrstaGoriva.DataPropertyName = "VrstaGoriva";
            this.VrstaGoriva.HeaderText = "Gorivo";
            this.VrstaGoriva.Name = "VrstaGoriva";
            this.VrstaGoriva.ReadOnly = true;
            this.VrstaGoriva.Width = 80;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.DataPropertyName = "BrojSjedista";
            this.BrojSjedista.HeaderText = "Broj sjedista";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.ReadOnly = true;
            this.BrojSjedista.Width = 60;
            // 
            // BrojVrata
            // 
            this.BrojVrata.DataPropertyName = "BrojVrata";
            this.BrojVrata.HeaderText = "Broj vrata";
            this.BrojVrata.Name = "BrojVrata";
            this.BrojVrata.ReadOnly = true;
            this.BrojVrata.Width = 60;
            // 
            // Boja
            // 
            this.Boja.DataPropertyName = "Boja";
            this.Boja.HeaderText = "Boja";
            this.Boja.Name = "Boja";
            this.Boja.ReadOnly = true;
            this.Boja.Width = 80;
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 370);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvVozila);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVozila";
            this.Text = "frmVozila";
            this.Load += new System.EventHandler(this.frmVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoziloId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaProizvodnje;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaGoriva;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSjedista;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojVrata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boja;
    }
}