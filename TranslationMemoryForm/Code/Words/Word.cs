using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationMemoryForm.Code.Words
{
    internal class Word
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string word { get; set; }
        public string[] translations { get; set; }
        public string[] languages { get; set; }

        public Word(string word, string[] translation, string[] languages)
        {
            _id = DataHandling.DataHandler.GenerateId();
            this.word = word;
            this.translations = translation;
            this.languages = languages;
        }
        public Word(string word)
        {
            _id = DataHandling.DataHandler.GenerateId();
            this.word = word;
            this.translations = new string[0];
            this.languages = new string[0];
        }


        public Word()
        {
            _id = DataHandling.DataHandler.GenerateId();
            this.word = "";
            this.translations = new string[0];
            this.languages = new string[0];
        }

        public MongoDB.Bson.ObjectId Get_id()
        {
            return _id;
        }
        public string GetWord()
        {
            return word;
        }
        public void SetWord(string word)
        {
            this.word = word;
            UpdateWord();
        }
        public string[] GetTranslations()
        {
            return translations;
        }
        public void AddTranslation(string translation)
        {
            List<string> preTranslations = translations.ToList();
            if (!preTranslations.Contains(translation))
            {
                preTranslations.Add(translation);
            }
            translations = preTranslations.ToArray();
            UpdateWord();
        }
        public void RemoveTranslation(string translation)
        {
            List<string> preTranslations = translations.ToList();
            if (!preTranslations.Contains(translation))
            {
                preTranslations.Remove(translation);
            }
            translations = preTranslations.ToArray();
            UpdateWord();
        }
        public void UpdateTranslation(string translation, string oldtranslation)
        {
            int indesOldTranslation = Array.IndexOf(translations,oldtranslation);
            translations[indesOldTranslation] = translation;
            UpdateWord();
        }
        public string[] GetLanguages()
        {
            return languages;
        }
        public void AddLanguage(string language)
        {
            List<string> preLanguages = languages.ToList();
            if (!preLanguages.Contains(language))
            {
                preLanguages.Add(language);
            }
            languages = preLanguages.ToArray();
            UpdateWord();
        }

        public void RemoveLanguage(string language)
        {
            List<string> preLanguages = languages.ToList();
            preLanguages.Remove(language);
            languages = preLanguages.ToArray();
            UpdateWord();
        }

        public void RemoveLanguageAndTranslation(string language)
        {
            List<string> preLanguages = languages.ToList();
            int indexOfLanguage = preLanguages.IndexOf(language);

            preLanguages.RemoveAt(indexOfLanguage);

            List<string> pretranslations = translations.ToList();

            pretranslations.RemoveAt(indexOfLanguage);

            translations = pretranslations.ToArray();
            languages = preLanguages.ToArray();


            UpdateWord();
        }

        public void AddOrUpdateLanguageAndTranslation(string language, string translation)
        {
            List<string> preLanguages = languages.ToList();
            List<string> preTranslations = translations.ToList();
            if (!preLanguages.Contains(language))
            {
                preLanguages.Add(language);
                preTranslations.Add(translation);
            } else
            {
                int indexOfLanguage = preLanguages.IndexOf(language);
                preTranslations[indexOfLanguage] = translation;
            }
            languages = preLanguages.ToArray();
            translations = preTranslations.ToArray();
            UpdateWord();
        }
        private void UpdateWord()
        {
            var dataHandler = DataHandling.DataHandler.GetInstance();
            dataHandler.UpdateWordInDatabase(this);
        }
    }
}
