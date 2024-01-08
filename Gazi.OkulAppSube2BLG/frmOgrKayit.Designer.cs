namespace Gazi.OkulAppSube2BLG
{
    partial class frmOgrKayit
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpOgrenci.Location = new System.Drawing.Point(12, 12);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Size = new System.Drawing.Size(283, 184);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(152, 122);
            this.txtNumara.Multiline = true;
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(115, 27);
            this.txtNumara.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(8, 34);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(88, 20);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Öğrenci Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(8, 79);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(113, 20);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Öğrenci Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Location = new System.Drawing.Point(6, 125);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(124, 20);
            this.lblNumara.TabIndex = 6;
            this.lblNumara.Text = "Öğrenci Numara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(152, 76);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(115, 28);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(152, 31);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(115, 30);
            this.txtAd.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(72, 234);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 35);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 298);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt İşlemi";
            this.Load += new System.EventHandler(this.frmOgrKayit_Load);
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydet;
    }
}

