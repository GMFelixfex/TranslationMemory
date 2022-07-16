namespace TranslationMemoryForm.Elements
{
    partial class UserButtons
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButtonMain = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButtonMain
            // 
            this.ExitButtonMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButtonMain.Location = new System.Drawing.Point(3, 112);
            this.ExitButtonMain.Name = "ExitButtonMain";
            this.ExitButtonMain.Size = new System.Drawing.Size(162, 30);
            this.ExitButtonMain.TabIndex = 14;
            this.ExitButtonMain.Text = "Exit";
            this.ExitButtonMain.UseVisualStyleBackColor = true;
            this.ExitButtonMain.Click += new System.EventHandler(this.ExitButtonMain_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatisticsButton.Location = new System.Drawing.Point(3, 4);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(162, 30);
            this.StatisticsButton.TabIndex = 13;
            this.StatisticsButton.Text = "Show Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(3, 40);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(162, 30);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search Word";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.Location = new System.Drawing.Point(3, 76);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(162, 30);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // UserButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExitButtonMain);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LogoutButton);
            this.Name = "UserButtons";
            this.Size = new System.Drawing.Size(168, 146);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ExitButtonMain;
        private Button StatisticsButton;
        private Button SearchButton;
        private Button LogoutButton;
    }
}
