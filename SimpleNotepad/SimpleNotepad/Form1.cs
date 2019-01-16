using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        private const string PROGRAM_NAME = "SimpleNotepad";
        private const string FILTER_TEXT_EXTENSIONS = "Text Files |*.txt";
        private const string UNTITLED_TEXT = "Untitled";

        private string fileName;
        private string fileFullPath;

        public Form1()
        {
            InitializeComponent();

            fileName = UNTITLED_TEXT;
            UpdateTitle();

            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
        }

        private void UpdateTitle()
        {
            this.Text = fileName + " - " + PROGRAM_NAME;
        }

        private string ShortenFileName()
        {
            var fullName = fileFullPath.Split('\\');
            var lastName = fullName[fullName.Length - 1].Split('.');
            return lastName[0];
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox.Text))
                return;

            // Todo: ask the user to save his current work.
            // in case there are changes to the file

            if (!SaveDialog())
                return;

            fileFullPath = "";
            fileName = UNTITLED_TEXT;
            UpdateTitle();
            richTextBox.Text = "";
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Todo: ask the user to save his current work.
            // in case there are changes to the file

            openFileDialog.Filter = FILTER_TEXT_EXTENSIONS;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileFullPath = openFileDialog.FileName;
                fileName = ShortenFileName();

                richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

                UpdateTitle();
            }
        }

        private bool SaveDialog()
        {
            string msg = "Would you like to save changes in " + fileName + "?";
            string title = PROGRAM_NAME;
            var ret = MessageBox.Show(msg, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch(ret)
            {
                case DialogResult.Yes:
                    SaveFile(false);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    return false;
            }
            return true;
        }

        private void SaveFile(bool saveAs)
        {
            saveFileDialog.Filter = FILTER_TEXT_EXTENSIONS;
            if (string.IsNullOrEmpty(fileFullPath) || saveAs)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK &&
                saveFileDialog.FileName.Length > 0)
                {
                    fileFullPath = saveFileDialog.FileName;
                    fileName = ShortenFileName();

                    richTextBox.SaveFile(fileFullPath, RichTextBoxStreamType.PlainText);
                    UpdateTitle();
                }
            }
            else
            {
                fileName = ShortenFileName();
                richTextBox.SaveFile(fileFullPath, RichTextBoxStreamType.PlainText);
                UpdateTitle();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(false);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(true);
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength == 0)
                richTextBox.SelectionLength += 1;
            richTextBox.SelectedText = "";
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = !richTextBox.WordWrap;
            wordWrapToolStripMenuItem.Checked = richTextBox.WordWrap;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = richTextBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = fontDialog.Font;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ivan.", "About");
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = richTextBox.CanUndo;
            redoToolStripMenuItem.Enabled = richTextBox.CanRedo;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();

            copyToolStripMenuItem.Enabled = richTextBox.SelectedText.Length > 0;
        }

        private void MenuStrip1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(250, 250, 250);
            Color blue = Color.FromArgb(210, 220, 240);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                menuStrip1.ClientRectangle, Color.Red, Color.Yellow, 90);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { white, blue, white };
            cblend.Positions = new float[3] { 0f, 0.7f, 1f };

            linearGradientBrush.InterpolationColors = cblend;
            e.Graphics.FillRectangle(linearGradientBrush, menuStrip1.ClientRectangle);

            richTextBox.Focus();
        }

    }
}
