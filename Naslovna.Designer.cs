namespace Konvertor
{
    partial class Naslovna
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
            this.sviKonvertoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dužinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sviKonvertoriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sviKonvertoriToolStripMenuItem
            // 
            this.sviKonvertoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaToolStripMenuItem,
            this.dužinaToolStripMenuItem});
            this.sviKonvertoriToolStripMenuItem.Name = "sviKonvertoriToolStripMenuItem";
            this.sviKonvertoriToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.sviKonvertoriToolStripMenuItem.Text = "Svi konvertori";
            // 
            // masaToolStripMenuItem
            // 
            this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
            this.masaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.masaToolStripMenuItem.Text = "Masa";
            this.masaToolStripMenuItem.Click += new System.EventHandler(this.masaToolStripMenuItem_Click_1);
            // 
            // dužinaToolStripMenuItem
            // 
            this.dužinaToolStripMenuItem.Name = "dužinaToolStripMenuItem";
            this.dužinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dužinaToolStripMenuItem.Text = "Dužina";
            this.dužinaToolStripMenuItem.Click += new System.EventHandler(this.dužinaToolStripMenuItem_Click_1);
            // 
            // Naslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 304);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Naslovna";
            this.Text = "KONVERTOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sviKonvertoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dužinaToolStripMenuItem;

    }
}