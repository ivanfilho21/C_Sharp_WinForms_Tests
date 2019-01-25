using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class FindReplaceForm : Form
    {
        private MainForm parent;
        private int startIndex = 0, selectStart = -1;
        private string findTxt, replaceTxt, sourceText;

        public FindReplaceForm(MainForm parent, string source)
        {
            InitializeComponent();
            this.parent = parent;

            switch (source)
            {
                case "find": this.AcceptButton = findButton; break;
                case "findNext": this.AcceptButton = findNextButton; break;
                case "replace": this.AcceptButton = replaceButton; break;
            }
                
        }

        private void InitStrings()
        {
            this.findTxt = findTextBox.Text;
            this.replaceTxt = replaceTextBox.Text;
            this.sourceText = this.parent.RichTextBox.Text;

            VerifyMatchCase();
        }

        private void VerifyMatchCase()
        {
            if (!matchCaseCheckBox.Checked)
            {
                findTxt = findTxt.ToLower();
                replaceTxt = replaceTxt.ToLower();
                sourceText = sourceText.ToLower();
            }
        }

        
        private void FindButton_Click(object sender, EventArgs e)
        {
            InitStrings();

            this.selectStart = sourceText.IndexOf(findTxt);

            if (this.selectStart == -1)
            {
                this.startIndex = 0;
                return;
            }
            if (this.selectStart == sourceText.LastIndexOf(findTxt))
            {
                this.startIndex = 0;
            }

            int selectEnd = this.selectStart + findTxt.Length;
            this.parent.RichTextBox.SelectionStart = this.selectStart;
            this.parent.RichTextBox.SelectionLength = findTxt.Length;
            this.parent.RichTextBox.Select();
        }

        private void FindNextButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            findButton.PerformClick();

            if (this.selectStart != -1)
                this.parent.RichTextBox.SelectedText = this.replaceTxt;
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
