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
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ivan.", "About");
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
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
        }
    }
}
