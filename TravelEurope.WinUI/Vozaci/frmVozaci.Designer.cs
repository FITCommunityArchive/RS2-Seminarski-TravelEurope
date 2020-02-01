namespace TravelEurope.WinUI.Vozaci
{
    partial class frmVozaci
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
            this.VozacId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrVozackeDozvole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusVozaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.Black;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(477, 39);
            this.btnDodajKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(132, 28);
            this.btnDodajKorisnika.TabIndex = 14;
            this.btnDodajKorisnika.Text = "Dodaj vozača";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(141, 41);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(189, 22);
            this.txtNaziv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv vozila";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(355, 39);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 28);
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
            this.VozacId,
            this.Ime,
            this.Prezime,
            this.BrVozackeDozvole,
            this.StatusVozaca});
            this.dgvVozila.Location = new System.Drawing.Point(19, 142);
            this.dgvVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVozila.MultiSelect = false;
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvVozila.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(591, 284);
            this.dgvVozila.TabIndex = 10;
            this.dgvVozila.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellDoubleClick);
            // 
            // VozacId
            // 
            this.VozacId.DataPropertyName = "VozacId";
            this.VozacId.FillWeight = 70F;
            this.VozacId.HeaderText = "VozacId";
            this.VozacId.Name = "VozacId";
            this.VozacId.ReadOnly = true;
            this.VozacId.Visible = false;
            this.VozacId.Width = 10;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 85;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 86;
            // 
            // BrVozackeDozvole
            // 
            this.BrVozackeDozvole.DataPropertyName = "BrVozackeDozvole";
            this.BrVozackeDozvole.HeaderText = "Broj vozačke";
            this.BrVozackeDozvole.Name = "BrVozackeDozvole";
            this.BrVozackeDozvole.ReadOnly = true;
            this.BrVozackeDozvole.Width = 85;
            // 
            // StatusVozaca
            // 
            this.StatusVozaca.DataPropertyName = "StatusVozaca";
            this.StatusVozaca.HeaderText = "Status vozača";
            this.StatusVozaca.Name = "StatusVozaca";
            this.StatusVozaca.ReadOnly = true;
            this.StatusVozaca.Width = 85;
            // 
            // frmVozaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 448);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvVozila);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVozaci";
            this.Text = "frmVozaci";
            this.Load += new System.EventHandler(this.frmVozaci_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn VozacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrVozackeDozvole;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusVozaca;
    }
}