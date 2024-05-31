namespace MyDocDesktopApp
{
    partial class FrmPretplata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretplata));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyDoc\r\nOdabir tarife za pretplatu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(23, 159);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(137, 61);
            this.btnBasic.TabIndex = 2;
            this.btnBasic.Text = "Health\r\nBasic";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(188, 159);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(137, 61);
            this.btnAdvance.TabIndex = 3;
            this.btnAdvance.Text = "Health\r\nAdvance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.Location = new System.Drawing.Point(355, 159);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(137, 61);
            this.btnPremium.TabIndex = 4;
            this.btnPremium.Text = "Health\r\nPremium";
            this.btnPremium.UseVisualStyleBackColor = true;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // FrmPretplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 345);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.btnBasic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPretplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odabir tarifre za pretplatu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnPremium;
    }
}