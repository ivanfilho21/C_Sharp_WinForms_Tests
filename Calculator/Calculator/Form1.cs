using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private const int MAX_LENGTH = 15;

        enum Operation
        {
            none, sum, sub, mult, div, err
        }

        private Operation _operation;
        private Operand[] operand = new Operand[2];
        private int currIndex;
        private bool canAppend;
        private bool finishedOperation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            clearButton.PerformClick();
        }

        private void InitializeOperands()
        {
            for (var i = 0; i < operand.Length; i++)
                operand[i] = new Operand();
            currIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.WhiteSmoke,
                                                               Color.LightSteelBlue,
                                                               90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.WhiteSmoke,
                                                               Color.FromArgb(208, 219, 219),
                                                               90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            Keys[] numKeys = { Keys.D0, Keys.NumPad0, Keys.D1, Keys.NumPad1, Keys.D2, Keys.NumPad2,
                Keys.D3, Keys.NumPad3, Keys.D4, Keys.NumPad4, Keys.D5, Keys.NumPad5, Keys.D6,
                Keys.NumPad6, Keys.D7, Keys.NumPad7, Keys.D8, Keys.NumPad8, Keys.D9, Keys.NumPad9 };

            Keys[] opKeys = { Keys.Add, Keys.Subtract, Keys.Multiply, Keys.Divide,
                Keys.Oemplus, Keys.OemMinus, Keys.ShiftKey | Keys.D8, Keys.OemBackslash };

            Button b = new Button();
            var kc = e.KeyCode;

            // TODO: replace this with Default Confirm Button in WinForms
            if (kc == Keys.Enter || kc == Keys.Return)
            {
                resultButton.PerformClick();
                return;
            }

            if (kc == Keys.Back)
            {
                delButton.PerformClick();
                return;
            }

            if (kc == Keys.Delete) // CE button 
            {
                return;
            }

            for (var i = 0; i < opKeys.Length; i++)
            {
                if (kc == opKeys[i])
                {
                    if (kc == Keys.Add || kc == Keys.Oemplus) b.Text = "+";
                    else if (kc == Keys.Subtract || kc == Keys.OemMinus) b.Text = "-";
                    else if (kc == Keys.Multiply || (kc == Keys.D8 && e.Shift)) b.Text = "*";
                    else if (kc == Keys.Divide || kc == Keys.OemBackslash) b.Text = "/";
                    else if (kc == Keys.D8) break;
                    
                    OperandButtonMouseClick(b, null);
                    return;
                }
            }

            for (var i = 0; i < numKeys.Length; i++)
            {
                if (kc == numKeys[i])
                {
                    b.Text = DecodeKeyText(kc.ToString());
                    NumberButtonMouseClick(b, null);
                    return;
                }
            }
        }

        private string DecodeKeyText(string text)
        {
            return text.Substring(text.Length - 1);
        }

        private void NumberButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            var buttonText = b.Text;

            if (_operation == Operation.err)
            {
                InitializeOperands();
                canAppend = false;
            }

            if (resultLabel.Text == "0") resultLabel.Text = "";

            if (canAppend)// Apeending numbers.
            {
                resultLabel.Text += buttonText;
            }
            else // Sets current operand value.  
            {
                resultLabel.Text = buttonText;
                canAppend = true; // Must append from now on.
            }

            operand[currIndex].Value = Double.Parse(resultLabel.Text);

            LoseFocus();
        }

        private void OperandButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Text)
            {
                case "+":
                    ChangeOperation(Operation.sum); break;
                case "-":
                    ChangeOperation(Operation.sub); break;
                case "*":
                    ChangeOperation(Operation.mult); break;
                case "/":
                    ChangeOperation(Operation.div); break;
                default:
                    // Debug
                    // MessageBox.Show("Invalid option: " + b.Text, "OperandButtonMouseClick");
                    return;
            }

            if (finishedOperation)// && operand[1].HasValue) // may be redundant
            {
                operand[1] = new Operand();
                finishedOperation = false;
            }

            currIndex = operand[0].HasValue ? 1 : 0;
            canAppend = false;
            
            DoOperation(false, false);

            LoseFocus();
        }

        private bool ChangeOperation(Operation op)
        {
            if (_operation == Operation.none || finishedOperation)
            {
                _operation = op;
                return true;
            }
            else
            {
                DoOperation(false, true);
                operand[1] = new Operand();
                _operation = op;

                finishedOperation = false;
            }
            return false;
        }
        
        private void DoOperation(bool sourceResult, bool sourceChangeOp)
        {
            double n2 = 0;
            
            if (operand[1].HasValue)
                n2 = operand[1].Value;
            else
            {
                if (_operation == Operation.div)
                {
                    if (sourceResult)
                    {
                        operand[1].Value = operand[0].Value;
                        operand[0].Value = 1;
                        n2 = operand[1].Value;
                    }
                    else
                    {
                        n2 = 1;
                    }
                        //n2 = 1;
                }
                else if (_operation == Operation.mult) n2 = 1;
            }

            double result = 0;

            switch (_operation)
            {
                case Operation.sum:
                    result = operand[0].Value + n2;
                    break;
                case Operation.sub:
                    result = operand[0].Value - n2;
                    break;
                case Operation.mult:
                    result = operand[0].Value * n2;
                    break;
                case Operation.div:
                    if (n2 != 0)
                        result = operand[0].Value / n2;
                    else
                    {
                        resultLabel.Text = "Cannot divide by zero.";
                        _operation = Operation.err;
                        return;
                    }
                    break;
            }

            if (sourceResult)
                canAppend = false;
            
            resultLabel.Text = "" + result; //operand[0].Value;

            if (operand[1].HasValue)
            {
                //if (_operation != Operation.mult)
                finishedOperation = true;
            }
            
            if (_operation == Operation.mult && !sourceChangeOp) // maybe verify finished operation...
                operand[1].Value = result;
            else
                operand[0].Value = result;
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {
            DoOperation(true, false);

            LoseFocus();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            InitializeOperands();
            _operation = Operation.none;
            canAppend = true;
            finishedOperation = false;

            resultLabel.Text = "" + 0;

            LoseFocus();
        }

        private void CE_ButtonClick(object sender, EventArgs e)
        {

        }

        private void DelButtonClick(object sender, EventArgs e)
        {
            
            if (resultLabel.Text.Length > 1)
                resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);
            else
                clearButton.PerformClick();

            try
            {
                AssignToOperand();
            }
            catch (System.FormatException)
            {
                resultLabel.Text = "" + 0;
            }
            finally
            {
                AssignToOperand();
            }
            
            LoseFocus();
        }

        private void AssignToOperand()
        {
            if (finishedOperation)
                operand[0].Value = Double.Parse(resultLabel.Text);
            else
                operand[currIndex].Value = Double.Parse(resultLabel.Text);
        }

        private void DecimalButtonClick(object sender, EventArgs e)
        {
            LoseFocus();
        }

        private void LoseFocus()
        {
            panel1.Focus();
        }
    }

}
