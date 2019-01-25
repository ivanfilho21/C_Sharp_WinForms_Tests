using SimpleNotepad.MenuStripForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class MainForm : Form
    {
        private MenuItemFile _File;
        private MenuItemEdit _Edit;

        public RichTextBox RichTextBox { get { return richTextBox; } }
        public OpenFileDialog OpenFileDialog { get { return openFileDialog; } }
        public SaveFileDialog SaveFileDialog { get { return saveFileDialog; } }
        public PageSetupDialog PageSetupDialog { get { return pageSetupDialog; } }
        public PrintDialog PrintDialog { get { return printDialog; } }
        public PrintDocument PrintDocument { get { return printDocument; } }

        public string ProgramName { get { return Util.PROGRAM_NAME; } }
        public string FileName { get { return GetFileName(); } }
        public string FileFullPath { get; set; }
        public string Content { get { return RichTextBox.Text; } set { RichTextBox.Text = value; } }

        public MainForm()
        {
            InitializeComponent();

            // Initializing Properties
            ClearFileName();
            // End of Properties Initialization

            UpdateTitle();

            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            
            // Initialization of MenuItem objects
            _File = new MenuItemFile(this);
            _Edit = new MenuItemEdit(this);
        }

        public void ClearFileName()
        {
            FileFullPath = "";
        }

        public void UpdateTitle()
        {
            this.Text = FileName + " - " + ProgramName;
        }

        private string GetFileName()
        {
            string name = Path.GetFileName(FileFullPath);

            if (string.IsNullOrEmpty(name))
                return Util.UNTITLED_TEXT;

            return name;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.NewFile();
        }

        private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _File.OpenFile();
        }
        
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.SaveFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.SaveFileAs();
        }

        private void PageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.PageSetup();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.PrintFile();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _File.CloseFile();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Paste(DataFormats.GetFormat(DataFormats.Text));
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox.SelectionLength == 0)
                RichTextBox.SelectionLength += 1;
            RichTextBox.SelectedText = "";
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFindReplaceForm("find");
        }

        private void FindNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFindReplaceForm("findNext");
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFindReplaceForm("replace");
        }

        private void OpenFindReplaceForm(string source)
        {
            FindReplaceForm form = new FindReplaceForm( this, source ) { MinimizeBox = false, MaximizeBox = false };
            this.AddOwnedForm(form);
            form.Show();
        }

        private void GotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoForm form = new GotoForm(CurrentLineIndex() + 1)
            {
                MinimizeBox = false,
                MaximizeBox = false
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                int lineNumber = form.LineNumber - 1;
                if (lineNumber < 0 || lineNumber >= RichTextBox.Lines.Length) return;

                int index = RichTextBox.GetFirstCharIndexFromLine(lineNumber);
                RichTextBox.Select(index, 0);
            }
            form.Dispose();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectAll();
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToShortTimeString()).Append(" ").Append(DateTime.Now.ToShortDateString());
            RichTextBox.SelectedText = sb.ToString();
        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.WordWrap = !RichTextBox.WordWrap;
            wordWrapToolStripMenuItem.Checked = RichTextBox.WordWrap;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.Font = RichTextBox.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.Font = fontDialog.Font;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Developed by Ivan21.\n\n")
                .Append("Icon art by SmashIcons at https://www.flaticon.com/authors/smashicons").Append(".\n")
                .Append("Icon converted at https://icoconvert.com").Append(".");
            string msg = sb.ToString();
            MessageBox.Show(msg, ProgramName);
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = RichTextBox.CanUndo;
            redoToolStripMenuItem.Enabled = RichTextBox.CanRedo;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();

            copyToolStripMenuItem.Enabled = RichTextBox.SelectedText.Length > 0;
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

            RichTextBox.Focus();
        }

        private int CurrentLineIndex()
        {
            int index = RichTextBox.SelectionStart;
            return RichTextBox.GetLineFromCharIndex(index);
        }

        private int CurrentColumnIndex()
        {
            int index = RichTextBox.SelectionStart;
            int line = CurrentLineIndex();
            
            int firstChar = RichTextBox.GetFirstCharIndexFromLine(line);
            return index - firstChar;
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CloseDialog();
        }

        private bool CloseDialog()
        {
            if (ShouldNotSave()) return true;

            // TODO:
            // Now a different condition, check if file content is modified

            var dialogResult = MessageBox.Show(Util.MESSAGE_ASK_SAVING + FileName + "?", ProgramName,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    saveToolStripMenuItem.PerformClick(); // SaveFile(false);
                    return true;
                case DialogResult.No: return true;
                case DialogResult.Cancel: return false;
                default: return false;
            }
        }

        private bool ShouldNotSave()
        {
            bool pathNotSet = string.IsNullOrEmpty(FileFullPath);
            bool thereIsContent = !string.IsNullOrEmpty(RichTextBox.Text);

            return pathNotSet && thereIsContent;
        }
    }
}
