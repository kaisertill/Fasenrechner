using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fasenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Hallo Armin!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Alle Werte löschen..
            textBox1.Text = (null);
            textBox2.Text = (null);
            textBox3.Text = (null);
            textBox4.Text = (null);
            textBox5.Text = (null);
            textBox6.Text = (null);
            textBox7.Text = (null);
            textBox8.Text = (null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Convertieren in Dezimalzahlen zum rechnen
            double Value1;
            double Value2;
            double Value3;
            double Value4;
            double angle = 0;
            double xabs = 0;
            double xinc = 0;
            double z = 0;
            if (Double.TryParse(textBox1.Text, out Value1))
                angle += Value1;
            if (Double.TryParse(textBox2.Text, out Value2))
                z += Value2;
            if (Double.TryParse(textBox3.Text, out Value3))
                xabs += Value3;
            if (Double.TryParse(textBox4.Text, out Value4))
                xinc += Value4;

            if (textBox1.Text != null && textBox2.Text != null) 
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 

}
