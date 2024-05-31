namespace MyDocDesktopApp
{
    partial class FrmNacin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNacin));
            this.naslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPretplata = new System.Windows.Forms.Button();
            this.btnIndividualno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.naslov.Location = new System.Drawing.Point(86, 29);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(346, 64);
            this.naslov.TabIndex = 6;
            this.naslov.Text = "MyDoc\r\nOdabir načina korištenja";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.naslov.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPretplata
            // 
            this.btnPretplata.Location = new System.Drawing.Point(73, 197);
            this.btnPretplata.Name = "btnPretplata";
            this.btnPretplata.Size = new System.Drawing.Size(139, 54);
            this.btnPretplata.TabIndex = 8;
            this.btnPretplata.Text = "Pretplata";
            this.btnPretplata.UseVisualStyleBackColor = true;
            this.btnPretplata.Click += new System.EventHandler(this.btnPretplata_Click);
            // 
            // btnIndividualno
            // 
            this.btnIndividualno.Location = new System.Drawing.Point(277, 197);
            this.btnIndividualno.Name = "btnIndividualno";
            this.btnIndividualno.Size = new System.Drawing.Size(139, 54);
            this.btnIndividualno.TabIndex = 9;
            this.btnIndividualno.Text = "Individualno \r\nkorištenje\r\n";
            this.btnIndividualno.UseVisualStyleBackColor = true;
            this.btnIndividualno.Click += new System.EventHandler(this.btnIndividualno_Click_1);
            // 
            // FrmNacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 337);
            this.Controls.Add(this.btnIndividualno);
            this.Controls.Add(this.btnPretplata);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNacin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir načina korištenja";
            this.Load += new System.EventHandler(this.FrmNacin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPretplata;
        private System.Windows.Forms.Button btnIndividualno;
    }
}