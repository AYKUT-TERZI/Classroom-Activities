namespace WindowsFormsApp1
{
    partial class Form1
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkBoxBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkBoxRakam = new System.Windows.Forms.CheckBox();
            this.chkBoxOzelKarakter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrcUpDownSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrcUpDownSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.btnUret = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.btnUret);
            this.grpBox1.Controls.Add(this.nmrcUpDownSifreUzunlugu);
            this.grpBox1.Controls.Add(this.nmrcUpDownSifreSayisi);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.chkBoxOzelKarakter);
            this.grpBox1.Controls.Add(this.chkBoxRakam);
            this.grpBox1.Controls.Add(this.chkBoxBuyukHarf);
            this.grpBox1.Controls.Add(this.chkBoxKucukHarf);
            this.grpBox1.Location = new System.Drawing.Point(13, 13);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(395, 425);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "PARAMETRELER";
            // 
            // chkBoxKucukHarf
            // 
            this.chkBoxKucukHarf.AutoSize = true;
            this.chkBoxKucukHarf.Location = new System.Drawing.Point(73, 38);
            this.chkBoxKucukHarf.Name = "chkBoxKucukHarf";
            this.chkBoxKucukHarf.Size = new System.Drawing.Size(93, 20);
            this.chkBoxKucukHarf.TabIndex = 0;
            this.chkBoxKucukHarf.Text = "Küçük Harf";
            this.chkBoxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBoxBuyukHarf
            // 
            this.chkBoxBuyukHarf.AutoSize = true;
            this.chkBoxBuyukHarf.Location = new System.Drawing.Point(73, 79);
            this.chkBoxBuyukHarf.Name = "chkBoxBuyukHarf";
            this.chkBoxBuyukHarf.Size = new System.Drawing.Size(94, 20);
            this.chkBoxBuyukHarf.TabIndex = 1;
            this.chkBoxBuyukHarf.Text = "Büyük Harf";
            this.chkBoxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkBoxRakam
            // 
            this.chkBoxRakam.AutoSize = true;
            this.chkBoxRakam.Location = new System.Drawing.Point(73, 124);
            this.chkBoxRakam.Name = "chkBoxRakam";
            this.chkBoxRakam.Size = new System.Drawing.Size(73, 20);
            this.chkBoxRakam.TabIndex = 2;
            this.chkBoxRakam.Text = "Rakam";
            this.chkBoxRakam.UseVisualStyleBackColor = true;
            // 
            // chkBoxOzelKarakter
            // 
            this.chkBoxOzelKarakter.AutoSize = true;
            this.chkBoxOzelKarakter.Location = new System.Drawing.Point(73, 167);
            this.chkBoxOzelKarakter.Name = "chkBoxOzelKarakter";
            this.chkBoxOzelKarakter.Size = new System.Drawing.Size(109, 20);
            this.chkBoxOzelKarakter.TabIndex = 3;
            this.chkBoxOzelKarakter.Text = "Özel Karakter";
            this.chkBoxOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre Uzunluğu:";
            // 
            // nmrcUpDownSifreSayisi
            // 
            this.nmrcUpDownSifreSayisi.Location = new System.Drawing.Point(233, 262);
            this.nmrcUpDownSifreSayisi.Name = "nmrcUpDownSifreSayisi";
            this.nmrcUpDownSifreSayisi.Size = new System.Drawing.Size(120, 22);
            this.nmrcUpDownSifreSayisi.TabIndex = 6;
            // 
            // nmrcUpDownSifreUzunlugu
            // 
            this.nmrcUpDownSifreUzunlugu.Location = new System.Drawing.Point(233, 303);
            this.nmrcUpDownSifreUzunlugu.Name = "nmrcUpDownSifreUzunlugu";
            this.nmrcUpDownSifreUzunlugu.Size = new System.Drawing.Size(120, 22);
            this.nmrcUpDownSifreUzunlugu.TabIndex = 7;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(106, 357);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(247, 50);
            this.btnUret.TabIndex = 8;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(427, 22);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(349, 404);
            this.lstBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.grpBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcUpDownSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.NumericUpDown nmrcUpDownSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nmrcUpDownSifreSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxOzelKarakter;
        private System.Windows.Forms.CheckBox chkBoxRakam;
        private System.Windows.Forms.CheckBox chkBoxBuyukHarf;
        private System.Windows.Forms.CheckBox chkBoxKucukHarf;
        private System.Windows.Forms.ListBox lstBox;
    }
}

