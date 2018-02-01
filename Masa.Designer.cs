namespace Konvertor
{
    partial class Masa
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
            this.label2 = new System.Windows.Forms.Label();
            this.PretvoriIz = new System.Windows.Forms.ComboBox();
            this.PretvoriU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UnesiteKolicinu = new System.Windows.Forms.TextBox();
            this.Rezultat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretvori IZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pretvori U";
            // 
            // PretvoriIz
            // 
            this.PretvoriIz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PretvoriIz.FormattingEnabled = true;
            this.PretvoriIz.Items.AddRange(new object[] {
            "Tona",
            "Kilogram",
            "Gram",
            "Miligram"});
            this.PretvoriIz.Location = new System.Drawing.Point(93, 27);
            this.PretvoriIz.Name = "PretvoriIz";
            this.PretvoriIz.Size = new System.Drawing.Size(180, 21);
            this.PretvoriIz.TabIndex = 3;
            this.PretvoriIz.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PretvoriU
            // 
            this.PretvoriU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PretvoriU.FormattingEnabled = true;
            this.PretvoriU.Items.AddRange(new object[] {
            "Tona",
            "Kilogram",
            "Gram",
            "Miligram"});
            this.PretvoriU.Location = new System.Drawing.Point(94, 68);
            this.PretvoriU.Name = "PretvoriU";
            this.PretvoriU.Size = new System.Drawing.Size(179, 21);
            this.PretvoriU.TabIndex = 4;
            this.PretvoriU.SelectedIndexChanged += new System.EventHandler(this.PretvoriU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "UNESITE \r\nKOLIČINU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "REZULTAT";
            // 
            // UnesiteKolicinu
            // 
            this.UnesiteKolicinu.Location = new System.Drawing.Point(96, 113);
            this.UnesiteKolicinu.Multiline = true;
            this.UnesiteKolicinu.Name = "UnesiteKolicinu";
            this.UnesiteKolicinu.Size = new System.Drawing.Size(176, 36);
            this.UnesiteKolicinu.TabIndex = 7;
            // 
            // Rezultat
            // 
            this.Rezultat.Location = new System.Drawing.Point(96, 262);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(176, 20);
            this.Rezultat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(131, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "PRETVORI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.UnesiteKolicinu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PretvoriU);
            this.Controls.Add(this.PretvoriIz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Masa";
            this.Text = "Masa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PretvoriIz;
        private System.Windows.Forms.ComboBox PretvoriU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnesiteKolicinu;
        private System.Windows.Forms.TextBox Rezultat;
        private System.Windows.Forms.Button button1;
    }
}

