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
    public partial class TranslationElement : UserControl
    {
        private DataHandler dataHandler = DataHandler.GetInstance();
        private Userdata userdata;
        public TranslationElement(User user)
        {
            InitializeComponent();
            userdata = dataHandler.GetUserdata(user.Get_id()).Item1;
        }
        Word[] displayedWords = new Word[0];
        Code.MainApp.MainStats mainstats = new Code.MainApp.MainStats();
        string searchedWord = "";
        bool showAllWords = false;


        private void TranslationElement_Load(object sender, EventArgs e)
        {
            mainstats = dataHandler.GetMainStats();
            LoadCorrectWords();
            DisplayWords();
            DisplayTranslation(indexOfWord);
        }

        private void AllWords_CheckedChanged(object sender, EventArgs e)
        {
            showAllWords = AllWords.Checked;
            mainstats = dataHandler.GetMainStats();
            LoadCorrectWords();
            DisplayWords();
            DisplayTranslation(indexOfWord);

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
            LoadCorrectWords();
            DisplayWords();
            DisplayTranslation(0);
            
        }
        Word wordToTranslate = new Word();
        List<int> emptyTranslations = new List<int>();
        int indexOfWord = 0;
        private void WordsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexOfWord = e.RowIndex;
            DisplayTranslation(indexOfWord);
            
        }

        int indexOfTranslation = 0;
        string languageOftranslation = "";
        private void TranslationTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexOfTranslation = e.RowIndex;
            if(indexOfTranslation < 0) indexOfTranslation = 0;
            languageOftranslation = mainstats.GetAllLanguages()[indexOfTranslation];
            if (userdata.GetConnectedLanguages().Contains(languageOftranslation))
            {
                TranslationTextBox.Enabled = true;
                SubmitTranslationButton.Enabled = true;
            } else
            {
                TranslationTextBox.Enabled = false;
                SubmitTranslationButton.Enabled= false;
            }
            if (emptyTranslations.Contains(indexOfTranslation))
            {
                SubmitTranslationButton.Text = "Submit Translation";
            } else
            {
                SubmitTranslationButton.Text = "Update Translation";
            }
        }

        string newTranslation = "";
        private void TranslationTextBox_TextChanged(object sender, EventArgs e)
        {

            if (DataChecker.CheckIfWord(TranslationTextBox.Text))
            {
                newTranslation = TranslationTextBox.Text;
                TranslationTextBox.ForeColor = Color.Black;
                SubmitTranslationButton.Enabled = true;
            }else
            {
                TranslationTextBox.ForeColor = Color.Red;
                SubmitTranslationButton.Enabled = false;
            }

            
        }

        private void SubmitTranslationButton_Click(object sender, EventArgs e)
        {
            userdata.IncrementWordsTranslated();
            mainstats.IncrementTotalTranslations();
            if (wordToTranslate.GetLanguages().Length+1 == mainstats.GetAllLanguagesCount())
            {
                mainstats.IncrementFullyTranslated();
            }
            wordToTranslate.AddOrUpdateLanguageAndTranslation(languageOftranslation, newTranslation);


            LoadCorrectWords();
            DisplayWords();
            DisplayTranslation(indexOfWord);
        }

        private void DisplayWords()
        {
            WordsTable.Rows.Clear();
            for (int i = 0; i < displayedWords.Length; i++)
            {
                int percent = ((displayedWords[i].GetLanguages().Length * 100) / (mainstats.GetAllLanguagesCount()));
                string[] fill = new string[] { displayedWords[i].GetWord(), "" + percent + "% Translated" };
                WordsTable.Rows.Add(fill);

            }

        }

        private void DisplayTranslation(int selectindex)
        {
            if(selectindex >= WordsTable.RowCount)
            {
                selectindex = WordsTable.RowCount-1;
            }
            if(selectindex > -1)
            {
                WordsTable.CurrentCell = WordsTable.Rows[selectindex].Cells[0];
                TranslationTable.Rows.Clear();
                emptyTranslations.Clear();

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
                        emptyTranslations.Add(i);
                    }

                    TranslationTable.Rows.Add(language, translation);
                }
                wordToTranslate = displayedWords[selectindex];
                TranslationTable.CurrentCell = TranslationTable.Rows[indexOfTranslation].Cells[0];
            }  else
            {
                TranslationTable.Rows.Clear();
                emptyTranslations.Clear();
            }
            
        }

        private void LoadCorrectWords()
        {
            Word[] preDisplayedWords = dataHandler.GetFullWordDatabase();
            List<Word> newDisplayedWords = new List<Word>();
            for (int i = 0; i < preDisplayedWords.Length; i++)
            {
                if (preDisplayedWords[i].GetLanguages().Length != mainstats.GetAllLanguagesCount() || showAllWords)
                {
                    if (preDisplayedWords[i].GetWord().ToLower().Contains(searchedWord.ToLower()) || searchedWord == "")
                    newDisplayedWords.Add(preDisplayedWords[i]);
                }
            }
            displayedWords = newDisplayedWords.ToArray();
        }


    }
}
