using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordListMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] karakterler = new String[] { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "w", "q", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        String kelime;
       

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            int karakteruz = karakterler.Length;
            String yol=textBox1.Text+"\\"+textBox2.Text+".txt";
            FileStream fs = new FileStream(yol, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            btnOlustur.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            if (numericUpDown2.Value < 2)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    sw.WriteLine(karakterler[i]);
                    sw.Flush();
                }
            }

            if (numericUpDown1.Value > 1 && numericUpDown2.Value<3)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    for (int j = 0; j < karakteruz; j++)
                    {
                        kelime = karakterler[i] + karakterler[j];
                        sw.WriteLine(kelime);
                        sw.Flush();
                    }
                }
            }
            if (numericUpDown1.Value > 2 && numericUpDown2.Value<4)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    for (int j = 0; j < karakteruz; j++)
                    {
                        for (int k = 0; k < karakteruz; k++)
                        {
                            kelime = karakterler[i] + karakterler[j] + karakterler[k];
                            sw.WriteLine(kelime);
                            sw.Flush();
                        }
                    }
                }
            }
            if (numericUpDown1.Value > 3 && numericUpDown2.Value < 5)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    for (int j = 0; j < karakteruz; j++)
                    {
                        for (int k = 0; k < karakteruz; k++)
                        {
                            for (int l = 0; l < karakteruz; l++)
                            {
                                kelime = karakterler[i] + karakterler[j] + karakterler[k] + karakterler[l];
                                sw.WriteLine(kelime);
                                sw.Flush();
                            }
                        }
                    }
                }
            }
            if (numericUpDown1.Value > 4 && numericUpDown2.Value < 6)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    for (int j = 0; j < karakteruz; j++)
                    {
                        for (int k = 0; k < karakteruz; k++)
                        {
                            for (int l = 0; l < karakteruz; l++)
                            {
                                for (int m = 0; m < karakteruz; m++)
                                {
                                    kelime = karakterler[i] + karakterler[j] + karakterler[k] + karakterler[l] + karakterler[m];
                                    sw.WriteLine(kelime);
                                    sw.Flush();
                                }

                            }
                        }
                    }
                }
            }
            if (numericUpDown1.Value > 5 && numericUpDown2.Value < 7)
            {
                for (int i = 0; i < karakteruz; i++)
                {
                    for (int j = 0; j < karakteruz; j++)
                    {
                        for (int k = 0; k < karakteruz; k++)
                        {
                            for (int l = 0; l < karakteruz; l++)
                            {
                                for (int m = 0; m < karakteruz; m++)
                                {
                                    for (int s = 0; s < karakteruz; s++)
                                    {
                                        kelime = karakterler[i] + karakterler[j] + karakterler[k] + karakterler[l] + karakterler[m] + karakterler[s];
                                        sw.WriteLine(kelime);
                                        sw.Flush();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            sw.Close();
            fs.Close();
            MessageBox.Show("Word List Oluşturma Başarılı");
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            btnOlustur.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = numericUpDown2.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = numericUpDown1.Value;
        }
    }
}
