namespace TranslationMemoryForm
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginNameText = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.RoleNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(202, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(252, 37);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Translation Memory";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(80, 15);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Logged is as: ";
            // 
            // LoginNameText
            // 
            this.LoginNameText.Location = new System.Drawing.Point(12, 27);
            this.LoginNameText.Name = "LoginNameText";
            this.LoginNameText.Size = new System.Drawing.Size(80, 15);
            this.LoginNameText.TabIndex = 4;
            this.LoginNameText.Text = "Name";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(96, 9);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(33, 15);
            this.RoleLabel.TabIndex = 5;
            this.RoleLabel.Text = "Role:";
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Location = new System.Drawing.Point(202, 58);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(600, 380);
            this.DisplayPanel.TabIndex = 15;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Location = new System.Drawing.Point(12, 58);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(184, 380);
            this.ButtonPanel.TabIndex = 16;
            // 
            // RoleNameText
            // 
            this.RoleNameText.AutoSize = true;
            this.RoleNameText.Location = new System.Drawing.Point(96, 27);
            this.RoleNameText.Name = "RoleNameText";
            this.RoleNameText.Size = new System.Drawing.Size(33, 15);
            this.RoleNameText.TabIndex = 17;
            this.RoleNameText.Text = "Role:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.RoleNameText);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.LoginNameText);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label LoginLabel;
        private Label LoginNameText;
        private Label RoleLabel;
        private Panel DisplayPanel;
        private Panel ButtonPanel;
        private Label RoleNameText;
    }
}