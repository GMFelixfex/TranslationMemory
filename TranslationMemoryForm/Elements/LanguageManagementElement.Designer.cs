namespace TranslationMemoryForm.Elements
{
    partial class LanguageManagementElement
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
            this.LanguagesTable = new System.Windows.Forms.DataGridView();
            this.Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanguageTextBox = new System.Windows.Forms.TextBox();
            this.AddLanguageButton = new System.Windows.Forms.Button();
            this.RemoveLanguageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguagesTable
            // 
            this.LanguagesTable.AllowUserToAddRows = false;
            this.LanguagesTable.AllowUserToDeleteRows = false;
            this.LanguagesTable.AllowUserToResizeColumns = false;
            this.LanguagesTable.AllowUserToResizeRows = false;
            this.LanguagesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LanguagesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Languages});
            this.LanguagesTable.Location = new System.Drawing.Point(0, 0);
            this.LanguagesTable.Name = "LanguagesTable";
            this.LanguagesTable.ReadOnly = true;
            this.LanguagesTable.RowHeadersVisible = false;
            this.LanguagesTable.RowTemplate.Height = 25;
            this.LanguagesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LanguagesTable.ShowEditingIcon = false;
            this.LanguagesTable.Size = new System.Drawing.Size(600, 352);
            this.LanguagesTable.TabIndex = 0;
            this.LanguagesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LanguagesTable_CellClick);
            // 
            // Languages
            // 
            this.Languages.HeaderText = "Languages";
            this.Languages.Name = "Languages";
            this.Languages.ReadOnly = true;
            this.Languages.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Languages.Width = 596;
            // 
            // LanguageTextBox
            // 
            this.LanguageTextBox.Location = new System.Drawing.Point(0, 356);
            this.LanguageTextBox.Name = "LanguageTextBox";
            this.LanguageTextBox.Size = new System.Drawing.Size(294, 23);
            this.LanguageTextBox.TabIndex = 1;
            this.LanguageTextBox.TextChanged += new System.EventHandler(this.LanguageTextBox_TextChanged);
            // 
            // AddLanguageButton
            // 
            this.AddLanguageButton.Location = new System.Drawing.Point(303, 356);
            this.AddLanguageButton.Name = "AddLanguageButton";
            this.AddLanguageButton.Size = new System.Drawing.Size(144, 24);
            this.AddLanguageButton.TabIndex = 2;
            this.AddLanguageButton.Text = "Add Language";
            this.AddLanguageButton.UseVisualStyleBackColor = true;
            this.AddLanguageButton.Click += new System.EventHandler(this.AddLanguageButton_Click);
            // 
            // RemoveLanguageButton
            // 
            this.RemoveLanguageButton.Location = new System.Drawing.Point(453, 356);
            this.RemoveLanguageButton.Name = "RemoveLanguageButton";
            this.RemoveLanguageButton.Size = new System.Drawing.Size(144, 24);
            this.RemoveLanguageButton.TabIndex = 3;
            this.RemoveLanguageButton.Text = "Remove Language";
            this.RemoveLanguageButton.UseVisualStyleBackColor = true;
            this.RemoveLanguageButton.Click += new System.EventHandler(this.RemoveLanguageButton_Click);
            // 
            // LanguageManagementElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveLanguageButton);
            this.Controls.Add(this.AddLanguageButton);
            this.Controls.Add(this.LanguageTextBox);
            this.Controls.Add(this.LanguagesTable);
            this.Name = "LanguageManagementElement";
            this.Size = new System.Drawing.Size(600, 384);
            this.Load += new System.EventHandler(this.LanguageManagementElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LanguagesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView LanguagesTable;
        private TextBox LanguageTextBox;
        private Button AddLanguageButton;
        private Button RemoveLanguageButton;
        private DataGridViewTextBoxColumn Languages;
    }
}
