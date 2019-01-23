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
        private char[] ALL_REGEX = { '+', '-', '*', '×', '/', '÷' };

        public Form1()
        {
            InitializeComponent();
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            string txt = inputTextBox.Text;
            char regex = GetRegex(txt);
            string[] txtSplit = txt.Split(regex);

            resultLabel.Text = "";

            for (var i = 0; i < txtSplit.Length; i++)
            {
                txtSplit[i] = DecodeAux1(txtSplit[i]);
            }

            resultLabel.Text = DoOperation(txtSplit, regex);
        }
        
        private string DecodeAux1(string txt)
        {
            char regex = GetRegex(txt);
            if (regex == NULL_CHAR) return txt;

            string[] txtSplit = txt.Split(regex);
            string result = txtSplit[0];

            for (var i = 0; i < txtSplit.Length; i++)
            {
                txtSplit[i] = DecodeAux2(txtSplit[i]);
            }
            if (txtSplit.Length > 1)
                result = DoOperation(txtSplit, regex);

            return result;
        }

        private string DecodeAux2(string txt)
        {
            char regex = GetRegex(txt);
            if (regex == NULL_CHAR) return txt;

            string[] txtSplit = txt.Split(regex);
            string result = txtSplit[0];

            for (var i = 0; i < txtSplit.Length; i++)
            {
                txtSplit[i] = DecodeAux3(txtSplit[i]);
            }
            result = DoOperation(txtSplit, regex);

            return result;
        }

        private string DecodeAux3(string txt)
        {
            char regex = GetRegex(txt);
            if (regex == NULL_CHAR) return txt;

            string[] txtSplit = txt.Split(regex);
            string result = txtSplit[0];

            for (var i = 0; i < txtSplit.Length; i++)
            {
                char reg = GetRegex(txtSplit[i]);
                if (reg == NULL_CHAR) continue;
            }
            if (txtSplit.Length > 1)
                result = DoOperation(txtSplit, regex);

            return result;
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
            double o1 = Double.Parse(op[0]), o2;

            for (var i = 1; i < op.Length; i++)
            {
                //MessageBox.Show("" + op[i]);
                o2 = Double.Parse(op[i]);
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
        
    }
}
