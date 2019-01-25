using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepad.MenuStripForms
{
    // New, Open, Save, SaveAs, Page, Print, Quit

    class MenuItemFile : MenuItem
    {
        public MenuItemFile(MainForm mainForm) : base(mainForm)
        {
            
        }

        public void NewFile()
        {
            if (string.IsNullOrEmpty(MainForm.Content))
                return;

            // Todo: ask the user to save his current work.
            // in case there are changes to the file

            if (!SaveDialog())
                return;

            MainForm.ClearFileName();
            MainForm.UpdateTitle(); // Maybe use an event.
            MainForm.Content = "";
        }

        public void OpenFile()
        {
            // Todo: ask the user to save his current work.
            // in case there are changes to the file.

            MainForm.OpenFileDialog.Filter = Util.FILTER_TEXT_EXTENSIONS;

            if (MainForm.OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainForm.FileFullPath = MainForm.OpenFileDialog.FileName;
                
                MainForm.RichTextBox.LoadFile(
                    MainForm.OpenFileDialog.FileName, RichTextBoxStreamType.PlainText);
                MainForm.UpdateTitle();
            }
        }

        public bool SaveDialog()
        {
            string msg = "Would you like to save changes in " + MainForm.FileName + "?";
            string title = MainForm.ProgramName;
            var ret = MessageBox.Show(msg, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (ret)
            {
                case DialogResult.Yes:
                    Save(false);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    return false;
            }
            return true;
        }

        private void Save(bool saveAs)
        {
            MainForm.SaveFileDialog.Filter = Util.FILTER_TEXT_EXTENSIONS;
            if (string.IsNullOrEmpty(MainForm.FileFullPath) || saveAs)
            {
                if (MainForm.SaveFileDialog.ShowDialog() == DialogResult.OK &&
                MainForm.SaveFileDialog.FileName.Length > 0)
                {
                    MainForm.FileFullPath = MainForm.SaveFileDialog.FileName;
                    
                    MainForm.RichTextBox.SaveFile(MainForm.FileFullPath, RichTextBoxStreamType.PlainText);
                    MainForm.UpdateTitle();
                }
            }
            else
            {
                MainForm.RichTextBox.SaveFile(MainForm.FileFullPath, RichTextBoxStreamType.PlainText);
                MainForm.UpdateTitle();
            }
        }

        public void SaveFile()
        {
            Save(false);
        }

        public void SaveFileAs()
        {
            Save(true);
        }

        public void PageSetup()
        {
            MainForm.PageSetupDialog.PageSettings = new PageSettings();
            MainForm.PageSetupDialog.PrinterSettings = MainForm.PrintDocument.PrinterSettings;
            MainForm.PageSetupDialog.ShowDialog();
            if (MainForm.PageSetupDialog.PageSettings != null)
            {
                MainForm.PrintDocument.DefaultPageSettings = MainForm.PageSetupDialog.PageSettings;
            }
        }

        public void PrintFile()
        {
            // TODO...
        }

        public void CloseFile()
        {
            MainForm.Close();
        }
    }
}
