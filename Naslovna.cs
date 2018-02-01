using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Konvertor
{
    public partial class Naslovna : Form
    {
        public Naslovna()
        {
            InitializeComponent();
        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dužinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void masaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Masa forma = new Masa();
            forma.Show();
            this.Opacity = 0;

        }

        private void dužinaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Duzina forma = new Duzina();
            forma.Show();
            this.Opacity = 0;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
