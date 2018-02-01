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
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
            
                  }
        public void Konvertuj() 
        {
           float p1 = float.Parse(UnesiteKolicinu.Text);
                switch(PretvoriIz.Text)
                {
                    case "Kilogram":
                        {
                             switch(PretvoriU.Text)
                             {
                                 case "Kilogram":
                                     Rezultat.Text = p1.ToString();
                                     break;
                                 case "Gram":
                                     Rezultat.Text = (p1*1000).ToString();
                                     break;
                                 case "Miligram":
                                      Rezultat.Text = (p1*1000000).ToString();
                                     break;
                                 case "Tona":
                                      Rezultat.Text = (p1*0.001).ToString();
                                     break;
                                 default: Rezultat.Text = "Niste odabrali mjeru !";
                                     break;
                             }
                             break;
                        }
                    case "Gram":
                        {
                            switch (PretvoriU.Text)
                            {
                                case "Kilogram":
                                    Rezultat.Text = (p1 * 0.001).ToString();
                                    break;
                                case "Gram":
                                    Rezultat.Text = p1.ToString();
                                    break;
                                case "Miligram":
                                    Rezultat.Text = (p1 * 1000).ToString();
                                    break;
                                case "Tona":
                                    Rezultat.Text = (p1 * 0.000001).ToString();
                                    break;
                                default: Rezultat.Text = "Niste odabrali mjeru";
                                    break;

                            }
                            break;
                        }
                    case "Miligram":
                        {
                            switch (PretvoriU.Text)
                            {
                                case "Kilogram":
                                    Rezultat.Text = (p1 * 0.000001).ToString();
                                    break;
                                case "Gram":
                                    Rezultat.Text = (p1 * 0.001).ToString();
                                    break;
                                case "Miligram":
                                    Rezultat.Text = p1.ToString(); 
                                    break;
                                case "Tona":
                                    Rezultat.Text = (p1 * 0.000000001).ToString();
                                    break;
                                default: Rezultat.Text = "Niste odabrali mjeru";
                                    break;

                            }
                            break;
                        }
                    case "Tona":
                        {
                            switch (PretvoriU.Text)
                            {
                                case "Kilogram":
                                    Rezultat.Text = (p1 * 1000).ToString();
                                    break;
                                case "Gram":
                                    Rezultat.Text = (p1 * 1000000).ToString();
                                    break;
                                case "Miligram":
                                    Rezultat.Text = (p1 * 1000000000).ToString();
                                    break;
                                case "Tona":
                                    Rezultat.Text = p1.ToString();
                                    break;
                                default: Rezultat.Text = "Niste odabrali mjeru";
                                    break;

                            }
                            break;
                        }
                default:Rezultat.Text = "Niste odabrali mjeru !";
                    break;
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            if (float.TryParse(UnesiteKolicinu.Text, out f))
            {
                Konvertuj();
            }
            else 
            {
                MessageBox.Show("Količina mora biti broj!");
                UnesiteKolicinu.Focus();
                return;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PretvoriU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
