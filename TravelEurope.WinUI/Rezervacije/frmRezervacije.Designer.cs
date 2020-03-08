namespace TravelEurope.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuristRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.chBDK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.SuspendLayout();
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
            this.DatumRezervacije,
            this.Korisnik});
            this.dgvRezervacija.Location = new System.Drawing.Point(29, 85);
            this.dgvRezervacija.MultiSelect = false;
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.ReadOnly = true;
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvRezervacija.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRezervacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacija.Size = new System.Drawing.Size(466, 235);
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
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            this.DatumRezervacije.ReadOnly = true;
            this.DatumRezervacije.Width = 125;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Klijent";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(379, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 117;
            this.button1.Text = "Prikaži sve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.frmRezervacija_Load);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrikazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrikazi.Location = new System.Drawing.Point(269, 32);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 36);
            this.btnPrikazi.TabIndex = 116;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Enabled = false;
            this.dtpDatumKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(29, 41);
            this.dtpDatumKreiranja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dtpDatumKreiranja.MaxDate = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            this.dtpDatumKreiranja.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumKreiranja.TabIndex = 127;
            this.dtpDatumKreiranja.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            // 
            // chBDK
            // 
            this.chBDK.BackColor = System.Drawing.Color.White;
            this.chBDK.Location = new System.Drawing.Point(228, 41);
            this.chBDK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chBDK.Name = "chBDK";
            this.chBDK.Size = new System.Drawing.Size(14, 20);
            this.chBDK.TabIndex = 128;
            this.chBDK.UseVisualStyleBackColor = false;
            this.chBDK.CheckedChanged += new System.EventHandler(this.chBDK_CheckedChanged);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(524, 343);
            this.Controls.Add(this.chBDK);
            this.Controls.Add(this.dtpDatumKreiranja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvRezervacija);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRezervacija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.CheckBox chBDK;
    }
}