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
    public partial class Duzina : Form
    {
        public Duzina()
        {
            InitializeComponent();
        }
        public void Konvertuj()
        {
            float k = float.Parse(textBox1.Text);
            if (k < 0)
            {
                MessageBox.Show("Duzina ne moze biti negativna !!");
            }
            else
            {
                switch (comboBox1.Text)
                {
                    case "Kilometar":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilometar":
                                    textBox2.Text = k.ToString();
                                    break;
                                case "Metar":
                                    textBox2.Text = (k * 1000).ToString();
                                    break;
                                case "Decimetar":
                                    textBox2.Text = (k * 10000).ToString();
                                    break;
                                case "Centimetar":
                                    textBox2.Text = (k * 100000).ToString();
                                    break;
                                default:
                                    textBox2.Text = "Niste odabrali mjeru !";
                                    break;
                            }
                            break;
                        }
                    case "Metar":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilometar":
                                    textBox2.Text = (k * 0.001).ToString();
                                    break;
                                case "Metar":
                                    textBox2.Text = k.ToString();
                                    break;
                                case "Decimetar":
                                    textBox2.Text = (k * 10).ToString();
                                    break;
                                case "Centimetar":
                                    textBox2.Text = (k * 100).ToString();
                                    break;
                                default:
                                    textBox2.Text = "Niste odabrali mjeru! ";
                                    break;
                            }
                            break;
                        }
                    case "Decimetar":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilometrar":
                                    textBox2.Text = (k * 0.0001).ToString();
                                    break;
                                case "Metar":
                                    textBox2.Text = (k * 0.1).ToString();
                                    break;
                                case "Decimetar":
                                    textBox2.Text = k.ToString();
                                    break;
                                case "Centimetar":
                                    textBox2.Text = (k * 10).ToString();
                                    break;
                                default:
                                    textBox2.Text = "Niste odabrali mjeru!";
                                    break;
                            }
                            break;
                        }
                    case "Centimetar":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilometar":
                                    textBox2.Text = (k * 0.00001).ToString();
                                    break;
                                case "Decimetar":
                                    textBox2.Text = (k * 0.1).ToString();
                                    break;
                                case "Metar":
                                    textBox2.Text = (k * 0.01).ToString();
                                    break;
                                case "Centimetar":
                                    textBox2.Text = k.ToString();
                                    break;
                                default:
                                    textBox2.Text = "Niste odabrali mjeru !";
                                    break;
                            }
                            break;
                        }
                    default:
                        textBox2.Text = "Niste odabrali mjeru!";
                        break;
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p;
            if (float.TryParse(textBox1.Text, out p))
            {
                Konvertuj();
            }
            else
            {
               MessageBox.Show("Kolicina mora biti broj!");
                textBox1.Focus();
                return;
            }


        }
    }
}
