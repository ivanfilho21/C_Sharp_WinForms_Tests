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
        private const char NULL_CHAR = ' ';
        private const string ERROR_MESSAGE = "Malformed Expression.";
        private const string PROGRAM_NAME = "Arithmetic Precedence Calculator";
        private char[] ALL_REGEX = { '+', '-', '*', '×', '/', '÷' };

        public Form1()
        {
            InitializeComponent();
            this.Text = PROGRAM_NAME;
        }

        // TODO: Accept parenthesis as precedence modifier.

        private void DoButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = RecursiveCalc(inputTextBox.Text);
        }

        private string RecursiveCalc(string txt)
        {
            char regex = GetRegex(txt);
            if (regex == NULL_CHAR) return txt;

            string[] txtSplit = txt.Split(regex);

            for (var i = 0; i < txtSplit.Length; i++)
            {
                txtSplit[i] = RecursiveCalc(txtSplit[i]);
            }

            return DoOperation(txtSplit, regex);
        }

        /**
         * Verify if a value in the regex array exists in some string.
         * Returns the regex, else an space char.
         * */
        private char GetRegex(string src)
        {
            for (var i = 0; i < ALL_REGEX.Length; i++)
            {
                if (src.Contains(ALL_REGEX[i].ToString()))
                    return ALL_REGEX[i];
            }
            return NULL_CHAR;
        }

        private string DoOperation(string[] op, char symbol)
        {
            double o1, o2;
            try
            {
                o1 = Double.Parse(op[0]);
            }
            catch (System.FormatException) { return ERROR_MESSAGE; }

            for (var i = 1; i < op.Length; i++)
            {
                try
                {
                    o2 = Double.Parse(op[i]);
                }
                catch (System.FormatException)
                {
                    if (symbol == ALL_REGEX[0] || symbol == ALL_REGEX[1])
                        o2 = 0;
                    else
                        o2 = 1;
                }
                
                o1 = Calculate(o1, o2, symbol);
            }

            return o1.ToString();
        }

        private double Calculate(double a, double b, char symbol)
        {
            switch(symbol)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '×':
                    return a * b;
                case '/':
                    return a / b;
                case '÷':
                    return a / b;
            }

            return Double.NaN;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Developed by Ivan21.\n\n")
                .Append("Icon art by RoundIcons at https://www.flaticon.com/authors/roundicons").Append(".\n")
                .Append("Icon converted at https://icoconvert.com").Append(".");
            string msg = sb.ToString();
            MessageBox.Show(msg, PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
