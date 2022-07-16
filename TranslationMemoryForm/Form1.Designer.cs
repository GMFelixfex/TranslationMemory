namespace TranslationMemoryForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterButtonStart = new System.Windows.Forms.Button();
            this.TitleLable = new System.Windows.Forms.Label();
            this.LoginButtonStart = new System.Windows.Forms.Button();
            this.ExitButtonStart = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterButtonStart
            // 
            this.RegisterButtonStart.Location = new System.Drawing.Point(12, 67);
            this.RegisterButtonStart.Name = "RegisterButtonStart";
            this.RegisterButtonStart.Size = new System.Drawing.Size(79, 23);
            this.RegisterButtonStart.TabIndex = 0;
            this.RegisterButtonStart.Text = "Register";
            this.RegisterButtonStart.UseVisualStyleBackColor = true;
            this.RegisterButtonStart.Click += new System.EventHandler(this.RegisterButtonStart_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLable.Location = new System.Drawing.Point(42, 9);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(252, 37);
            this.TitleLable.TabIndex = 1;
            this.TitleLable.Text = "Translation Memory";
            // 
            // LoginButtonStart
            // 
            this.LoginButtonStart.Location = new System.Drawing.Point(126, 67);
            this.LoginButtonStart.Name = "LoginButtonStart";
            this.LoginButtonStart.Size = new System.Drawing.Size(79, 23);
            this.LoginButtonStart.TabIndex = 2;
            this.LoginButtonStart.Text = "Login";
            this.LoginButtonStart.UseVisualStyleBackColor = true;
            this.LoginButtonStart.Click += new System.EventHandler(this.LoginButtonStart_Click);
            // 
            // ExitButtonStart
            // 
            this.ExitButtonStart.Location = new System.Drawing.Point(236, 67);
            this.ExitButtonStart.Name = "ExitButtonStart";
            this.ExitButtonStart.Size = new System.Drawing.Size(79, 23);
            this.ExitButtonStart.TabIndex = 3;
            this.ExitButtonStart.Text = "Exit";
            this.ExitButtonStart.UseVisualStyleBackColor = true;
            this.ExitButtonStart.Click += new System.EventHandler(this.ExitButtonStart_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 96);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(303, 23);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Visible = false;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 125);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Name";
            this.NameTextBox.Size = new System.Drawing.Size(303, 23);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.Visible = false;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 154);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(303, 23);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.Visible = false;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 183);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(303, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.ForeColor = System.Drawing.Color.Red;
            this.InfoLabel.Location = new System.Drawing.Point(12, 212);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(113, 15);
            this.InfoLabel.TabIndex = 8;
            this.InfoLabel.Text = "Everything Incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 236);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ExitButtonStart);
            this.Controls.Add(this.LoginButtonStart);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.RegisterButtonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegisterButtonStart;
        private Label TitleLable;
        private Button LoginButtonStart;
        private Button ExitButtonStart;
        private TextBox EmailTextBox;
        private TextBox NameTextBox;
        private TextBox PasswordTextBox;
        private Button SubmitButton;
        private Label InfoLabel;
    }
}