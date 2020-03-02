namespace TravelEurope.WinUI.TuristickeRute
{
    partial class frmTuristickeRuteDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiSliku = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCijenaOsiguranja = new System.Windows.Forms.TextBox();
            this.txtCijenaIznajmljivanja = new System.Windows.Forms.TextBox();
            this.dgvSlike = new System.Windows.Forms.DataGridView();
            this.RuteSlikeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.cmbTrajanjePutovanja = new System.Windows.Forms.ComboBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajVodica = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLokacije = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVodici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiSliku);
            this.groupBox1.Controls.Add(this.btnDodajSliku);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCijenaOsiguranja);
            this.groupBox1.Controls.Add(this.txtCijenaIznajmljivanja);
            this.groupBox1.Controls.Add(this.dgvSlike);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDatumPolaska);
            this.groupBox1.Controls.Add(this.cmbTrajanjePutovanja);
            this.groupBox1.Controls.Add(this.btnDodajKategoriju);
            this.groupBox1.Controls.Add(this.cmbKategorije);
            this.groupBox1.Controls.Add(this.btnSnimi);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.btnDodajVodica);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDodajDrzavu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbLokacije);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVodici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(770, 500);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // btnIzbrisiSliku
            // 
            this.btnIzbrisiSliku.ForeColor = System.Drawing.Color.Black;
            this.btnIzbrisiSliku.Location = new System.Drawing.Point(561, 453);
            this.btnIzbrisiSliku.Name = "btnIzbrisiSliku";
            this.btnIzbrisiSliku.Size = new System.Drawing.Size(97, 23);
            this.btnIzbrisiSliku.TabIndex = 156;
            this.btnIzbrisiSliku.Text = "Izbrisi sliku";
            this.btnIzbrisiSliku.UseVisualStyleBackColor = true;
            this.btnIzbrisiSliku.Click += new System.EventHandler(this.btnIzbrisiSliku_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.ForeColor = System.Drawing.Color.Black;
            this.btnDodajSliku.Location = new System.Drawing.Point(446, 453);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(97, 23);
            this.btnDodajSliku.TabIndex = 5;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 155;
            this.label9.Text = "Cijena osiguranja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 154;
            this.label8.Text = "Cijena paketa";
            // 
            // txtCijenaOsiguranja
            // 
            this.txtCijenaOsiguranja.Location = new System.Drawing.Point(561, 185);
            this.txtCijenaOsiguranja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCijenaOsiguranja.MaxLength = 5;
            this.txtCijenaOsiguranja.Name = "txtCijenaOsiguranja";
            this.txtCijenaOsiguranja.Size = new System.Drawing.Size(186, 20);
            this.txtCijenaOsiguranja.TabIndex = 153;
            // 
            // txtCijenaIznajmljivanja
            // 
            this.txtCijenaIznajmljivanja.Location = new System.Drawing.Point(561, 148);
            this.txtCijenaIznajmljivanja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCijenaIznajmljivanja.MaxLength = 6;
            this.txtCijenaIznajmljivanja.Name = "txtCijenaIznajmljivanja";
            this.txtCijenaIznajmljivanja.Size = new System.Drawing.Size(186, 20);
            this.txtCijenaIznajmljivanja.TabIndex = 152;
            // 
            // dgvSlike
            // 
            this.dgvSlike.AllowUserToAddRows = false;
            this.dgvSlike.AllowUserToDeleteRows = false;
            this.dgvSlike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuteSlikeId,
            this.Slika,
            this.Opis});
            this.dgvSlike.Location = new System.Drawing.Point(446, 235);
            this.dgvSlike.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSlike.MultiSelect = false;
            this.dgvSlike.Name = "dgvSlike";
            this.dgvSlike.ReadOnly = true;
            this.dgvSlike.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSlike.RowTemplate.Height = 100;
            this.dgvSlike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlike.Size = new System.Drawing.Size(302, 199);
            this.dgvSlike.TabIndex = 26;
            this.dgvSlike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlike_CellDoubleClick);
            // 
            // RuteSlikeId
            // 
            this.RuteSlikeId.DataPropertyName = "RuteSlikeId";
            this.RuteSlikeId.HeaderText = "RuteSlikeId";
            this.RuteSlikeId.Name = "RuteSlikeId";
            this.RuteSlikeId.ReadOnly = true;
            this.RuteSlikeId.Visible = false;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "SlikaThumb";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 420;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 151;
            this.label6.Text = "Datum polaska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "Trajanje putovanja";
            // 
            // dtpDatumPolaska
            // 
            this.dtpDatumPolaska.Location = new System.Drawing.Point(561, 63);
            this.dtpDatumPolaska.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDatumPolaska.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDatumPolaska.MinDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.dtpDatumPolaska.Name = "dtpDatumPolaska";
            this.dtpDatumPolaska.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumPolaska.TabIndex = 149;
            this.dtpDatumPolaska.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // cmbTrajanjePutovanja
            // 
            this.cmbTrajanjePutovanja.FormattingEnabled = true;
            this.cmbTrajanjePutovanja.Items.AddRange(new object[] {
            " ",
            "3",
            "4",
            "5",
            "7",
            "14",
            "21",
            "31"});
            this.cmbTrajanjePutovanja.Location = new System.Drawing.Point(561, 106);
            this.cmbTrajanjePutovanja.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmbTrajanjePutovanja.Name = "cmbTrajanjePutovanja";
            this.cmbTrajanjePutovanja.Size = new System.Drawing.Size(186, 21);
            this.cmbTrajanjePutovanja.TabIndex = 148;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.ForeColor = System.Drawing.Color.Black;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(389, 308);
            this.btnDodajKategoriju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(21, 21);
            this.btnDodajKategoriju.TabIndex = 25;
            this.btnDodajKategoriju.Text = "+";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(125, 308);
            this.cmbKategorije.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(256, 21);
            this.cmbKategorije.TabIndex = 24;
            // 
            // btnSnimi
            // 
            this.btnSnimi.ForeColor = System.Drawing.Color.Black;
            this.btnSnimi.Location = new System.Drawing.Point(507, 643);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(97, 23);
            this.btnSnimi.TabIndex = 17;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(125, 92);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(256, 123);
            this.txtOpis.TabIndex = 15;
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(389, 249);
            this.btnDodajVodica.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(21, 21);
            this.btnDodajVodica.TabIndex = 14;
            this.btnDodajVodica.Text = "+";
            this.btnDodajVodica.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Opis putovanja";
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDrzavu.Location = new System.Drawing.Point(389, 278);
            this.btnDodajDrzavu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(21, 21);
            this.btnDodajDrzavu.TabIndex = 13;
            this.btnDodajDrzavu.Text = "+";
            this.btnDodajDrzavu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kategorija";
            // 
            // cmbLokacije
            // 
            this.cmbLokacije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLokacije.FormattingEnabled = true;
            this.cmbLokacije.Location = new System.Drawing.Point(125, 278);
            this.cmbLokacije.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLokacije.Name = "cmbLokacije";
            this.cmbLokacije.Size = new System.Drawing.Size(256, 21);
            this.cmbLokacije.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lokacija";
            // 
            // cmbVodici
            // 
            this.cmbVodici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVodici.FormattingEnabled = true;
            this.cmbVodici.Location = new System.Drawing.Point(125, 249);
            this.cmbVodici.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVodici.Name = "cmbVodici";
            this.cmbVodici.Size = new System.Drawing.Size(256, 21);
            this.cmbVodici.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turistički vodič";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(125, 64);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(256, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(694, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Snimi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTuristickeRuteDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTuristickeRuteDetalji";
            this.Text = "frmTuristickeRuteDetalji";
            this.Load += new System.EventHandler(this.frmTuristickeRuteDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCijenaOsiguranja;
        private System.Windows.Forms.TextBox txtCijenaIznajmljivanja;
        private System.Windows.Forms.DataGridView dgvSlike;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuteSlikeId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaska;
        private System.Windows.Forms.ComboBox cmbTrajanjePutovanja;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajVodica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLokacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVodici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisiSliku;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Button button1;
    }
}