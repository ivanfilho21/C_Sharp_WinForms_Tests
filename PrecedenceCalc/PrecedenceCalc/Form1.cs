using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrecedenceCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            Decode();
        }

        private void Decode()
        {
            string times = "*", obelus = "/", plus = "+", minus = "-";
            string txt = inputTextBox.Text;

            StringBuilder sb = new StringBuilder();
            // Low precedence symbols
            char[] lpRegex = sb.Append("[").Append(plus).Append(minus).Append("]").ToString().ToCharArray();
            sb = new StringBuilder();
            // High precedence symbols
            char[] hpRegex = sb.Append("[").Append(times).Append(obelus).Append("]").ToString().ToCharArray();

            string[] exp = null;

            // 2 * 1 + 2 - 3
            // Debugging
            resultLabel.Text = "";

            // tentar um loop
            for ( ; ; )
            {
                if (ContainsRegex(txt, lpRegex))
                {
                    string[] txtSplit = txt.Split(lpRegex);
                    if (txtSplit.Length <= 1) return;

                    for (var j = 0; j < txtSplit.Length; j++)
                    {
                        if (ContainsRegex(txtSplit[j], lpRegex)) ;
                    }


                }
                else if (ContainsRegex(txt, hpRegex))
                {
                    // caso não possua - ou +, ...
                }
                else
                {
                    break;
                }
            }


            if ( ContainsRegex(txt, lpRegex) )
            {
                // It could contain one of them, both or even all operands.
                string[] aux = txt.Split(lpRegex);

                // Debugging
                for (var i = 0; i < aux.Length; i++)
                    resultLabel.Text += ": " + aux[i] + "\n";
            }
            else
            {
                // There is only minus, plus or none.
                
            }
        }

        private bool ContainsRegex(string src, char[] regex)
        {
            for (var i = 0; i < regex.Length; i++)
            {
                if (src.Contains( regex[i].ToString() )) return true;
            }
            return false;
        }

        // Retuns the index of regex
        private int get(string src, char[] regex)
        {

            return -1; // no index
        }
    }
}
