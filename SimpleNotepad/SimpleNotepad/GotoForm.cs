using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class GotoForm : Form
    {
        public int LineNumber { get; private set; }

        public GotoForm(int currentLineNumber)
        {
            InitializeComponent();
            LineNumber = currentLineNumber;
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            int n = LineNumber;

            try
            {
                n = Convert.ToInt32(lineNumberTextBox.Text);
            }
            catch (System.FormatException) { }

            LineNumber = n;
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
