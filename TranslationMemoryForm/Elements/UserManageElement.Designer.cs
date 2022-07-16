namespace TranslationMemoryForm.Elements
{
    partial class UserManageElement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SerachUserTextBox = new System.Windows.Forms.TextBox();
            this.UserTable = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordsTranslated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectLanguageBox = new System.Windows.Forms.ComboBox();
            this.AddLanguageButton = new System.Windows.Forms.Button();
            this.RemoveLanguageButton = new System.Windows.Forms.Button();
            this.ConverToUserButton = new System.Windows.Forms.Button();
            this.ConverTranslatorButton = new System.Windows.Forms.Button();
            this.ConverAdminButton = new System.Windows.Forms.Button();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SerachUserTextBox
            // 
            this.SerachUserTextBox.Location = new System.Drawing.Point(0, 3);
            this.SerachUserTextBox.Name = "SerachUserTextBox";
            this.SerachUserTextBox.PlaceholderText = "Search for a User";
            this.SerachUserTextBox.Size = new System.Drawing.Size(600, 23);
            this.SerachUserTextBox.TabIndex = 0;
            this.SerachUserTextBox.TextChanged += new System.EventHandler(this.SerachUserTextBox_TextChanged);
            // 
            // UserTable
            // 
            this.UserTable.AllowUserToAddRows = false;
            this.UserTable.AllowUserToDeleteRows = false;
            this.UserTable.AllowUserToResizeColumns = false;
            this.UserTable.AllowUserToResizeRows = false;
            this.UserTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Role,
            this.WordsAdded,
            this.WordsTranslated,
            this.Languages});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserTable.Location = new System.Drawing.Point(0, 32);
            this.UserTable.Name = "UserTable";
            this.UserTable.ReadOnly = true;
            this.UserTable.RowHeadersVisible = false;
            this.UserTable.RowTemplate.Height = 25;
            this.UserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserTable.Size = new System.Drawing.Size(597, 287);
            this.UserTable.TabIndex = 1;
            this.UserTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserTable_CellClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Role.Width = 80;
            // 
            // WordsAdded
            // 
            this.WordsAdded.HeaderText = "WordsAdded";
            this.WordsAdded.Name = "WordsAdded";
            this.WordsAdded.ReadOnly = true;
            this.WordsAdded.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WordsAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WordsAdded.Width = 90;
            // 
            // WordsTranslated
            // 
            this.WordsTranslated.HeaderText = "WordsTranslated";
            this.WordsTranslated.Name = "WordsTranslated";
            this.WordsTranslated.ReadOnly = true;
            this.WordsTranslated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Languages
            // 
            this.Languages.HeaderText = "Languages";
            this.Languages.Name = "Languages";
            this.Languages.ReadOnly = true;
            this.Languages.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Languages.Width = 223;
            // 
            // SelectLanguageBox
            // 
            this.SelectLanguageBox.FormattingEnabled = true;
            this.SelectLanguageBox.Location = new System.Drawing.Point(3, 327);
            this.SelectLanguageBox.Name = "SelectLanguageBox";
            this.SelectLanguageBox.Size = new System.Drawing.Size(294, 23);
            this.SelectLanguageBox.TabIndex = 2;
            this.SelectLanguageBox.SelectedIndexChanged += new System.EventHandler(this.SelectLanguageBox_SelectedIndexChanged);
            // 
            // AddLanguageButton
            // 
            this.AddLanguageButton.Location = new System.Drawing.Point(303, 325);
            this.AddLanguageButton.Name = "AddLanguageButton";
            this.AddLanguageButton.Size = new System.Drawing.Size(144, 25);
            this.AddLanguageButton.TabIndex = 3;
            this.AddLanguageButton.Text = "Add Language";
            this.AddLanguageButton.UseVisualStyleBackColor = true;
            this.AddLanguageButton.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // RemoveLanguageButton
            // 
            this.RemoveLanguageButton.Location = new System.Drawing.Point(453, 325);
            this.RemoveLanguageButton.Name = "RemoveLanguageButton";
            this.RemoveLanguageButton.Size = new System.Drawing.Size(144, 25);
            this.RemoveLanguageButton.TabIndex = 4;
            this.RemoveLanguageButton.Text = "Remove Language";
            this.RemoveLanguageButton.UseVisualStyleBackColor = true;
            this.RemoveLanguageButton.Click += new System.EventHandler(this.RemoveLanguageButton_Click);
            // 
            // ConverToUserButton
            // 
            this.ConverToUserButton.Location = new System.Drawing.Point(3, 356);
            this.ConverToUserButton.Name = "ConverToUserButton";
            this.ConverToUserButton.Size = new System.Drawing.Size(144, 25);
            this.ConverToUserButton.TabIndex = 5;
            this.ConverToUserButton.Text = "Convert To Regular User";
            this.ConverToUserButton.UseVisualStyleBackColor = true;
            this.ConverToUserButton.Click += new System.EventHandler(this.ConverToUserButton_Click);
            // 
            // ConverTranslatorButton
            // 
            this.ConverTranslatorButton.Location = new System.Drawing.Point(153, 356);
            this.ConverTranslatorButton.Name = "ConverTranslatorButton";
            this.ConverTranslatorButton.Size = new System.Drawing.Size(144, 25);
            this.ConverTranslatorButton.TabIndex = 6;
            this.ConverTranslatorButton.Text = "Convert To Translator";
            this.ConverTranslatorButton.UseVisualStyleBackColor = true;
            this.ConverTranslatorButton.Click += new System.EventHandler(this.ConverTranslatorButton_Click);
            // 
            // ConverAdminButton
            // 
            this.ConverAdminButton.Location = new System.Drawing.Point(303, 356);
            this.ConverAdminButton.Name = "ConverAdminButton";
            this.ConverAdminButton.Size = new System.Drawing.Size(144, 25);
            this.ConverAdminButton.TabIndex = 7;
            this.ConverAdminButton.Text = "Convert To Admin";
            this.ConverAdminButton.UseVisualStyleBackColor = true;
            this.ConverAdminButton.Click += new System.EventHandler(this.ConverAdminButton_Click);
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Location = new System.Drawing.Point(453, 356);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(144, 25);
            this.RemoveUserButton.TabIndex = 8;
            this.RemoveUserButton.Text = "Remove User";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // UserManageElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.ConverAdminButton);
            this.Controls.Add(this.ConverTranslatorButton);
            this.Controls.Add(this.ConverToUserButton);
            this.Controls.Add(this.RemoveLanguageButton);
            this.Controls.Add(this.AddLanguageButton);
            this.Controls.Add(this.SelectLanguageBox);
            this.Controls.Add(this.UserTable);
            this.Controls.Add(this.SerachUserTextBox);
            this.Name = "UserManageElement";
            this.Size = new System.Drawing.Size(600, 384);
            this.Load += new System.EventHandler(this.UserManageElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SerachUserTextBox;
        private DataGridView UserTable;
        private ComboBox SelectLanguageBox;
        private Button AddLanguageButton;
        private Button RemoveLanguageButton;
        private Button ConverToUserButton;
        private Button ConverTranslatorButton;
        private Button ConverAdminButton;
        private Button RemoveUserButton;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn WordsAdded;
        private DataGridViewTextBoxColumn WordsTranslated;
        private DataGridViewTextBoxColumn Languages;
    }
}
