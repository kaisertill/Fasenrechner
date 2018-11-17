namespace Fasenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtWinkelAlpha = new System.Windows.Forms.TextBox();
            this.txt_ZWert = new System.Windows.Forms.TextBox();
            this.txt_XWertAbs = new System.Windows.Forms.TextBox();
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.CmdReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_XWertInc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResWinkelAlpha = new System.Windows.Forms.TextBox();
            this.txtRes_ZWert = new System.Windows.Forms.TextBox();
            this.txtRes_XWertAbs = new System.Windows.Forms.TextBox();
            this.txtRes_XWertInc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtWinkelAlpha
            // 
            this.txtWinkelAlpha.Location = new System.Drawing.Point(584, 58);
            this.txtWinkelAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.txtWinkelAlpha.Name = "txtWinkelAlpha";
            this.txtWinkelAlpha.Size = new System.Drawing.Size(67, 22);
            this.txtWinkelAlpha.TabIndex = 1;
            // 
            // txt_ZWert
            // 
            this.txt_ZWert.Location = new System.Drawing.Point(584, 90);
            this.txt_ZWert.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ZWert.Name = "txt_ZWert";
            this.txt_ZWert.Size = new System.Drawing.Size(67, 22);
            this.txt_ZWert.TabIndex = 2;
            // 
            // txt_XWertAbs
            // 
            this.txt_XWertAbs.Location = new System.Drawing.Point(584, 122);
            this.txt_XWertAbs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_XWertAbs.Name = "txt_XWertAbs";
            this.txt_XWertAbs.Size = new System.Drawing.Size(67, 22);
            this.txt_XWertAbs.TabIndex = 3;
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(584, 198);
            this.CmdCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(100, 28);
            this.CmdCalculate.TabIndex = 4;
            this.CmdCalculate.Text = "Rechnen";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);

            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(709, 198);
            this.CmdReset.Margin = new System.Windows.Forms.Padding(4);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(100, 28);
            this.CmdReset.TabIndex = 5;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Winkel Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Z-Wert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X-Wert  (abs)";
            // 
            // txt_XWertInc
            // 
            this.txt_XWertInc.Location = new System.Drawing.Point(584, 154);
            this.txt_XWertInc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_XWertInc.Name = "txt_XWertInc";
            this.txt_XWertInc.Size = new System.Drawing.Size(67, 22);
            this.txt_XWertInc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "X-Wert  (inc)";
            // 
            // txtResWinkelAlpha
            // 
            this.txtResWinkelAlpha.Enabled = false;
            this.txtResWinkelAlpha.Location = new System.Drawing.Point(709, 58);
            this.txtResWinkelAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.txtResWinkelAlpha.Name = "txtResWinkelAlpha";
            this.txtResWinkelAlpha.Size = new System.Drawing.Size(67, 22);
            this.txtResWinkelAlpha.TabIndex = 14;
            // 
            // txtRes_ZWert
            // 
            this.txtRes_ZWert.Enabled = false;
            this.txtRes_ZWert.Location = new System.Drawing.Point(709, 90);
            this.txtRes_ZWert.Margin = new System.Windows.Forms.Padding(4);
            this.txtRes_ZWert.Name = "txtRes_ZWert";
            this.txtRes_ZWert.Size = new System.Drawing.Size(67, 22);
            this.txtRes_ZWert.TabIndex = 13;
            // 
            // txtRes_XWertAbs
            // 
            this.txtRes_XWertAbs.Enabled = false;
            this.txtRes_XWertAbs.Location = new System.Drawing.Point(709, 122);
            this.txtRes_XWertAbs.Margin = new System.Windows.Forms.Padding(4);
            this.txtRes_XWertAbs.Name = "txtRes_XWertAbs";
            this.txtRes_XWertAbs.Size = new System.Drawing.Size(67, 22);
            this.txtRes_XWertAbs.TabIndex = 12;
            // 
            // txtRes_XWertInc
            // 
            this.txtRes_XWertInc.Enabled = false;
            this.txtRes_XWertInc.Location = new System.Drawing.Point(709, 154);
            this.txtRes_XWertInc.Margin = new System.Windows.Forms.Padding(4);
            this.txtRes_XWertInc.Name = "txtRes_XWertInc";
            this.txtRes_XWertInc.Size = new System.Drawing.Size(67, 22);
            this.txtRes_XWertInc.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Eingabe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ergebnis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";

            this.label8.Size = new System.Drawing.Size(30, 13);

            this.label8.TabIndex = 18;
            this.label8.Text = "Grad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(779, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(779, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";

            this.label10.Size = new System.Drawing.Size(30, 13);

            this.label10.TabIndex = 20;
            this.label10.Text = "Grad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(653, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "mm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(779, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "mm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(779, 126);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "mm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 274);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResWinkelAlpha);
            this.Controls.Add(this.txtRes_ZWert);
            this.Controls.Add(this.txtRes_XWertAbs);
            this.Controls.Add(this.txtRes_XWertInc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_XWertInc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.CmdCalculate);
            this.Controls.Add(this.txt_XWertAbs);
            this.Controls.Add(this.txt_ZWert);
            this.Controls.Add(this.txtWinkelAlpha);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fasenrechner für Hammerwerfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtWinkelAlpha;
        private System.Windows.Forms.TextBox txt_ZWert;
        private System.Windows.Forms.TextBox txt_XWertAbs;
        private System.Windows.Forms.Button CmdCalculate;
        private System.Windows.Forms.Button CmdReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_XWertInc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResWinkelAlpha;
        private System.Windows.Forms.TextBox txtRes_ZWert;
        private System.Windows.Forms.TextBox txtRes_XWertAbs;
        private System.Windows.Forms.TextBox txtRes_XWertInc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

