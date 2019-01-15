using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class NewAccount : Form
    {
        private Form1 parent;
        private string[] statesUF = { "AC", "AM", "AP", "PA", "RO", "RR", "TO", "AL", "BA", "CE", "MA", "PB", "PE", "PI", "RN", "SE", "GO", "MS", "MT", "ES", "MG", "RJ", "SP", "PR", "RS", "SC" };
        private string[] states = { "Acre", "Amazonas", "Amapá", "Pará", "Rondônia", "Roraima", "Tocantins", "Alagoas", "Bahia", "Ceará", "Maranhão", "Paraíba", "Pernambuco", "Piauí", "Rio Grande do Norte", "Sergipe", "Goiás", "Mato Grosso do Sul", "Mato Grosso", "Espírito Santo", "Minas Gerais", "Rio de Janeiro", "São Paulo", "Paraná", "Rio Grande do Sul", "Santa Catarina" };

        public NewAccount(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            InitializeFieldsInForm();
        }

        private void InitializeFieldsInForm()
        {
            for (var i = 0; i < statesUF.Length; i++)
                stateComboBox.Items.Add(statesUF[i] + " - " + states[i]);

            stateComboBox.SelectedIndex = 0;
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Enabled = true;
            parent.Focus();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(compTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                return false;
            }

            if (stateComboBox.SelectedIndex < 0)
            {
                return false;
            }

            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                return false;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                return false;
            }

            return true;
        }
    }
}
