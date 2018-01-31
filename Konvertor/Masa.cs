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
           string[] Mjere = new string[]{"Kilogram", "Gram", "Miligram", "Tona"};
           float p1 = float.Parse(textBox1.Text);
                switch(comboBox1.Text){
                    case "Kilogram":
                        {
                             switch(comboBox2.Text)
                             {
                                 case "Kilogram":
                                     textBox2.Text=p1.ToString();
                                     break;
                                 case "Gram":
                                     textBox2.Text=(p1*1000).ToString();
                                     break;
                                 case "Miligram":
                                      textBox2.Text=(p1*1000000).ToString();
                                     break;
                                 case "Tona":
                                      textBox2.Text=(p1*0.001).ToString();
                                     break;
                                 default: textBox2.Text="";
                                     break;

                             }
                             break;
                        }


                    case "Gram":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilogram":
                                    textBox2.Text = (p1 * 0.001).ToString();
                                    break;
                                case "Gram":
                                    textBox2.Text = p1.ToString();
                                    break;
                                case "Miligram":
                                    textBox2.Text = (p1 * 1000).ToString();
                                    break;
                                case "Tona":
                                    textBox2.Text = (p1 * 0.000001).ToString();
                                    break;
                                default: textBox2.Text = "";
                                    break;

                            }
                            break;
                        }
                    case "Miligram":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilogram":
                                    textBox2.Text = (p1 * 0.000001).ToString();
                                    break;
                                case "Gram":
                                    textBox2.Text =(p1 * 0.001).ToString();
                                    break;
                                case "Miligram":
                                    textBox2.Text =p1.ToString(); 
                                    break;
                                case "Tona":
                                    textBox2.Text = (p1 * 0.000000001).ToString();
                                    break;
                                default: textBox2.Text = "";
                                    break;

                            }
                            break;
                        }
                    case "Tona":
                        {
                            switch (comboBox2.Text)
                            {
                                case "Kilogram":
                                    textBox2.Text = (p1 * 1000).ToString();
                                    break;
                                case "Gram":
                                    textBox2.Text = (p1 * 1000000).ToString();
                                    break;
                                case "Miligram":
                                    textBox2.Text = (p1 * 1000000000).ToString();
                                    break;
                                case "Tona":
                                    textBox2.Text = p1.ToString();
                                    break;
                                default: textBox2.Text = "";
                                    break;

                            }
                            break;
                        }
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float f;
            if (float.TryParse(textBox1.Text, out f))
            {
                Konvertuj();
            }
            else 
            {
                MessageBox.Show("Količina mora biti broj!");
                textBox1.Focus();
                return;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
