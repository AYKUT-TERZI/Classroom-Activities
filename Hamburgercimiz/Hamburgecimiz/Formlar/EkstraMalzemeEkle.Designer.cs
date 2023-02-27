namespace Hamburgecimiz
{
    partial class EkstraMalzemeEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeyiKaydet = new System.Windows.Forms.Button();
            this.nmrUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkstraMalzemeyiKaydet);
            this.groupBox1.Controls.Add(this.nmrUpDownFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxEkstraMalzemeAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeyiKaydet
            // 
            this.btnEkstraMalzemeyiKaydet.Location = new System.Drawing.Point(20, 117);
            this.btnEkstraMalzemeyiKaydet.Name = "btnEkstraMalzemeyiKaydet";
            this.btnEkstraMalzemeyiKaydet.Size = new System.Drawing.Size(304, 81);
            this.btnEkstraMalzemeyiKaydet.TabIndex = 4;
            this.btnEkstraMalzemeyiKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            this.btnEkstraMalzemeyiKaydet.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeyiKaydet.Click += new System.EventHandler(this.btnEkstraMalzemeyiKaydet_Click);
            // 
            // nmrUpDownFiyat
            // 
            this.nmrUpDownFiyat.Location = new System.Drawing.Point(152, 72);
            this.nmrUpDownFiyat.Name = "nmrUpDownFiyat";
            this.nmrUpDownFiyat.Size = new System.Drawing.Size(172, 22);
            this.nmrUpDownFiyat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı:";
            // 
            // txtBoxEkstraMalzemeAdi
            // 
            this.txtBoxEkstraMalzemeAdi.Location = new System.Drawing.Point(152, 35);
            this.txtBoxEkstraMalzemeAdi.Name = "txtBoxEkstraMalzemeAdi";
            this.txtBoxEkstraMalzemeAdi.Size = new System.Drawing.Size(172, 22);
            this.txtBoxEkstraMalzemeAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı:";
            // 
            // EkstraMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EkstraMalzemeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EkstraMalzemeEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EkstraMalzemeEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDownFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkstraMalzemeyiKaydet;
        private System.Windows.Forms.NumericUpDown nmrUpDownFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEkstraMalzemeAdi;
        private System.Windows.Forms.Label label1;
    }
}