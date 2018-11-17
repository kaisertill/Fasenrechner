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
