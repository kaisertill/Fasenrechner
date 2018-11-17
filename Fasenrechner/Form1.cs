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

        private void button2_Click(object sender, EventArgs e) //Reset Knopf gedrückt
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

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Start Knopf gedrückt
        {
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

            if (textBox1.Text != (null) && textBox2.Text != (null))//Ausrechnen der X-Werte, bei eigabe von Winkel und Z-Wert
            {
                xinc = Math.Tanh(angle) * z;
                textBox8.Text = Convert.ToString(xinc);
                xabs = xinc * 2;
                textBox7.Text = Convert.ToString(xabs);
                textBox5.Text = Convert.ToString(angle);
                textBox6.Text = Convert.ToString(z);
            }
            else if (textBox1.Text != (null) && textBox3.Text !=(null))//Ausrechnen des Z-Werts, bei eingabe von Winkel und Xabs-Wert
            {
                z = (xinc / (Math.Tanh(angle)));
                textBox6.Text = Convert.ToString(z);
                xabs = xinc * 2;
                textBox7.Text = Convert.ToString(xabs);
                textBox5.Text = Convert.ToString(angle);
                textBox8.Text = Convert.ToString(xinc);
            }
            else if (textBox1.Text != (null) && textBox4.Text != (null))//Ausrechnen des Z-Werts, bei eingabe von Winkel und Xinc-Wert
            {
                xinc = xabs / 2;
                z = (xinc / (Math.Tanh(angle)));
                textBox6.Text = Convert.ToString(z);
                textBox7.Text = Convert.ToString(xabs);
                textBox5.Text = Convert.ToString(angle);
                textBox8.Text = Convert.ToString(xinc);
            }
            else if (textBox2.Text != (null) && textBox3.Text != (null))//Ausrechnen des Winkels, bei eingabe von Z-Wert und Xabs-Wert
            {
                xinc = xabs / 2;
                angle = Math.Tan(xinc / z);
                textBox5.Text = Convert.ToString(angle);
                textBox6.Text = Convert.ToString(z);
                textBox7.Text = Convert.ToString(xabs);
                textBox8.Text = Convert.ToString(xinc);
            }
            else if (textBox2.Text != (null) && textBox3.Text != (null))//Ausrechnen des Winkels, bei eingabe von Z-Wert und Xinc-Wert
            {
                xabs = xinc * 2;
                angle = Math.Tan(xinc / z);
                textBox5.Text = Convert.ToString(angle);
                textBox6.Text = Convert.ToString(z);
                textBox7.Text = Convert.ToString(xabs);
                textBox8.Text = Convert.ToString(xinc);
            }
            else
            {
                textBox5.Text = "!!!";
                textBox6.Text = "Synt@x";
                textBox7.Text = "Err0r";
                textBox8.Text = "!!!";
            }
        }
    }
 

}
