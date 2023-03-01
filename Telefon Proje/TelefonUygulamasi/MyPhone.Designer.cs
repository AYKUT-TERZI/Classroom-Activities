namespace TelefonUygulamasi
{
    partial class MyPhone
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.telefonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonlarıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonlarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // telefonlarToolStripMenuItem
            // 
            this.telefonlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonlarıDüzenleToolStripMenuItem,
            this.telefonlarıListeleToolStripMenuItem});
            this.telefonlarToolStripMenuItem.Name = "telefonlarToolStripMenuItem";
            this.telefonlarToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.telefonlarToolStripMenuItem.Text = "Telefonlar";
            // 
            // telefonlarıDüzenleToolStripMenuItem
            // 
            this.telefonlarıDüzenleToolStripMenuItem.Name = "telefonlarıDüzenleToolStripMenuItem";
            this.telefonlarıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.telefonlarıDüzenleToolStripMenuItem.Text = "Telefonları Düzenle";
            this.telefonlarıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.telefonlarıDüzenleToolStripMenuItem_Click);
            // 
            // telefonlarıListeleToolStripMenuItem
            // 
            this.telefonlarıListeleToolStripMenuItem.Name = "telefonlarıListeleToolStripMenuItem";
            this.telefonlarıListeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.telefonlarıListeleToolStripMenuItem.Text = "Telefonları Listele";
            this.telefonlarıListeleToolStripMenuItem.Click += new System.EventHandler(this.telefonlarıListeleToolStripMenuItem_Click);
            // 
            // MyPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyPhone";
            this.Text = "MyPhone";
            this.Load += new System.EventHandler(this.MyPhone_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem telefonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonlarıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonlarıListeleToolStripMenuItem;
    }
}

