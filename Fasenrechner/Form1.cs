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
            double angle;
            double xabs;
            double xinc;
            double z;
            angle = Convert.ToDouble(textBox1.Text);
            z = Convert.ToDouble(textBox2.Text);
            xabs = Convert.ToDouble(textBox3.Text);
            xinc = Convert.ToDouble(textBox4.Text);

            if(textBox1.Text != null && textBox2.Text != null) 
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 

}
