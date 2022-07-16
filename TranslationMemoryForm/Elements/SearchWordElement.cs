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
using TranslationMemoryForm.Code.Words;
using TranslationMemoryForm.Code.User;

namespace TranslationMemoryForm.Elements
{
    public partial class SearchWordElement : UserControl
    {
        private DataHandler dataHandler = DataHandler.GetInstance();
        private User user;
        public SearchWordElement(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        Word[] displayedWords = new Word[0];
        Code.MainApp.MainStats mainstats = new Code.MainApp.MainStats();
        string searchedWord = "";

        private void WordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TranslationTable.Rows.Clear();
            int selectindex = e.RowIndex;
            if (selectindex < 0) selectindex = 0;

            Word selectedWord = displayedWords[selectindex];
            for (int i = 0; i < mainstats.GetAllLanguagesCount(); i++)
            {
                string translation;
                string language = mainstats.GetAllLanguages()[i];

                if (selectedWord.languages.Contains(mainstats.GetAllLanguages()[i]))
                {

                    int translationIndex = Array.IndexOf(selectedWord.GetLanguages(), language);
                    translation = selectedWord.GetTranslations()[translationIndex];
                }
                else
                {
                    translation = "(none)";
                }

                TranslationTable.Rows.Add(language, translation);
            }
        }

        private void WordSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (DataChecker.CheckIfWord(WordSearchBox.Text) || WordSearchBox.Text == "")
            {
                searchedWord = WordSearchBox.Text;
                WordSearchBox.ForeColor = Color.Black;
            }
            else
            {
                WordSearchBox.ForeColor = Color.Red;
            }
            Console.WriteLine(searchedWord);
            DisplayWords();
        }

        private void SearchWordElement_Load(object sender, EventArgs e)
        {
            displayedWords = dataHandler.GetFullWordDatabase();
            mainstats = dataHandler.GetMainStats();
            DisplayWords();
        }

        private void SubmitNewWord_Click(object sender, EventArgs e)
        {
            string wordName = WordSearchBox.Text;
            Word newWord = new Word(wordName);
            dataHandler.AddWordToDatabase(newWord, user);
            displayedWords = dataHandler.GetFullWordDatabase();
            DisplayWords();
        }

        private void DisplayWords()
        {
            WordsTable.Rows.Clear();
            bool exactWordFound = false;
            for (int i = 0; i < displayedWords.Length; i++)
            {
                //Shows Words that contain the searched term, without case sensitivity
                if (displayedWords[i].word.ToLower().Contains(searchedWord.ToLower()))
                {
                    int percent = ((displayedWords[i].GetLanguages().Length * 100) / mainstats.GetAllLanguagesCount());
                    string[] fill = new string[] { displayedWords[i].GetWord(), "" + percent + "% Translated" };
                    WordsTable.Rows.Add(fill);
                }

                //OnlyIncreases if the Exact word waas found, without case sensitivity
                if (displayedWords[i].word.ToLower() == searchedWord.ToLower() || searchedWord == "")
                {
                    exactWordFound = true;
                }

            }

            // If word does not exist, eneables the Button to submit the word
            if (exactWordFound)
            {
                SubmitNewWord.Enabled = false;
            }
            else
            {
                SubmitNewWord.Enabled = true;
            }

        }
    }
}
