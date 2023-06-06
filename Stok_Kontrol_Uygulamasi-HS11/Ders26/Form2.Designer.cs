namespace Ders26
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxUrunId = new TextBox();
            txtBoxUrunIsmi = new TextBox();
            txtBoxUrunFiyati = new TextBox();
            nmrUdUrunAdeti = new NumericUpDown();
            btnKaydet = new Button();
            label5 = new Label();
            cmbBoxUrunTipi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrUdUrunAdeti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Ürün Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 121);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Ürün İsmi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 192);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 2;
            label3.Text = "Ürün Fiyati:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 263);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 3;
            label4.Text = "Ürün Adeti:";
            // 
            // txtBoxUrunId
            // 
            txtBoxUrunId.Location = new Point(259, 46);
            txtBoxUrunId.Name = "txtBoxUrunId";
            txtBoxUrunId.Size = new Size(200, 39);
            txtBoxUrunId.TabIndex = 4;
            // 
            // txtBoxUrunIsmi
            // 
            txtBoxUrunIsmi.Location = new Point(259, 118);
            txtBoxUrunIsmi.Name = "txtBoxUrunIsmi";
            txtBoxUrunIsmi.Size = new Size(200, 39);
            txtBoxUrunIsmi.TabIndex = 5;
            // 
            // txtBoxUrunFiyati
            // 
            txtBoxUrunFiyati.Location = new Point(259, 192);
            txtBoxUrunFiyati.Name = "txtBoxUrunFiyati";
            txtBoxUrunFiyati.Size = new Size(200, 39);
            txtBoxUrunFiyati.TabIndex = 6;
            // 
            // nmrUdUrunAdeti
            // 
            nmrUdUrunAdeti.Location = new Point(258, 265);
            nmrUdUrunAdeti.Name = "nmrUdUrunAdeti";
            nmrUdUrunAdeti.Size = new Size(201, 39);
            nmrUdUrunAdeti.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(92, 401);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(367, 46);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 331);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 9;
            label5.Text = "Ürün Tipi:";
            // 
            // cmbBoxUrunTipi
            // 
            cmbBoxUrunTipi.FormattingEnabled = true;
            cmbBoxUrunTipi.Items.AddRange(new object[] { "Gida", "Giyim", "Hijyen", "Kirtasiye", "Makyaj", "Teknoloji" });
            cmbBoxUrunTipi.Location = new Point(256, 333);
            cmbBoxUrunTipi.Name = "cmbBoxUrunTipi";
            cmbBoxUrunTipi.Size = new Size(203, 40);
            cmbBoxUrunTipi.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 490);
            Controls.Add(cmbBoxUrunTipi);
            Controls.Add(label5);
            Controls.Add(btnKaydet);
            Controls.Add(nmrUdUrunAdeti);
            Controls.Add(txtBoxUrunFiyati);
            Controls.Add(txtBoxUrunIsmi);
            Controls.Add(txtBoxUrunId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nmrUdUrunAdeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxUrunId;
        private TextBox txtBoxUrunIsmi;
        private TextBox txtBoxUrunFiyati;
        private NumericUpDown nmrUdUrunAdeti;
        private Button btnKaydet;
        private Label label5;
        private ComboBox cmbBoxUrunTipi;
    }
}