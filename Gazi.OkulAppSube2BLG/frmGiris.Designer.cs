namespace Gazi.OkulAppSube2BLG
{
    partial class frmGiris
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
            this.btnOgrenciKayit = new System.Windows.Forms.Button();
            this.btnOgretmenKayit = new System.Windows.Forms.Button();
            this.btn_bul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapılmak İstenilen İşlemi Seçiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOgrenciKayit
            // 
            this.btnOgrenciKayit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOgrenciKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciKayit.Location = new System.Drawing.Point(56, 78);
            this.btnOgrenciKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOgrenciKayit.Name = "btnOgrenciKayit";
            this.btnOgrenciKayit.Size = new System.Drawing.Size(232, 63);
            this.btnOgrenciKayit.TabIndex = 1;
            this.btnOgrenciKayit.Text = "ÖĞRENCİ KAYIT";
            this.btnOgrenciKayit.UseVisualStyleBackColor = false;
            this.btnOgrenciKayit.Click += new System.EventHandler(this.btnOgrenciKayit_Click);
            // 
            // btnOgretmenKayit
            // 
            this.btnOgretmenKayit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgretmenKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenKayit.Location = new System.Drawing.Point(56, 178);
            this.btnOgretmenKayit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOgretmenKayit.Name = "btnOgretmenKayit";
            this.btnOgretmenKayit.Size = new System.Drawing.Size(232, 63);
            this.btnOgretmenKayit.TabIndex = 2;
            this.btnOgretmenKayit.Text = "ÖĞRETMEN KAYIT";
            this.btnOgretmenKayit.UseVisualStyleBackColor = false;
            this.btnOgretmenKayit.Click += new System.EventHandler(this.btnOgretmenKayit_Click);
            // 
            // btn_bul
            // 
            this.btn_bul.BackColor = System.Drawing.SystemColors.Info;
            this.btn_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bul.Location = new System.Drawing.Point(56, 276);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(232, 63);
            this.btn_bul.TabIndex = 3;
            this.btn_bul.Text = "Kişi Bul";
            this.btn_bul.UseVisualStyleBackColor = false;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 366);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.btnOgretmenKayit);
            this.Controls.Add(this.btnOgrenciKayit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiris";
            this.Text = "Öğrenci/Öğretmen Kayıt İşlemi Seçimi";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciKayit;
        private System.Windows.Forms.Button btnOgretmenKayit;
        private System.Windows.Forms.Button btn_bul;
    }
}