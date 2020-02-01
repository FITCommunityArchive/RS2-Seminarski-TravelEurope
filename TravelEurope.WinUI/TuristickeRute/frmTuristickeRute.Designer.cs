namespace TravelEurope.WinUI.TuristickeRute
{
    partial class frmTuristickeRute
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
            this.btnDodajRutu = new System.Windows.Forms.Button();
            this.txtNazivRute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvTuristRuta = new System.Windows.Forms.DataGridView();
            this.TuristRutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuristickiVodic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajRutu
            // 
            this.btnDodajRutu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajRutu.Location = new System.Drawing.Point(460, 37);
            this.btnDodajRutu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajRutu.Name = "btnDodajRutu";
            this.btnDodajRutu.Size = new System.Drawing.Size(132, 28);
            this.btnDodajRutu.TabIndex = 14;
            this.btnDodajRutu.Text = "Dodaj rutu";
            this.btnDodajRutu.UseVisualStyleBackColor = true;
            this.btnDodajRutu.Click += new System.EventHandler(this.btnDodajRutu_Click);
            // 
            // txtNazivRute
            // 
            this.txtNazivRute.Location = new System.Drawing.Point(139, 39);
            this.txtNazivRute.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivRute.Name = "txtNazivRute";
            this.txtNazivRute.Size = new System.Drawing.Size(189, 22);
            this.txtNazivRute.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv rute";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(337, 37);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(100, 28);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvTuristRuta
            // 
            this.dgvTuristRuta.AllowUserToAddRows = false;
            this.dgvTuristRuta.AllowUserToDeleteRows = false;
            this.dgvTuristRuta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTuristRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuristRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuristRutaId,
            this.Naziv,
            this.Opis,
            this.TuristickiVodic,
            this.Drzava});
            this.dgvTuristRuta.Location = new System.Drawing.Point(16, 140);
            this.dgvTuristRuta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTuristRuta.MultiSelect = false;
            this.dgvTuristRuta.Name = "dgvTuristRuta";
            this.dgvTuristRuta.ReadOnly = true;
            this.dgvTuristRuta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvTuristRuta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTuristRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuristRuta.Size = new System.Drawing.Size(747, 289);
            this.dgvTuristRuta.TabIndex = 10;
            this.dgvTuristRuta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuristRuta_CellDoubleClick);
            // 
            // TuristRutaId
            // 
            this.TuristRutaId.DataPropertyName = "TuristRutaId";
            this.TuristRutaId.HeaderText = "TuristRutaId";
            this.TuristRutaId.Name = "TuristRutaId";
            this.TuristRutaId.ReadOnly = true;
            this.TuristRutaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 170;
            // 
            // TuristickiVodic
            // 
            this.TuristickiVodic.DataPropertyName = "TuristickiVodic";
            this.TuristickiVodic.HeaderText = "Turisticki vodic";
            this.TuristickiVodic.Name = "TuristickiVodic";
            this.TuristickiVodic.ReadOnly = true;
            this.TuristickiVodic.Width = 145;
            // 
            // Drzava
            // 
            this.Drzava.DataPropertyName = "Drzava";
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.Name = "Drzava";
            this.Drzava.ReadOnly = true;
            // 
            // frmTuristickeRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.btnDodajRutu);
            this.Controls.Add(this.txtNazivRute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvTuristRuta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTuristickeRute";
            this.Text = "frmTuristickeRute";
            this.Load += new System.EventHandler(this.frmTuristRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuristRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRutu;
        private System.Windows.Forms.TextBox txtNazivRute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvTuristRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristRutaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristickiVodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
    }
}