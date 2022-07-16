namespace TranslationMemoryForm.Elements
{
    partial class TranslationElement
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
            this.TranslationTable = new System.Windows.Forms.DataGridView();
            this.WordSearchBox = new System.Windows.Forms.TextBox();
            this.WordsTable = new System.Windows.Forms.DataGridView();
            this.TranslationTextBox = new System.Windows.Forms.TextBox();
            this.SubmitTranslationButton = new System.Windows.Forms.Button();
            this.AllWords = new System.Windows.Forms.CheckBox();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslatedPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // TranslationTable
            // 
            this.TranslationTable.AllowUserToAddRows = false;
            this.TranslationTable.AllowUserToDeleteRows = false;
            this.TranslationTable.AllowUserToResizeColumns = false;
            this.TranslationTable.AllowUserToResizeRows = false;
            this.TranslationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranslationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Language,
            this.Translation});
            this.TranslationTable.Location = new System.Drawing.Point(0, 180);
            this.TranslationTable.MultiSelect = false;
            this.TranslationTable.Name = "TranslationTable";
            this.TranslationTable.ReadOnly = true;
            this.TranslationTable.RowHeadersVisible = false;
            this.TranslationTable.RowTemplate.Height = 25;
            this.TranslationTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TranslationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TranslationTable.Size = new System.Drawing.Size(600, 171);
            this.TranslationTable.TabIndex = 18;
            this.TranslationTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TranslationTable_CellClick);
            // 
            // WordSearchBox
            // 
            this.WordSearchBox.Location = new System.Drawing.Point(0, 1);
            this.WordSearchBox.Name = "WordSearchBox";
            this.WordSearchBox.PlaceholderText = "Search for a Word...";
            this.WordSearchBox.Size = new System.Drawing.Size(482, 23);
            this.WordSearchBox.TabIndex = 17;
            this.WordSearchBox.TextChanged += new System.EventHandler(this.WordSearchBox_TextChanged);
            // 
            // WordsTable
            // 
            this.WordsTable.AllowUserToAddRows = false;
            this.WordsTable.AllowUserToDeleteRows = false;
            this.WordsTable.AllowUserToResizeColumns = false;
            this.WordsTable.AllowUserToResizeRows = false;
            this.WordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.TranslatedPercent});
            this.WordsTable.Location = new System.Drawing.Point(0, 29);
            this.WordsTable.MultiSelect = false;
            this.WordsTable.Name = "WordsTable";
            this.WordsTable.ReadOnly = true;
            this.WordsTable.RowHeadersVisible = false;
            this.WordsTable.RowTemplate.Height = 25;
            this.WordsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WordsTable.Size = new System.Drawing.Size(600, 145);
            this.WordsTable.TabIndex = 16;
            this.WordsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WordsTable_CellClick);
            // 
            // TranslationTextBox
            // 
            this.TranslationTextBox.Enabled = false;
            this.TranslationTextBox.Location = new System.Drawing.Point(0, 357);
            this.TranslationTextBox.Name = "TranslationTextBox";
            this.TranslationTextBox.PlaceholderText = "Enter your Translation";
            this.TranslationTextBox.Size = new System.Drawing.Size(464, 23);
            this.TranslationTextBox.TabIndex = 19;
            this.TranslationTextBox.TextChanged += new System.EventHandler(this.TranslationTextBox_TextChanged);
            // 
            // SubmitTranslationButton
            // 
            this.SubmitTranslationButton.Enabled = false;
            this.SubmitTranslationButton.Location = new System.Drawing.Point(470, 356);
            this.SubmitTranslationButton.Name = "SubmitTranslationButton";
            this.SubmitTranslationButton.Size = new System.Drawing.Size(130, 25);
            this.SubmitTranslationButton.TabIndex = 20;
            this.SubmitTranslationButton.Text = "Submit Translation";
            this.SubmitTranslationButton.UseVisualStyleBackColor = true;
            this.SubmitTranslationButton.Click += new System.EventHandler(this.SubmitTranslationButton_Click);
            // 
            // AllWords
            // 
            this.AllWords.AutoSize = true;
            this.AllWords.Location = new System.Drawing.Point(488, 5);
            this.AllWords.Name = "AllWords";
            this.AllWords.Size = new System.Drawing.Size(109, 19);
            this.AllWords.TabIndex = 21;
            this.AllWords.Text = "Show All Words";
            this.AllWords.UseVisualStyleBackColor = true;
            this.AllWords.CheckedChanged += new System.EventHandler(this.AllWords_CheckedChanged);
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Word.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Word.Width = 300;
            // 
            // TranslatedPercent
            // 
            this.TranslatedPercent.HeaderText = "Translated in %";
            this.TranslatedPercent.Name = "TranslatedPercent";
            this.TranslatedPercent.ReadOnly = true;
            this.TranslatedPercent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TranslatedPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TranslatedPercent.Width = 300;
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Language.Width = 300;
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Translation";
            this.Translation.Name = "Translation";
            this.Translation.ReadOnly = true;
            this.Translation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Translation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Translation.Width = 300;
            // 
            // TranslationElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllWords);
            this.Controls.Add(this.SubmitTranslationButton);
            this.Controls.Add(this.TranslationTextBox);
            this.Controls.Add(this.TranslationTable);
            this.Controls.Add(this.WordSearchBox);
            this.Controls.Add(this.WordsTable);
            this.Name = "TranslationElement";
            this.Size = new System.Drawing.Size(600, 384);
            this.Load += new System.EventHandler(this.TranslationElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TranslationTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView TranslationTable;
        private TextBox WordSearchBox;
        private DataGridView WordsTable;
        private TextBox TranslationTextBox;
        private Button SubmitTranslationButton;
        private CheckBox AllWords;
        private DataGridViewTextBoxColumn Language;
        private DataGridViewTextBoxColumn Translation;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn TranslatedPercent;
    }
}
