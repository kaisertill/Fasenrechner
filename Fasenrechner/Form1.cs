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
            // Werte aus TextBoxen auslesen und in Variablen speichern
            double winkelAlpha, zWert, xWertAbs, xWertInc;
            winkelAlpha = Convert.ToDouble(txtWinkelAlpha.Text);
            zWert = Convert.ToDouble(txt_ZWert.Text);
            xWertAbs = Convert.ToDouble(txt_XWertAbs.Text);
            xWertInc = Convert.ToDouble(txt_XWertInc.Text);

            // Werte testweise in Ergebnisfelder eintragen
            // --> Konvertierung in von Doubles Strings mittels .ToString()-Methode
            txtResWinkelAlpha.Text = winkelAlpha.ToString();
            txtRes_ZWert.Text = zWert.ToString();
            txtRes_XWertAbs.Text = xWertAbs.ToString();
            txtRes_XWertInc.Text = xWertInc.ToString();

            // Ab hier können die Variablen zum Rechnen verwendet werden
            // (Am Ende übergeben von Ergebnisse an  Ergebnis-TextBoxen)
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
