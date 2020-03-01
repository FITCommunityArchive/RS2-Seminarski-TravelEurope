namespace TravelEurope.WinUI.Lokacije
{
    partial class frmUrediDrzavu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.dgvGradovi = new System.Windows.Forms.DataGridView();
            this.GradId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv države";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(89, 13);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(140, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnUredi
            // 
            this.btnUredi.ForeColor = System.Drawing.Color.Black;
            this.btnUredi.Location = new System.Drawing.Point(154, 48);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgvGradovi
            // 
            this.dgvGradovi.AllowUserToAddRows = false;
            this.dgvGradovi.AllowUserToDeleteRows = false;
            this.dgvGradovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGradovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GradId,
            this.Naziv});
            this.dgvGradovi.Location = new System.Drawing.Point(16, 90);
            this.dgvGradovi.MultiSelect = false;
            this.dgvGradovi.Name = "dgvGradovi";
            this.dgvGradovi.ReadOnly = true;
            this.dgvGradovi.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGradovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGradovi.Size = new System.Drawing.Size(213, 233);
            this.dgvGradovi.TabIndex = 3;
            this.dgvGradovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGradovi_CellDoubleClick);
            // 
            // GradId
            // 
            this.GradId.DataPropertyName = "GradId";
            this.GradId.HeaderText = "GradId";
            this.GradId.Name = "GradId";
            this.GradId.ReadOnly = true;
            this.GradId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.ForeColor = System.Drawing.Color.Black;
            this.btnDodajGrad.Location = new System.Drawing.Point(153, 329);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDodajGrad.Size = new System.Drawing.Size(75, 23);
            this.btnDodajGrad.TabIndex = 4;
            this.btnDodajGrad.Text = "Dodaj grad";
            this.btnDodajGrad.UseVisualStyleBackColor = true;
            this.btnDodajGrad.Click += new System.EventHandler(this.btnDodajGrad_Click);
            // 
            // frmUrediDrzavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(241, 366);
            this.Controls.Add(this.btnDodajGrad);
            this.Controls.Add(this.dgvGradovi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MaximizeBox = false;
            this.Name = "frmUrediDrzavu";
            this.Text = "Uredi državu";
            this.Load += new System.EventHandler(this.frmUrediDrzavu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGradovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgvGradovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnDodajGrad;
    }
}