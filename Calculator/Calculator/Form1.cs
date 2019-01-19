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
        enum Operation
        {
            Non, Add, Sub, Mul, Div, Sqrt
        }

        private Operation operation;
        private int currentOperandIndex;
        private double[] operand = new double[2];
        private bool canAppend, shouldChangeOperator;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            clearButton.PerformClick();
        }

        private void Initialize()
        {
            operand[0] = 0;
            operand[1] = Double.NaN;

            operation = Operation.Non;

            currentOperandIndex = 0;
            canAppend = true;

            // Update result label
            resultLabel.Text = operand[0].ToString();

            // Debugging Label
            UpdateDebuggingLabel();
        }

        private void UpdateDebuggingLabel()
        {
            string op2 = operand[1].ToString();
            if (Double.IsNaN(operand[1])) op2 = "NaN";

            StringBuilder sb = new StringBuilder();
            sb.Append("Ind:" + currentOperandIndex + " ")
                .Append("Op:" + operation.ToString() + " ")
                .Append("Op1:" + operand[0] + " ")
                .Append("Op2:" + op2 + "");

            String text = sb.ToString();
            statusLabel.Text = text;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.WhiteSmoke,
                                                               Color.LightSteelBlue,
                                                               90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
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

            Keys[] opKeys = { Keys.Add, Keys.Subtract, Keys.Multiply, Keys.Divide, Keys.Oemplus,
                Keys.OemMinus, Keys.ShiftKey | Keys.D8, Keys.OemBackslash };

            Button b = new Button();
            var kc = e.KeyCode;

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

            if (kc == Keys.Delete)
            {
                // Todo
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
                    String text = kc.ToString();
                    text = text.Substring(text.Length - 1);
                    b.Text = text;
                    NumberButtonMouseClick(b, null);
                    return;
                }
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            Initialize();
        }

        private void ResultButtonClick(object sender, EventArgs e)
        {
            DoOperation(true);
        }

        private void NumberButtonMouseClick(object sender, MouseEventArgs e)
        {
            string buttonText = ((Button)sender).Text;
            AssignCurrentOperand(Double.Parse(buttonText));
        }

        private void OperandButtonMouseClick(object sender, MouseEventArgs e)
        {
            string buttonText = ((Button)sender).Text;

            switch (buttonText)
            {
                case "+": AssignOperation(Operation.Add); break;
                case "-": AssignOperation(Operation.Sub); break;
                case "*": AssignOperation(Operation.Mul); break;
                case "/": AssignOperation(Operation.Div); break;
                case "%":
                    if (operation != Operation.Non)
                        operand[1] = (operand[1] / 100) * operand[0];
                    else
                        clearButton.PerformClick();
                    break;
                case "√": AssignOperation(Operation.Sqrt); operand[1] = 0; break;
            }

            if (shouldChangeOperator)
            {
                shouldChangeOperator = false;
                operand[1] = Double.NaN;

                // Debug
                UpdateDebuggingLabel();

                return;
            }

            DoOperation(false);
        }

        private void AssignCurrentOperand(double number)
        {
            string result = "";

            if (operand[currentOperandIndex] == 0 || Double.IsNaN(operand[currentOperandIndex]))
                resultLabel.Text = "";
            if (canAppend) result = resultLabel.Text;
            result += number.ToString();

            resultLabel.Text = result;
            operand[currentOperandIndex] = Double.Parse(resultLabel.Text);
            canAppend = true;

            // Debug
            UpdateDebuggingLabel();
        }

        private void AssignOperation(Operation operation)
        {
            if (Double.IsNaN(operand[1]) || shouldChangeOperator)
            {
                this.operation = operation;
            }
            else
            {
                DoOperation(false);
                this.operation = operation;
            }

            if (this.operation != Operation.Sqrt) currentOperandIndex = 1;

            // Debug
            UpdateDebuggingLabel();
        }

        private void DoOperation(bool resultButtonSource)
        {
            if (Double.IsNaN(operand[1])) return;

            double r = 0, o1 = operand[0], o2 = operand[1];

            if (Double.IsNaN(o2))
            {
                o2 = 0;

                if (operation == Operation.Mul || operation == Operation.Div)
                    o2 = 1;
            }

            switch(operation)
            {
                case Operation.Add: r = o1 + o2; break;
                case Operation.Sub: r = o1 - o2; break;
                case Operation.Mul: r = o1 * o2; break;
                case Operation.Div: r = o1 / o2; break;
                case Operation.Sqrt:
                    r = Math.Sqrt(o1);
                    break;
                case Operation.Non: break;
                default: return;
            }
            resultLabel.Text = r.ToString();

            // Result to op1
            operand[0] = r;

            // NaN to op2
            operand[1] = Double.NaN;
            //

            if (resultButtonSource)
            {
                operand[1] = o2;
                shouldChangeOperator = true;
            }

            // Debug
            UpdateDebuggingLabel();
            //
            //MessageBox.Show("op1 " + operand[0]);
        }
        
    }

}
