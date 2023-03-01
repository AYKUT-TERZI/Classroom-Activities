namespace TelefonUygulamasi
{
    partial class TelefonDuzenle
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
            this.txtBoxMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxYil = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnHurda = new System.Windows.Forms.RadioButton();
            this.rdBtnKullanimda = new System.Windows.Forms.RadioButton();
            this.rdBtnSatista = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka:";
            // 
            // txtBoxMarka
            // 
            this.txtBoxMarka.Location = new System.Drawing.Point(90, 30);
            this.txtBoxMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxMarka.Name = "txtBoxMarka";
            this.txtBoxMarka.Size = new System.Drawing.Size(219, 20);
            this.txtBoxMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(90, 74);
            this.txtBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(219, 20);
            this.txtBoxModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıl:";
            // 
            // txtBoxYil
            // 
            this.txtBoxYil.Location = new System.Drawing.Point(90, 119);
            this.txtBoxYil.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxYil.Name = "txtBoxYil";
            this.txtBoxYil.Size = new System.Drawing.Size(219, 20);
            this.txtBoxYil.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnHurda);
            this.groupBox1.Controls.Add(this.rdBtnKullanimda);
            this.groupBox1.Controls.Add(this.rdBtnSatista);
            this.groupBox1.Location = new System.Drawing.Point(37, 184);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(272, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durumu";
            // 
            // rdBtnHurda
            // 
            this.rdBtnHurda.AutoSize = true;
            this.rdBtnHurda.Location = new System.Drawing.Point(218, 31);
            this.rdBtnHurda.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnHurda.Name = "rdBtnHurda";
            this.rdBtnHurda.Size = new System.Drawing.Size(54, 17);
            this.rdBtnHurda.TabIndex = 2;
            this.rdBtnHurda.TabStop = true;
            this.rdBtnHurda.Text = "Hurda";
            this.rdBtnHurda.UseVisualStyleBackColor = true;
            // 
            // rdBtnKullanimda
            // 
            this.rdBtnKullanimda.AutoSize = true;
            this.rdBtnKullanimda.Location = new System.Drawing.Point(105, 31);
            this.rdBtnKullanimda.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnKullanimda.Name = "rdBtnKullanimda";
            this.rdBtnKullanimda.Size = new System.Drawing.Size(76, 17);
            this.rdBtnKullanimda.TabIndex = 1;
            this.rdBtnKullanimda.TabStop = true;
            this.rdBtnKullanimda.Text = "Kullanımda";
            this.rdBtnKullanimda.UseVisualStyleBackColor = true;
            // 
            // rdBtnSatista
            // 
            this.rdBtnSatista.AutoSize = true;
            this.rdBtnSatista.Location = new System.Drawing.Point(5, 31);
            this.rdBtnSatista.Margin = new System.Windows.Forms.Padding(2);
            this.rdBtnSatista.Name = "rdBtnSatista";
            this.rdBtnSatista.Size = new System.Drawing.Size(57, 17);
            this.rdBtnSatista.TabIndex = 0;
            this.rdBtnSatista.TabStop = true;
            this.rdBtnSatista.Text = "Satışta";
            this.rdBtnSatista.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(360, 30);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 173);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(360, 223);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 19);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(429, 223);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(77, 19);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Location = new System.Drawing.Point(514, 223);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 19);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TelefonDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMarka);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelefonDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelefonDuzenle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelefonDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxYil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnHurda;
        private System.Windows.Forms.RadioButton rdBtnKullanimda;
        private System.Windows.Forms.RadioButton rdBtnSatista;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.ListBox listBox1;
    }
}