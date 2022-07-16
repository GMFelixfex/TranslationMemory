using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace TranslationMemoryForm.Code.MainApp
{
    internal class MainStats
    {
        public ObjectId _id { get; set; }
        public int wordCount { get; set; }
        public int fullyTranslated { get; set; }
        public int totalTranslations { get; set; }
        public string[] allLanguages { get; set; }
        public int registeredUsers { get; set; }

        public MainStats(int wordCount, int fullyTranslated, string[] allLanguages, int registeredUsers, int totalTranslations)
        {
            _id = DataHandling.DataHandler.GenerateId();
            this.wordCount = wordCount;
            this.fullyTranslated = fullyTranslated;
            this.allLanguages = allLanguages;
            this.registeredUsers = registeredUsers;
            this.totalTranslations = totalTranslations;
        }

        public MainStats()
        {
            _id = DataHandling.DataHandler.GenerateId();
            wordCount = 0;
            fullyTranslated = 0;
            allLanguages = new string[0];
            registeredUsers = 0;
            totalTranslations = 0;
        }
        public ObjectId Get_id()
        {
            return _id;
        }
        public int GetAllLanguagesCount()
        {
            return allLanguages.Length;
        }

        public string[] GetAllLanguages()
        {
            return allLanguages;
        }

        public void AddLanguageToStats(string newlanguage)
        {
            List<string> languagesList = allLanguages.ToList();
            languagesList.Add(newlanguage);
            allLanguages = languagesList.ToArray();
            UpdateMainStats();
        }

        public void RemoveLanguageFromStats(string language)
        {
            List<string> languagesList = allLanguages.ToList();
            languagesList.Remove(language);
            allLanguages = languagesList.ToArray();
            UpdateMainStats();
        }

        public int GetWordCount()
        {
            return wordCount;
        }

        public void IncrementWordCount()
        {
            wordCount++;
            UpdateMainStats();
        }

        public void SetWordCount(int wordCount)
        {
            this.wordCount = wordCount;
            UpdateMainStats();
        }

        public int GetFullyTranslated()
        {
            return fullyTranslated;
        }

        public void IncrementFullyTranslated()
        {
            fullyTranslated++;
            UpdateMainStats();
        }

        public void SetFullyTranslated(int fullyTranslated)
        {
            this.fullyTranslated = fullyTranslated;
            UpdateMainStats();
        }

        public int GetTotalTranslations()
        {
            return totalTranslations;
        }

        public void IncrementTotalTranslations()
        {
            totalTranslations++;
            UpdateMainStats();
        }

        public void SetTotalTranslations(int totalTranslations)
        {
            this.totalTranslations = totalTranslations;
            UpdateMainStats();
        }

        public int GetRegisteredUsers()
        {
            return registeredUsers;
        }

        public void IncrementRegisteredUsers()
        {
            registeredUsers++;
            UpdateMainStats();
        }

        public void SetRegisteredUsers(int registeredUsers)
        {
            this.registeredUsers = registeredUsers;
            UpdateMainStats();
        }

        private void UpdateMainStats()
        {
            var dataHandler = DataHandling.DataHandler.GetInstance();
            dataHandler.UpdateMainStats(this);
        }


    }
}
