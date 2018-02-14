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
    public partial class Povrsina : Form
    {
        public Povrsina()
        {
            InitializeComponent();
        }
        public void Konvertuj()
        {
            float p = float.Parse(textBox1.Text);
            if (p < 0)
            {
                MessageBox.Show("Površina ne može biti negativna !!");
            }
            else
            {
                switch (comboBox1.Text)
                {
                    case "Kvadratni kilometar":
                        switch (comboBox2.Text)
                        {
                            case "Hektar":
                                textBox2.Text = (p * 100).ToString();
                                break;
                            case "Kvadratni kilometar":
                                textBox2.Text = p.ToString();
                                break;
                            case "Ar":
                                textBox2.Text = (p * 10000).ToString();
                                break;
                            case "Kvadratni metar":
                                textBox2.Text = (p * 1000000).ToString();
                                break;
                            default:
                                textBox2.Text = "Niste unijeli mjeru!";
                                break;
                        }
                        break;
                    case "Hektar":
                        switch (comboBox2.Text)
                        {
                            case "Kvadratni kilometar":
                                textBox2.Text = (p * 0.01).ToString();
                                break;
                            case "Hektar":
                                textBox2.Text = p.ToString();
                                break;
                            case "Ar":
                                textBox2.Text = (p * 100).ToString();
                                break;
                            case "Kvadratni metar":
                                textBox2.Text = (p * 10000).ToString();
                                break;
                            default:
                                textBox2.Text = "Niste unijeli količinu !";
                                break;
                        }
                        break;
                    case "Ar":
                        switch (comboBox2.Text)
                        {
                            case "Kvadratni kilometar":
                                textBox2.Text = (p * 0.0001).ToString();
                                break;
                            case "Hektar":
                                textBox2.Text = (p * 0.01).ToString();
                                break;
                            case "Ar":
                                textBox2.Text = p.ToString();
                                break;
                            case "Kvadratni metar":
                                textBox2.Text = (p * 100).ToString();
                                break;
                            default:
                                textBox2.Text = "Niste unijeli mjeru !";
                                break;
                        }
                        break;
                    case "Kvadratni metar":
                        switch (comboBox2.Text)
                        {
                            case "Kvadratni kilometar":
                                textBox2.Text = (p * 0.000001).ToString();
                                break;
                            case "Hektar":
                                textBox2.Text = (p * 0.0001).ToString();
                                break;
                            case "Ar":
                                textBox2.Text = (p * 0.01).ToString();
                                break;
                            case "Kvadratni metar":
                                textBox2.Text = p.ToString();
                                break;
                            default:
                                textBox2.Text = "Niste unijeli mjeru !";
                                break;
                        }
                        break;
                    default:
                        textBox2.Text = "Niste unijeli mjeru!";
                        break;
                }
            }
            
         }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Povrsina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(float.TryParse(textBox1.Text, out float k))
            {
                Konvertuj();
            }
            else
            {
                MessageBox.Show("Niste unijeli broj!");
                textBox1.Focus();
                return;
            }

        }
    }
}
