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
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {   //Konvertieren
            double Value1;
            double Value2;
            double Value3;
            double Value4;
            double angle = 0;
            double xabs = 0;
            double xinc = 0;
            double z = 0;
            double radians = 0;

            if (Double.TryParse(txtWinkelAlpha.Text, out Value1))
                angle = Value1;
            if (Double.TryParse(txt_ZWert.Text, out Value2))
                z = Value2;
            if (Double.TryParse(txt_XWertAbs.Text, out Value3))
                xabs = Value3;
            if (Double.TryParse(txt_XWertInc.Text, out Value4))
                xinc = Value4;

            if (txtWinkelAlpha.Text != "" && txt_ZWert.Text != "" && txt_XWertAbs.Text == "" && txt_XWertInc.Text == "")//Ausrechnen der X-Werte, bei eigabe von Winkel und Z-Wert
            {
                radians = Radians(angle);
                xinc = Math.Tan(radians) * z;
                Ergebnisse(xinc, angle, z);
            }
            else if (txtWinkelAlpha.Text != "" && txt_XWertInc.Text != "" && txt_ZWert.Text == "" && txt_XWertAbs.Text == "" ) //Ausrechnen des Z-Werts, bei eingabe von Winkel und Xinc-Wert
            {
                radians = Radians(angle);
                z = Z(xinc, radians) ;
                Ergebnisse(xinc, angle, z);
            }
            else if (txtWinkelAlpha.Text != "" && txt_XWertAbs.Text != "" && txt_XWertInc.Text == "" && txt_ZWert.Text == "")//Ausrechnen des Z-Werts, bei eingabe von Winkel und Xabs-Wert
            {
                xinc = Xdefinition(xabs);
                radians = Radians(angle);
                z = Z(xinc, radians);
                Ergebnisse(xinc, angle, z);
            }
            else if (txt_ZWert.Text != "" && txt_XWertInc.Text != "" && txt_XWertAbs.Text == "" && txtWinkelAlpha.Text == "")//Ausrechnen des Winkels, bei eingabe von Z-Wert und Xinc-Wert
            {
                angle = Winkel(xinc, z);
                Ergebnisse(xinc, angle, z);
            }
            else if (txt_ZWert.Text != "" && txt_XWertAbs.Text != "" && txt_XWertInc.Text == "" && txtWinkelAlpha.Text == "")//Ausrechnen des Winkels, bei eingabe von Z-Wert und Xabs-Wert
            {
                xinc = Xdefinition(xabs);
                Winkel(xinc, z);
                Ergebnisse(xinc, angle, z);
            }
            else if (txt_ZWert.Text == "I" && txt_XWertAbs.Text == "L" && txt_XWertInc.Text == "L" && txtWinkelAlpha.Text == "T")
            {
                txtResWinkelAlpha.Text = "!!!";
                txtRes_ZWert.Text = "h@xXx0r";
                txtRes_XWertAbs.Text = "SkiLlZz";
                txtRes_XWertInc.Text = "!!!";
            }
            else
            {
                txtResWinkelAlpha.Text = "!!!";
                txtRes_ZWert.Text = "Synt@x";
                txtRes_XWertAbs.Text = "Err0r";
                txtRes_XWertInc.Text = "!!!";
            }
            
        }

        private double Winkel(double x, double y)
        {
            return (Math.Atan(x / y) * 180 / Math.PI);
        }
        private double Xdefinition(double x)
        {
            return (x / 2);
        }
        private double Radians(double x)
        {
            return x * (Math.PI / 180);
        }
        private double Z(double x, double y)
        {
            return (x / (Math.Tan(y)));
        }

        private void Ergebnisse(double a, double b, double c)
        {
            txtRes_XWertInc.Text = Convert.ToString(a);
            txtRes_XWertAbs.Text = Convert.ToString(a * 2);
            txtResWinkelAlpha.Text = Convert.ToString(b);
            txtRes_ZWert.Text = Convert.ToString(c);
        }


        private void CmdReset_Click(object sender, EventArgs e)
        {
            // Eingabefelder leeren (durch Übergabe eines leeren Strings)
            txtWinkelAlpha.Text = "";
            txt_ZWert.Text = "";
            txt_XWertAbs.Text = "";
            txt_XWertInc.Text = "";

            // Ergebnisfelder leeren (durch Übergabe eines leeren Strings)
            txtResWinkelAlpha.Text = "";
            txtRes_ZWert.Text = "";
            txtRes_XWertAbs.Text = "";
            txtRes_XWertInc.Text = "";
        }
    }
}
   
