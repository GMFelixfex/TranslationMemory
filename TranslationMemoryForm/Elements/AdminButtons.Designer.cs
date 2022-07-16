namespace TranslationMemoryForm.Elements
{
    partial class AdminButtons
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
            this.ManageLanguagesButton = new System.Windows.Forms.Button();
            this.ManageUsersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageLanguagesButton
            // 
            this.ManageLanguagesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageLanguagesButton.Location = new System.Drawing.Point(3, 39);
            this.ManageLanguagesButton.Name = "ManageLanguagesButton";
            this.ManageLanguagesButton.Size = new System.Drawing.Size(162, 30);
            this.ManageLanguagesButton.TabIndex = 16;
            this.ManageLanguagesButton.Text = "Manage Languages";
            this.ManageLanguagesButton.UseVisualStyleBackColor = true;
            this.ManageLanguagesButton.Click += new System.EventHandler(this.ManageLanguagesButton_Click);
            // 
            // ManageUsersButton
            // 
            this.ManageUsersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageUsersButton.Location = new System.Drawing.Point(3, 3);
            this.ManageUsersButton.Name = "ManageUsersButton";
            this.ManageUsersButton.Size = new System.Drawing.Size(162, 30);
            this.ManageUsersButton.TabIndex = 15;
            this.ManageUsersButton.Text = "Manage Users";
            this.ManageUsersButton.UseVisualStyleBackColor = true;
            this.ManageUsersButton.Click += new System.EventHandler(this.ManageUsersButton_Click);
            // 
            // AdminButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManageLanguagesButton);
            this.Controls.Add(this.ManageUsersButton);
            this.Name = "AdminButtons";
            this.Size = new System.Drawing.Size(168, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ManageLanguagesButton;
        private Button ManageUsersButton;
    }
}
