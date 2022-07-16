namespace TranslationMemoryForm.Elements
{
    partial class StatisticsElement
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
            this.StatsGrid = new System.Windows.Forms.DataGridView();
            this.StatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StatsGrid
            // 
            this.StatsGrid.AllowUserToAddRows = false;
            this.StatsGrid.AllowUserToDeleteRows = false;
            this.StatsGrid.AllowUserToResizeColumns = false;
            this.StatsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StatsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatType,
            this.StatValue});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StatsGrid.Location = new System.Drawing.Point(0, 0);
            this.StatsGrid.Name = "StatsGrid";
            this.StatsGrid.ReadOnly = true;
            this.StatsGrid.RowHeadersVisible = false;
            this.StatsGrid.RowTemplate.Height = 25;
            this.StatsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatsGrid.ShowEditingIcon = false;
            this.StatsGrid.Size = new System.Drawing.Size(600, 384);
            this.StatsGrid.TabIndex = 0;
            // 
            // StatType
            // 
            this.StatType.HeaderText = "Statistics";
            this.StatType.Name = "StatType";
            this.StatType.ReadOnly = true;
            this.StatType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatType.Width = 300;
            // 
            // StatValue
            // 
            this.StatValue.HeaderText = "Value";
            this.StatValue.Name = "StatValue";
            this.StatValue.ReadOnly = true;
            this.StatValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StatValue.Width = 300;
            // 
            // StatisticsElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatsGrid);
            this.Name = "StatisticsElement";
            this.Size = new System.Drawing.Size(600, 384);
            this.Load += new System.EventHandler(this.StatisticsElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView StatsGrid;
        private DataGridViewTextBoxColumn StatType;
        private DataGridViewTextBoxColumn StatValue;
    }
}
