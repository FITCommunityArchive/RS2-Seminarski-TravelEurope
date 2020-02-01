namespace TravelEurope.WinUI.Korisnici
{
    partial class frmKorisnici
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.ForeColor = System.Drawing.Color.Black;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(475, 37);
            this.btnDodajKorisnika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(132, 28);
            this.btnDodajKorisnika.TabIndex = 9;
            this.btnDodajKorisnika.Text = "Dodaj korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(139, 39);
            this.txtImePrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(189, 22);
            this.txtImePrezime.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime i prezime";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(352, 37);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 28);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_ClickAsync);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Email,
            this.Grad,
            this.Adresa});
            this.dgvKorisnici.Location = new System.Drawing.Point(16, 140);
            this.dgvKorisnici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKorisnici.MultiSelect = false;
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvKorisnici.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(747, 289);
            this.dgvKorisnici.TabIndex = 5;
            this.dgvKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKorisnici";
            this.Text = "frmKorisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
    }
}