
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.decimalButton);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.resultButton);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ceButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 254);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button23
            // 
            this.button23.Enabled = false;
            this.button23.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(216, 99);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(45, 32);
            this.button23.TabIndex = 27;
            this.button23.TabStop = false;
            this.button23.Text = "√";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resultLabel);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 43);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(247, 41);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(216, 136);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(45, 32);
            this.button22.TabIndex = 24;
            this.button22.TabStop = false;
            this.button22.Text = "±";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.Red;
            this.delButton.Location = new System.Drawing.Point(114, 61);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(96, 32);
            this.delButton.TabIndex = 23;
            this.delButton.TabStop = false;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(12, 61);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(45, 32);
            this.clearButton.TabIndex = 22;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // button19
            // 
            this.button19.Enabled = false;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(216, 61);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(45, 32);
            this.button19.TabIndex = 18;
            this.button19.TabStop = false;
            this.button19.Text = "%";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(114, 212);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(45, 32);
            this.decimalButton.TabIndex = 21;
            this.decimalButton.TabStop = false;
            this.decimalButton.Text = ",";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.DecimalButtonClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(12, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 32);
            this.button10.TabIndex = 19;
            this.button10.TabStop = false;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(165, 174);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 32);
            this.button13.TabIndex = 12;
            this.button13.TabStop = false;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(165, 212);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 32);
            this.button12.TabIndex = 11;
            this.button12.TabStop = false;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(165, 136);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(45, 32);
            this.button14.TabIndex = 13;
            this.button14.TabStop = false;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.Location = new System.Drawing.Point(216, 174);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(45, 70);
            this.resultButton.TabIndex = 17;
            this.resultButton.TabStop = false;
            this.resultButton.Text = "=";
            this.resultButton.UseMnemonic = false;
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ResultButtonClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(165, 99);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(45, 32);
            this.button15.TabIndex = 14;
            this.button15.TabStop = false;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OperandButtonMouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 32);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // ceButton
            // 
            this.ceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceButton.ForeColor = System.Drawing.Color.Red;
            this.ceButton.Location = new System.Drawing.Point(63, 61);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(45, 32);
            this.ceButton.TabIndex = 15;
            this.ceButton.TabStop = false;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.CE_ButtonClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(63, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 31);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 32);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(63, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 32);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(114, 174);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 32);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 32);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(114, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 32);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(63, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 32);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(114, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 32);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberButtonMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(273, 254);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label resultLabel;
    }
}

