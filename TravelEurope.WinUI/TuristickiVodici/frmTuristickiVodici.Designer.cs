namespace TravelEurope.WinUI.TuristickiVodici
{
    partial class frmTuristickiVodici
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
            this.btnDodajVodica = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvVodici = new System.Windows.Forms.DataGridView();
            this.TuristickiVodicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraniJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajVodica
            // 
            this.btnDodajVodica.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVodica.Location = new System.Drawing.Point(345, 30);
            this.btnDodajVodica.Name = "btnDodajVodica";
            this.btnDodajVodica.Size = new System.Drawing.Size(99, 23);
            this.btnDodajVodica.TabIndex = 19;
            this.btnDodajVodica.Text = "Dodaj vodiča";
            this.btnDodajVodica.UseVisualStyleBackColor = true;
            this.btnDodajVodica.Click += new System.EventHandler(this.btnDodajVodica_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(104, 32);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(143, 20);
            this.txtIme.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ime vodiča";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(253, 30);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 16;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvVodici
            // 
            this.dgvVodici.AllowUserToAddRows = false;
            this.dgvVodici.AllowUserToDeleteRows = false;
            this.dgvVodici.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVodici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVodici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TuristickiVodicId,
            this.Ime,
            this.Prezime,
            this.StraniJezik});
            this.dgvVodici.Location = new System.Drawing.Point(12, 114);
            this.dgvVodici.MultiSelect = false;
            this.dgvVodici.Name = "dgvVodici";
            this.dgvVodici.ReadOnly = true;
            this.dgvVodici.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvVodici.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVodici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVodici.Size = new System.Drawing.Size(451, 235);
            this.dgvVodici.TabIndex = 15;
            this.dgvVodici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuristickiVodic_CellDoubleClick);
            // 
            // TuristickiVodicId
            // 
            this.TuristickiVodicId.DataPropertyName = "TuristickiVodicId";
            this.TuristickiVodicId.HeaderText = "TuristickiVodicId";
            this.TuristickiVodicId.Name = "TuristickiVodicId";
            this.TuristickiVodicId.ReadOnly = true;
            this.TuristickiVodicId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 90;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // StraniJezik
            // 
            this.StraniJezik.DataPropertyName = "StraniJezik";
            this.StraniJezik.HeaderText = "Strani jezik";
            this.StraniJezik.Name = "StraniJezik";
            this.StraniJezik.ReadOnly = true;
            // 
            // frmTuristickiVodici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 368);
            this.Controls.Add(this.btnDodajVodica);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvVodici);
            this.Name = "frmTuristickiVodici";
            this.Text = "frmTuristickiVodici";
            this.Load += new System.EventHandler(this.frmTuristickiVodic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVodici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVodica;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvVodici;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuristickiVodicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StraniJezik;
    }
}