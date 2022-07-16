namespace TranslationMemoryForm.Elements
{
    public partial class SearchWordElement
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
            this.WordSearchBox = new System.Windows.Forms.TextBox();
            this.WordsTable = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslatedPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslationTable = new System.Windows.Forms.DataGridView();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitNewWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WordsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // WordSearchBox
            // 
            this.WordSearchBox.Location = new System.Drawing.Point(0, 1);
            this.WordSearchBox.Name = "WordSearchBox";
            this.WordSearchBox.PlaceholderText = "Search for a Word...";
            this.WordSearchBox.Size = new System.Drawing.Size(471, 23);
            this.WordSearchBox.TabIndex = 14;
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
            this.WordsTable.Size = new System.Drawing.Size(600, 216);
            this.WordsTable.TabIndex = 13;
            this.WordsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WordsTable_CellClick);
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
            this.TranslationTable.Location = new System.Drawing.Point(0, 252);
            this.TranslationTable.MultiSelect = false;
            this.TranslationTable.Name = "TranslationTable";
            this.TranslationTable.ReadOnly = true;
            this.TranslationTable.RowHeadersVisible = false;
            this.TranslationTable.RowTemplate.Height = 25;
            this.TranslationTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TranslationTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TranslationTable.Size = new System.Drawing.Size(600, 131);
            this.TranslationTable.TabIndex = 15;
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Width = 300;
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Translation";
            this.Translation.Name = "Translation";
            this.Translation.ReadOnly = true;
            this.Translation.Width = 300;
            // 
            // SubmitNewWord
            // 
            this.SubmitNewWord.Location = new System.Drawing.Point(477, 0);
            this.SubmitNewWord.Name = "SubmitNewWord";
            this.SubmitNewWord.Size = new System.Drawing.Size(123, 25);
            this.SubmitNewWord.TabIndex = 16;
            this.SubmitNewWord.Text = "Submit New Word";
            this.SubmitNewWord.UseVisualStyleBackColor = true;
            this.SubmitNewWord.Click += new System.EventHandler(this.SubmitNewWord_Click);
            // 
            // SearchWordElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubmitNewWord);
            this.Controls.Add(this.TranslationTable);
            this.Controls.Add(this.WordSearchBox);
            this.Controls.Add(this.WordsTable);
            this.Name = "SearchWordElement";
            this.Size = new System.Drawing.Size(600, 384);
            this.Load += new System.EventHandler(this.SearchWordElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WordsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox WordSearchBox;
        private DataGridView WordsTable;
        private DataGridView TranslationTable;
        private DataGridViewTextBoxColumn Language;
        private DataGridViewTextBoxColumn Translation;
        private Button SubmitNewWord;
        private DataGridViewTextBoxColumn Word;
        private DataGridViewTextBoxColumn TranslatedPercent;
    }
}
