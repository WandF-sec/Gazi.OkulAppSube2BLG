namespace Gazi.OkulAppSube2BLG
{
    partial class frmKisiBul
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
            this.components = new System.ComponentModel.Container();
            this.btnOgrtBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.btnOgrenciBul = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.berkeOdevDataSet = new Gazi.OkulAppSube2BLG.BerkeOdevDataSet();
            this.berkeOdevDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.berkeOdevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.berkeOdevDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrtBul
            // 
            this.btnOgrtBul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrtBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrtBul.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOgrtBul.Location = new System.Drawing.Point(12, 235);
            this.btnOgrtBul.Name = "btnOgrtBul";
            this.btnOgrtBul.Size = new System.Drawing.Size(110, 41);
            this.btnOgrtBul.TabIndex = 0;
            this.btnOgrtBul.Text = "Bul";
            this.btnOgrtBul.UseVisualStyleBackColor = false;
            this.btnOgrtBul.Click += new System.EventHandler(this.btnOgrtBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOgrtTc);
            this.groupBox1.Controls.Add(this.txtOgrtSoyad);
            this.groupBox1.Controls.Add(this.txtOgrtAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(0, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(85, 126);
            this.txtOgrtTc.Multiline = true;
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(145, 29);
            this.txtOgrtTc.TabIndex = 2;
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(85, 82);
            this.txtOgrtSoyad.Multiline = true;
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(145, 29);
            this.txtOgrtSoyad.TabIndex = 1;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(85, 38);
            this.txtOgrtAd.Multiline = true;
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(145, 29);
            this.txtOgrtAd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOgrenciNo);
            this.groupBox2.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox2.Controls.Add(this.txtOgrenciAd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox2.Location = new System.Drawing.Point(276, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 177);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ogr No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ad";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(85, 126);
            this.txtOgrenciNo.Multiline = true;
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(145, 29);
            this.txtOgrenciNo.TabIndex = 2;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(85, 82);
            this.txtOgrenciSoyad.Multiline = true;
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(145, 29);
            this.txtOgrenciSoyad.TabIndex = 1;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(85, 38);
            this.txtOgrenciAd.Multiline = true;
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(145, 29);
            this.txtOgrenciAd.TabIndex = 0;
            // 
            // btnOgrenciBul
            // 
            this.btnOgrenciBul.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOgrenciBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciBul.Location = new System.Drawing.Point(276, 235);
            this.btnOgrenciBul.Name = "btnOgrenciBul";
            this.btnOgrenciBul.Size = new System.Drawing.Size(110, 41);
            this.btnOgrenciBul.TabIndex = 6;
            this.btnOgrenciBul.Text = "Bul";
            this.btnOgrenciBul.UseVisualStyleBackColor = false;
            this.btnOgrenciBul.Click += new System.EventHandler(this.btnOgrenciBul_Click);
            // 
            // dataview
            // 
            this.dataview.AutoGenerateColumns = false;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.DataSource = this.berkeOdevDataSetBindingSource;
            this.dataview.Location = new System.Drawing.Point(11, 302);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(494, 132);
            this.dataview.TabIndex = 8;
            // 
            // berkeOdevDataSet
            // 
            this.berkeOdevDataSet.DataSetName = "BerkeOdevDataSet";
            this.berkeOdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // berkeOdevDataSetBindingSource
            // 
            this.berkeOdevDataSetBindingSource.DataSource = this.berkeOdevDataSet;
            this.berkeOdevDataSetBindingSource.Position = 0;
            // 
            // frmKisiBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOgrenciBul);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOgrtBul);
            this.Name = "frmKisiBul";
            this.Text = "frmKisiBul";
            this.Load += new System.EventHandler(this.frmKisiBul_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.berkeOdevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.berkeOdevDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrtBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrtTc;
        private System.Windows.Forms.TextBox txtOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Button btnOgrenciBul;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.BindingSource berkeOdevDataSetBindingSource;
        private BerkeOdevDataSet berkeOdevDataSet;
    }
}