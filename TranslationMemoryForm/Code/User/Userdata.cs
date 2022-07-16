using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace TranslationMemoryForm.Code.User
{
    internal class Userdata
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public MongoDB.Bson.ObjectId user_id { get; set; }
        public int addedWords { get; set; }
        public int translatedWords { get; set; }
        public string[] connectedLanguages { get; set; }

        public Userdata(ObjectId user_id)
        {
            this._id = DataHandling.DataHandler.GenerateId();
            this.user_id = user_id;
            this.addedWords = 0;
            this.translatedWords = 0;
            connectedLanguages = new string[0];
        }

        public ObjectId Get_id()
        {
            return _id;
        }
        public ObjectId Get_UserId()
        {
            return user_id;
        }
        public void Set_UserId(ObjectId user_id)
        {
            this.user_id = user_id;
            UpdateUserdata();
        }
        public int GetWordsAdded()
        {
            return addedWords;
        }

        public void IncrementWordsAdded()
        {
            addedWords += 1;
            UpdateUserdata();
        }

        public void SetWordsAdded(int addedWords)
        {
            this.addedWords = addedWords;
            UpdateUserdata();
        }

        public int GetWordsTranslated()
        {
            return translatedWords;
        }

        public void IncrementWordsTranslated()
        {
            translatedWords += 1;
            UpdateUserdata();
        }

        public void SetWordsTranslated(int translatedWords)
        {
            this.translatedWords = translatedWords;
            UpdateUserdata();

        }

        public string[] GetConnectedLanguages()
        {
            return connectedLanguages;
        }

        public void AddConnectedLanguage(string language)
        {
            List<string> connectedLanguagesList = connectedLanguages.ToList();
            if (!connectedLanguagesList.Contains(language))
            {
                connectedLanguagesList.Add(language);
            }
            connectedLanguages = connectedLanguagesList.ToArray();
            UpdateUserdata();
        }

        public void SetConnectedLanguages(string[] connectedLanguages)
        {
            this.connectedLanguages = connectedLanguages;
            UpdateUserdata();
        }

        public void RemoveConnectedLanguage(string language)
        {
            List<string> connectedLanguagesList = connectedLanguages.ToList();
            connectedLanguagesList.Remove(language);
            connectedLanguages = connectedLanguagesList.ToArray();
            UpdateUserdata();
        }

        private void UpdateUserdata()
        {
            var dataHandler = DataHandling.DataHandler.GetInstance();
            dataHandler.UpdateUserdata(user_id,this);
        }
    }
}
