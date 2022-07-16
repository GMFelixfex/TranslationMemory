using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationMemoryForm.Code.DataHandling;
using TranslationMemoryForm.Code.User;

namespace TranslationMemoryForm.Elements
{
    public partial class LanguageManagementElement : UserControl
    {
        private DataHandler dataHandler = DataHandler.GetInstance();
        Code.MainApp.MainStats mainstats;
        public LanguageManagementElement()
        {
            InitializeComponent();
            mainstats = dataHandler.GetMainStats();
        }

        private void LanguageManagementElement_Load(object sender, EventArgs e)
        {
            DisplayLanguages();
        }

        private void LanguagesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfLanguage = e.RowIndex;
            languageToModify = mainstats.GetAllLanguages()[indexOfLanguage];

        }
        string languageToModify = "";
        private void LanguageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DataChecker.CheckIfWord(LanguageTextBox.Text))
            {
                languageToModify = LanguageTextBox.Text;
                if (mainstats.GetAllLanguages().Contains(languageToModify))
                {
                    int indexOfLanguage = Array.IndexOf(mainstats.GetAllLanguages(), languageToModify);
                    LanguagesTable.CurrentCell = LanguagesTable.Rows[indexOfLanguage].Cells[0];
                    AddLanguageButton.Enabled = false;
                    RemoveLanguageButton.Enabled = true;
                } else
                {
                    AddLanguageButton.Enabled = true;
                    RemoveLanguageButton.Enabled = false;
                }
            }
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            mainstats.AddLanguageToStats(languageToModify);
            DisplayLanguages();
            AddLanguageButton.Enabled = false;
            RemoveLanguageButton.Enabled = true;
        }

        private void RemoveLanguageButton_Click(object sender, EventArgs e)
        {
            mainstats.RemoveLanguageFromStats(languageToModify);
            DisplayLanguages();
            AddLanguageButton.Enabled = true;
            RemoveLanguageButton.Enabled = false;
        }

        private void DisplayLanguages()
        {
            mainstats = dataHandler.GetMainStats();
            LanguagesTable.Rows.Clear();
            for (int i = 0; i < mainstats.GetAllLanguagesCount(); i++)
            {
                LanguagesTable.Rows.Add(mainstats.GetAllLanguages()[i]);
            }
        }
    }
}
