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
        {
            double Value1;
            double Value2;
            double Value3;
            double Value4;
            double angle = 0;
            double xabs = 0;
            double xinc = 0;
            double z = 0;
            if (Double.TryParse(txtWinkelAlpha.Text, out Value1))
                angle += Value1;
            if (Double.TryParse(txt_ZWert.Text, out Value2))
                z += Value2;
            if (Double.TryParse(txt_XWertAbs.Text, out Value3))
                xabs += Value3;
            if (Double.TryParse(txt_XWertInc.Text, out Value4))
                xinc += Value4;

            if (txtWinkelAlpha.Text != "" && txt_ZWert.Text != "" && txt_XWertInc.Text == "" && txt_XWertAbs.Text == "")//Ausrechnen der X-Werte, bei eigabe von Winkel und Z-Wert
            {
                xinc = Math.Tanh(angle) * z;
                txtRes_XWertInc.Text = Convert.ToString(xinc);
                xabs = xinc * 2;
                txtRes_XWertAbs.Text = Convert.ToString(xabs);
                txtResWinkelAlpha.Text = Convert.ToString(angle);
                txtRes_ZWert.Text = Convert.ToString(z);
            }
            else if (txtWinkelAlpha.Text != "" && txt_ZWert.Text == "" && txt_XWertInc.Text != "" && txt_XWertAbs.Text == "")//Ausrechnen des Z-Werts, bei eingabe von Winkel und Xinc-Wert
            {
                z = (xinc / (Math.Tan(angle)));
                txtRes_ZWert.Text = Convert.ToString(z);
                xabs = xinc * 2;
                txtRes_XWertAbs.Text = Convert.ToString(xabs);
                txtResWinkelAlpha.Text = Convert.ToString(angle);
                txtRes_XWertInc.Text = Convert.ToString(xinc);
            }
            else if (txtWinkelAlpha.Text != "" && txt_ZWert.Text == "" && txt_XWertInc.Text == "" && txt_XWertAbs.Text != "")//Ausrechnen des Z-Werts, bei eingabe von Winkel und Xabs-Wert
            {
                xinc = xabs / 2;
                z = (xinc / (Math.Tan(angle)));
                txtRes_ZWert.Text = Convert.ToString(z);
                txtRes_XWertAbs.Text = Convert.ToString(xabs);
                txtResWinkelAlpha.Text = Convert.ToString(angle);
                txtRes_XWertInc.Text = Convert.ToString(xinc);
            }
            else if (txtWinkelAlpha.Text == "" && txt_ZWert.Text != "" && txt_XWertInc.Text == "" && txt_XWertAbs.Text != "")// Ausrechnen des Winkels, bei eingabe von Z-Wert und Xabs-Wert
            {
                xinc = xabs / 2;
                angle = (Math.Atan(xinc/z) * 180 / Math.PI );
                txtResWinkelAlpha.Text = Convert.ToString(angle);
                txtRes_ZWert.Text = Convert.ToString(z);
                txtRes_XWertAbs.Text = Convert.ToString(xabs);
                txtRes_XWertInc.Text = Convert.ToString(xinc);
            }
            else if (txtWinkelAlpha.Text == "" && txt_ZWert.Text != "" && txt_XWertInc.Text != "" && txt_XWertAbs.Text == "")//Ausrechnen des Winkels, bei eingabe von Z-Wert und Xinc-Wert
            {
                xabs = xinc * 2;
                angle = Math.Atan(xinc/z) * 180 / Math.PI;
                txtResWinkelAlpha.Text = Convert.ToString(angle);
                txtRes_ZWert.Text = Convert.ToString(z);
                txtRes_XWertAbs.Text = Convert.ToString(xabs);
                txtRes_XWertInc.Text = Convert.ToString(xinc);
            }
            else
            {
                txtResWinkelAlpha.Text = "!!!";
                txtRes_ZWert.Text = "Synt@x";
                txtRes_XWertAbs.Text = "Err0r";
                txtRes_XWertInc.Text = "!!!";
            }
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
   
