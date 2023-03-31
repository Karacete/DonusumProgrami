using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DönüsümProgramiOdev
{
    public partial class Form1 : Form
    {

        double deger, sonuc;
        double inch, foot, yarda, karaMili;
        double kw, kcal, ps;
        double psi, bar;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text= comboBox4.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            kw = 0.0098;
            kcal = 0.00234;
            ps = 0.0133;
            deger= Convert.ToDouble(textBox6.Text);
            if (comboBox3.SelectedIndex == 0 && comboBox4.SelectedIndex == 0)
            {
                sonuc = deger;
            }
            else if (comboBox3.SelectedIndex == 0 && comboBox4.SelectedIndex == 1)
            {
                sonuc = deger * kw;
            }
            else if(comboBox3.SelectedIndex == 0 && comboBox4.SelectedIndex == 2)
            {
                sonuc = deger * kcal;
            }
            else if(comboBox3.SelectedIndex == 0 && comboBox4.SelectedIndex == 3)
            {
                sonuc = deger * ps;
            }
            if(comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 0)
            {
                sonuc = (deger / kw);
            }
            else if(comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 1)
            {
                sonuc = deger;
            }
            else if(comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 2)
            {
                sonuc = (deger / kw) * kcal;
            }
            else if(comboBox3.SelectedIndex == 1 && comboBox4.SelectedIndex == 3)
            {
                sonuc=(deger/kw) * ps;
            }
            if(comboBox3.SelectedIndex == 2 && comboBox4.SelectedIndex == 0)
            {
                sonuc = deger / kcal;
            }
            else if(comboBox3.SelectedIndex == 2 && comboBox4.SelectedIndex == 1)
            {
                sonuc = (deger / kcal) * kw;
            }
            else if(comboBox3.SelectedIndex == 2 && comboBox4.SelectedIndex == 2)
            {
                sonuc = deger;
            }
            else if(comboBox3.SelectedIndex == 2 && comboBox4.SelectedIndex == 3)
            {
                sonuc =(deger/kw) * ps;
            }
            if(comboBox3.SelectedIndex == 3 && comboBox4.SelectedIndex == 0)
            {
                sonuc = deger / ps;
            }
            else if(comboBox3.SelectedIndex == 3 && comboBox4.SelectedIndex == 1)
            {
                sonuc = (deger / ps) * kw;
            }
            else if(comboBox3.SelectedIndex == 3 && comboBox4.SelectedIndex == 2)
            {
                sonuc = (deger / ps) * kcal;
            }
            else if(comboBox3.SelectedIndex == 3 && comboBox4.SelectedIndex == 3)
            {
                sonuc = deger;
            }
            textBox8.Text=Convert.ToString(sonuc);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox2.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            inch = 39.3701;
            foot = 3.28084;
            yarda = 1.09361;
            karaMili = 0.00062137;
            deger = Convert.ToDouble(textBox2.Text);
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                sonuc = deger;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                sonuc = deger * inch;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                sonuc = deger * foot;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                sonuc = deger * yarda;
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 4)
            {
                sonuc = deger * karaMili;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                sonuc = deger / inch;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                sonuc = deger;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                sonuc = (deger / inch) * foot;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 3)
            {
                sonuc = (deger / inch) * yarda;
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 4)
            {
                sonuc = (deger / inch) * karaMili;
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                sonuc = (deger / foot);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                sonuc = (deger / foot) * inch;
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                sonuc = deger;
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 3)
            {
                sonuc = (deger / foot) * yarda;
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 4)
            {
                sonuc = (deger / foot) * karaMili;
            }
            if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                sonuc = deger / yarda;
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 1)
            {
                sonuc = (deger / yarda) * inch;
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 2)
            {
                sonuc = (deger / yarda) * foot;
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 3)
            {
                sonuc = deger;
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 4)
            {
                sonuc = (deger / yarda) * karaMili;
            }
            if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 0)
            {
                sonuc = deger / karaMili;
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 1)
            {
                sonuc = (deger / karaMili) * inch;
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 2)
            {
                sonuc = (deger / karaMili) * foot;
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 3)
            {
                sonuc = (deger / karaMili) * yarda;
            }
            else if (comboBox1.SelectedIndex == 4 && comboBox2.SelectedIndex == 4)
            {
                sonuc = deger;
            }
            textBox4.Text=Convert.ToString(sonuc);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox9.Text = comboBox5.Text;
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = comboBox6.Text;
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            psi = 14.65;
            bar = 1.01;
            deger = Convert.ToDouble(textBox10.Text);
            if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 0)
            {
                sonuc = deger;
            }
            else if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 1)
            {
                sonuc = (deger * psi);
            }
            else if (comboBox5.SelectedIndex == 0 && comboBox6.SelectedIndex == 2)
            {
                sonuc = (deger * bar);
            }
            if (comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 0)
            {
                sonuc = deger / psi;
            }
            else if(comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 1)
            {
                sonuc = deger;
            }
            else if(comboBox5.SelectedIndex == 1 && comboBox6.SelectedIndex == 2)
            {
                sonuc = (deger / psi) * bar;
            }
            if(comboBox5.SelectedIndex == 2 && comboBox6.SelectedIndex == 0)
            {
                sonuc = deger / bar;
            }
            else if(comboBox5.SelectedIndex == 2 && comboBox6.SelectedIndex == 1)
            {
                sonuc = (deger / bar) * psi;
            }
            else if(comboBox5.SelectedIndex == 2 && comboBox6.SelectedIndex == 2)
            {
                sonuc = deger;
            }
            textBox12.Text=Convert.ToString(sonuc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
