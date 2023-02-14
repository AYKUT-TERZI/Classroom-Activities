namespace WindowsFormsApp2
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
            this.rchTxt1 = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxt1
            // 
            this.rchTxt1.Location = new System.Drawing.Point(2, 1);
            this.rchTxt1.MaxLength = 255;
            this.rchTxt1.Name = "rchTxt1";
            this.rchTxt1.Size = new System.Drawing.Size(565, 177);
            this.rchTxt1.TabIndex = 0;
            this.rchTxt1.Text = "";
            this.rchTxt1.TextChanged += new System.EventHandler(this.rchTxt1_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(2, 185);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 213);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rchTxt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxt1;
        private System.Windows.Forms.Label lbl1;
    }
}

