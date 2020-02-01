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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzbrisiSliku = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.dgvSlike = new System.Windows.Forms.DataGridView();
            this.RuteSlikeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajVodica = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clbKategorije = new System.Windows.Forms.CheckedListBox();
            this.cmbDrzave = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVodici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnIzbrisiSliku);
            this.groupBox1.Controls.Add(this.btnDodajSliku);
            this.groupBox1.Controls.Add(this.dgvSlike);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.btnDodajVodica);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDodajDrzavu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clbKategorije);
            this.groupBox1.Controls.Add(this.cmbDrzave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbVodici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(689, 852);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(339, 791);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "Izbriši Sliku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnIzbrisiSliku_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(527, 791);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Snimi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnIzbrisiSliku
            // 
            this.btnIzbrisiSliku.ForeColor = System.Drawing.Color.Black;
            this.btnIzbrisiSliku.Location = new System.Drawing.Point(190, 791);
            this.btnIzbrisiSliku.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisiSliku.Name = "btnIzbrisiSliku";
            this.btnIzbrisiSliku.Size = new System.Drawing.Size(129, 28);
            this.btnIzbrisiSliku.TabIndex = 23;
            this.btnIzbrisiSliku.Text = "Izbriši sliku";
            this.btnIzbrisiSliku.UseVisualStyleBackColor = true;
            this.btnIzbrisiSliku.Click += new System.EventHandler(this.btnIzbrisiSliku_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.ForeColor = System.Drawing.Color.Black;
            this.btnDodajSliku.Location = new System.Drawing.Point(41, 791);
            this.btnDodajSliku.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(129, 28);
            this.btnDodajSliku.TabIndex = 22;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
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
            this.dgvSlike.Location = new System.Drawing.Point(41, 448);
            this.dgvSlike.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSlike.MultiSelect = false;
            this.dgvSlike.Name = "dgvSlike";
            this.dgvSlike.ReadOnly = true;
            this.dgvSlike.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSlike.RowTemplate.Height = 100;
            this.dgvSlike.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlike.Size = new System.Drawing.Size(615, 318);
            this.dgvSlike.TabIndex = 18;
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
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(190, 74);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(5);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(340, 150);
            this.txtOpis.TabIndex = 15;
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(542, 234);
            this.btnDodajVodica.Margin = new System.Windows.Forms.Padding(5);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(28, 26);
            this.btnDodajVodica.TabIndex = 14;
            this.btnDodajVodica.Text = "+";
            this.btnDodajVodica.UseVisualStyleBackColor = true;
            this.btnDodajVodica.Click += new System.EventHandler(this.btnDodajVodica_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Opis putovanja";
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDrzavu.Location = new System.Drawing.Point(542, 269);
            this.btnDodajDrzavu.Margin = new System.Windows.Forms.Padding(5);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(28, 26);
            this.btnDodajDrzavu.TabIndex = 13;
            this.btnDodajDrzavu.Text = "+";
            this.btnDodajDrzavu.UseVisualStyleBackColor = true;
            this.btnDodajDrzavu.Click += new System.EventHandler(this.btnDodajDrzavu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kategorije";
            // 
            // clbKategorije
            // 
            this.clbKategorije.FormattingEnabled = true;
            this.clbKategorije.Location = new System.Drawing.Point(190, 317);
            this.clbKategorije.Margin = new System.Windows.Forms.Padding(5);
            this.clbKategorije.Name = "clbKategorije";
            this.clbKategorije.Size = new System.Drawing.Size(340, 89);
            this.clbKategorije.TabIndex = 8;
            // 
            // cmbDrzave
            // 
            this.cmbDrzave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrzave.FormattingEnabled = true;
            this.cmbDrzave.Location = new System.Drawing.Point(190, 271);
            this.cmbDrzave.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDrzave.Name = "cmbDrzave";
            this.cmbDrzave.Size = new System.Drawing.Size(340, 24);
            this.cmbDrzave.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 275);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Država";
            // 
            // cmbVodici
            // 
            this.cmbVodici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVodici.FormattingEnabled = true;
            this.cmbVodici.Location = new System.Drawing.Point(190, 235);
            this.cmbVodici.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVodici.Name = "cmbVodici";
            this.cmbVodici.Size = new System.Drawing.Size(340, 24);
            this.cmbVodici.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Turistički vodič";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(190, 39);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(5);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(340, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // frmTuristickeRuteDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 885);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnDodajVodica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox clbKategorije;
        private System.Windows.Forms.ComboBox cmbDrzave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVodici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DataGridView dgvSlike;
        private System.Windows.Forms.Button btnIzbrisiSliku;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuteSlikeId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}