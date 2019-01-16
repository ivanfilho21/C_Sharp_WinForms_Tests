namespace Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.accountTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.systemTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.addAccButton = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.quitButton = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(601, 136);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.accountTab);
            this.ribbon1.Tabs.Add(this.systemTab);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // accountTab
            // 
            this.accountTab.Name = "accountTab";
            this.accountTab.Panels.Add(this.ribbonPanel2);
            this.accountTab.Text = "Account";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.addAccButton);
            this.ribbonPanel2.Items.Add(this.ribbonButton1);
            this.ribbonPanel2.Items.Add(this.ribbonButton2);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Operations";
            // 
            // systemTab
            // 
            this.systemTab.Name = "systemTab";
            this.systemTab.Panels.Add(this.ribbonPanel1);
            this.systemTab.Text = "System";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.quitButton);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // addAccButton
            // 
            this.addAccButton.Image = global::Bank.Properties.Resources.add;
            this.addAccButton.LargeImage = global::Bank.Properties.Resources.add;
            this.addAccButton.Name = "addAccButton";
            this.addAccButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("addAccButton.SmallImage")));
            this.addAccButton.Text = "New";
            this.addAccButton.Click += new System.EventHandler(this.NewAccountRibbonButton_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = global::Bank.Properties.Resources.edit_16;
            this.ribbonButton1.Text = "Edit";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = global::Bank.Properties.Resources.trash_16;
            this.ribbonButton2.Text = "Delete";
            // 
            // quitButton
            // 
            this.quitButton.Image = ((System.Drawing.Image)(resources.GetObject("quitButton.Image")));
            this.quitButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("quitButton.LargeImage")));
            this.quitButton.Name = "quitButton";
            this.quitButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("quitButton.SmallImage")));
            this.quitButton.Text = "Quit";
            this.quitButton.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.quitButton.Click += new System.EventHandler(this.QuitRibbonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Bank (Admin)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab accountTab;
        private System.Windows.Forms.RibbonTab systemTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton quitButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton addAccButton;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
    }
}

