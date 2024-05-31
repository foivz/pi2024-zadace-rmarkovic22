namespace MyDocDesktopApp
{
    partial class FrmPacijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacijenti));
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Location = new System.Drawing.Point(4, 3);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.RowHeadersWidth = 51;
            this.dgvPacijenti.RowTemplate.Height = 24;
            this.dgvPacijenti.Size = new System.Drawing.Size(744, 408);
            this.dgvPacijenti.TabIndex = 0;
            this.dgvPacijenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacijenti_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(628, 431);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(119, 30);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FrmPacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPacijenti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPacijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPacijenti";
            this.Load += new System.EventHandler(this.FrmPacijenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Button btnDodaj;
    }
}