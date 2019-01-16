using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        // Just for testing, this array of Accounts will be used.
        Account[] accounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewAccountRibbonButton_Click(object sender, EventArgs e)
        {
            NewAccount form = new NewAccount(this)
            {
                MinimizeBox = false,
                MaximizeBox = false
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                form.Dispose();
            }
            else
            {
                
            }
        }

        private void QuitRibbonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
