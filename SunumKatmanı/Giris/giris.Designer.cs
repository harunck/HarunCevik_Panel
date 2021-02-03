
namespace SunumKatmanı.Giris
{
    partial class giris
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
            this.label2 = new System.Windows.Forms.Label();
            this.tKulAdi = new System.Windows.Forms.TextBox();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.bGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "K Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tKulAdi
            // 
            this.tKulAdi.Location = new System.Drawing.Point(225, 48);
            this.tKulAdi.Name = "tKulAdi";
            this.tKulAdi.Size = new System.Drawing.Size(235, 22);
            this.tKulAdi.TabIndex = 1;
            // 
            // tSifre
            // 
            this.tSifre.Location = new System.Drawing.Point(225, 97);
            this.tSifre.Name = "tSifre";
            this.tSifre.Size = new System.Drawing.Size(235, 22);
            this.tSifre.TabIndex = 1;
            // 
            // bGiris
            // 
            this.bGiris.Location = new System.Drawing.Point(385, 162);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(75, 23);
            this.bGiris.TabIndex = 2;
            this.bGiris.Text = "Giriş";
            this.bGiris.UseVisualStyleBackColor = true;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 334);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.tKulAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tKulAdi;
        private System.Windows.Forms.TextBox tSifre;
        private System.Windows.Forms.Button bGiris;
    }
}