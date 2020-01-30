namespace TravelEurope.WinUI.Lokacije
{
    partial class frmDrzava
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
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.txtNazivDrzava = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvDrzava = new System.Windows.Forms.DataGridView();
            this.DrzavaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzava)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.ForeColor = System.Drawing.Color.Black;
            this.btnDodajDrzavu.Location = new System.Drawing.Point(345, 30);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(99, 23);
            this.btnDodajDrzavu.TabIndex = 9;
            this.btnDodajDrzavu.Text = "Dodaj državu";
            this.btnDodajDrzavu.UseVisualStyleBackColor = true;
            this.btnDodajDrzavu.Click += new System.EventHandler(this.btnDodajDrzavu_Click);
            // 
            // txtNazivDrzava
            // 
            this.txtNazivDrzava.Location = new System.Drawing.Point(104, 32);
            this.txtNazivDrzava.Name = "txtNazivDrzava";
            this.txtNazivDrzava.Size = new System.Drawing.Size(143, 20);
            this.txtNazivDrzava.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv države";
            // 
            // btnPretraga
            // 
            this.btnPretraga.ForeColor = System.Drawing.Color.Black;
            this.btnPretraga.Location = new System.Drawing.Point(253, 30);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvDrzava
            // 
            this.dgvDrzava.AllowUserToAddRows = false;
            this.dgvDrzava.AllowUserToDeleteRows = false;
            this.dgvDrzava.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDrzava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrzava.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrzavaId,
            this.Naziv});
            this.dgvDrzava.Location = new System.Drawing.Point(12, 114);
            this.dgvDrzava.MultiSelect = false;
            this.dgvDrzava.Name = "dgvDrzava";
            this.dgvDrzava.ReadOnly = true;
            this.dgvDrzava.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.dgvDrzava.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDrzava.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrzava.Size = new System.Drawing.Size(560, 235);
            this.dgvDrzava.TabIndex = 0;
            this.dgvDrzava.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrzava_CellDoubleClick);
            // 
            // DrzavaId
            // 
            this.DrzavaId.DataPropertyName = "DrzavaId";
            this.DrzavaId.HeaderText = "DrzavaId";
            this.DrzavaId.Name = "DrzavaId";
            this.DrzavaId.ReadOnly = true;
            this.DrzavaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 200;
            // 
            // frmDrzava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnDodajDrzavu);
            this.Controls.Add(this.txtNazivDrzava);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvDrzava);
            this.Name = "frmDrzava";
            this.Text = "frmDrzave";
            this.Load += new System.EventHandler(this.frmDrzava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.TextBox txtNazivDrzava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvDrzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrzavaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}