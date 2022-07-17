using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace TranslationMemoryForm.Code.DataHandling //Nutzt singleton
    internal class DataHandler
    {
        private static readonly DataHandler instance = new DataHandler();
        private static MongoClientSettings settings = MongoClientSettings.FromConnectionString("mongodb+srv://Felixfex:!Fex1341@forgisgm.koewa.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        private static MongoClient client = new MongoClient(settings);
        private static IMongoDatabase database = client.GetDatabase("SoftwareDesing");

        private DataHandler()
        {

        }

        public static DataHandler GetInstance()
        {
            return instance;
        }

        public static ObjectId GenerateId()
        {
            return ObjectId.GenerateNewId();
        }


        public Tuple<User.User, bool> GetUserViaLogin(string username, string password)
        {
            User.User returnUser = new User.User();
            bool userExist = false;
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("password", password);
            filter &= Builders<BsonDocument>.Filter.Eq("username", username);
            var jlist = collection.Find(filter).Limit(1).ToList();

            if (jlist.Count != 0)
            {
                returnUser = BsonSerializer.Deserialize<User.User>(jlist[0]);
                userExist = true;
            }
            return Tuple.Create(returnUser, userExist);
        }
        public Tuple<User.User, bool> GetUserVia_Id(ObjectId _id)
        {
            User.User returnUser = new User.User();
            bool userExist = false;
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", _id);
            var jlist = collection.Find(filter).Limit(1).ToList();

            if (jlist.Count != 0)
            {
                returnUser = BsonSerializer.Deserialize<User.User>(jlist[0]);
                userExist = true;
            }
            return Tuple.Create(returnUser, userExist);
        }
        public Tuple<User.User, bool> RemoveUserViaLogin(string username, string password)
        {
            User.User returnUser = new User.User();
            bool userExist = false;
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("password", password);
            filter &= Builders<BsonDocument>.Filter.Eq("username", username);
            var deletedUser = collection.FindOneAndDelete(filter);

            returnUser = BsonSerializer.Deserialize<User.User>(deletedUser);
            if (returnUser.GetEmail() == "")
            {
                userExist = false;
            }
            return Tuple.Create(returnUser, userExist);
        }
        public Tuple<User.User, bool> RemoveUserVia_Id(ObjectId _id)
        {
            User.User returnUser = new User.User();
            bool userExist = true;
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", _id);
            var deletedUser = collection.FindOneAndDelete(filter);

            returnUser = BsonSerializer.Deserialize<User.User>(deletedUser);
            if (returnUser.GetEmail() == "")
            {
                userExist = false;
            }
            return Tuple.Create(returnUser, userExist);
        }
        public User.User[] GetAllUsers()
        {
            var collection = database.GetCollection<BsonDocument>("Users");
            var returnQuery = collection.Find(_ => true).ToList();
            List<User.User> allUsersList = new List<User.User>();
            foreach (var item in returnQuery)
            {
                allUsersList.Add(BsonSerializer.Deserialize<User.User>(item));
            }
            return allUsersList.ToArray();
        }

        public void CreateUser(string email, string username, string password)
        {
            var newUser = new User.User(email, username, password);
            var collection = database.GetCollection<User.User>("Users");
            MainApp.MainStats mainstats = GetMainStats();
            mainstats.IncrementRegisteredUsers();

            collection.InsertOne(newUser);


            CreateUserdata(newUser.Get_id());
        }
        public bool UpdateUser(User.User user)
        {
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", user.Get_id());
            var update = Builders<BsonDocument>.Update.Set("email", user.GetEmail())
                                                    .Set("username", user.GetUsername())
                                                    .Set("password", user.GetPassword())
                                                    .Set("privileges", user.GetPrivileges());

            var result = collection.UpdateOne(filter, update);
            return result.IsAcknowledged;
        }

        public Tuple<User.Userdata, bool> GetUserdata(ObjectId user_id)
        {
            User.Userdata returnUserData = new User.Userdata(user_id);
            bool userExist = false;
            var collection = database.GetCollection<User.Userdata>("Userdata");
            var filter = Builders<User.Userdata>.Filter.Eq("user_id", user_id);
            var jlist = collection.Find(filter).Limit(1).ToList();

            if (jlist.Count != 0)
            {
                returnUserData = jlist[0];
                userExist = true;
            }
            return Tuple.Create(returnUserData, userExist);
        }
        public void CreateUserdata(ObjectId user_id)
        {
            var newUserdata = new User.Userdata(user_id);
            var collection = database.GetCollection<BsonDocument>("Userdata");
            var NewBsonUserdata = newUserdata.ToBsonDocument();

            collection.InsertOne(NewBsonUserdata);

        }
        public bool UpdateUserdata(ObjectId user_id, User.Userdata userdata)
        {
            var collection = database.GetCollection<User.Userdata>("Userdata");
            var filter = Builders<User.Userdata>.Filter.Eq("user_id", user_id);
            var update = Builders<User.Userdata>.Update.Set("addedWords", userdata.GetWordsAdded())
                .Set("translatedWords", userdata.GetWordsTranslated())
                .Set("connectedLanguages", userdata.GetConnectedLanguages());
            
            var result = collection.UpdateOne(filter, update);

            return result.IsAcknowledged;
        }


        public bool CheckIfNameUsed(string username)
        {
            bool userExist = false;
            var collection = database.GetCollection<User.User>("Users");
            var filter = Builders<User.User>.Filter.Eq("username", username);
            var jlist = collection.Find(filter).Limit(1).ToList();

            if (jlist.Count != 0)
            {
                userExist = true;
            }
            return userExist;
        }

        public bool CheckIfEmailUsed(string email)
        {
            bool userExist = false;
            var collection = database.GetCollection<User.User>("Users");
            var filter = Builders<User.User>.Filter.Eq("username", email);
            var jlist = collection.Find(filter).Limit(1).ToList();

            if (jlist.Count != 0)
            {
                userExist = true;
            }
            return userExist;
        }


        public void AddWordToDatabase(Words.Word word, User.User user)
        {
            var collection = database.GetCollection<BsonDocument>("Words");
            collection.InsertOne(word.ToBsonDocument());

            //Updates the Userdate to increment the Word Counter
            var preUserdata = GetUserdata(user.Get_id());
            if (preUserdata.Item2)
            {
                preUserdata.Item1.IncrementWordsAdded();
            }

            //Increments the total wordcount
            var mainStats = GetMainStats();
            mainStats.IncrementWordCount();

            
        }

        public bool RemoveWordFromDatabase(Words.Word word)
        {
            var collection = database.GetCollection<BsonDocument>("Words");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", word.Get_id());
            var result = collection.DeleteOne(word.ToBsonDocument());
            return result.IsAcknowledged;
        }

        public bool UpdateWordInDatabase(Words.Word word)
        {
            var collection = database.GetCollection<BsonDocument>("Words");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", word.Get_id());
            var result = collection.ReplaceOne(filter, word.ToBsonDocument());
            return result.IsAcknowledged;
        }
        public Words.Word[] GetFullWordDatabase()
        {
            var collection = database.GetCollection<Words.Word>("Words");
            var filter = Builders<Words.Word>.Filter.Empty;
            var allWords = collection.Find(filter).ToList().ToArray();

            return allWords;
        }

        public bool ReplaceFullWordDatabase(Words.Word[] newWords)
        {
            var collection = database.GetCollection<Words.Word>("Words");
            var filter = Builders<Words.Word>.Filter.Empty;
            var result = collection.DeleteMany(filter);

            if (result.IsAcknowledged)
            {
                collection.InsertMany(newWords);
                return true;
            }
            else
            {
                return false;
            }

        }

        public void RemoveLanguageFromDatabase(string language)
        {
            MainApp.MainStats mainStats = GetMainStats();
            mainStats.RemoveLanguageFromStats(language);

            Words.Word[] allWords = GetFullWordDatabase();
            for (int i = 0; i < allWords.Length; i++)
            {
                allWords[i].RemoveLanguageAndTranslation(language);
            }
        }



        public MainApp.MainStats GetMainStats()
        {
            var collection = database.GetCollection<MainApp.MainStats>("MainStats");
            var filter = Builders<MainApp.MainStats>.Filter.Empty;
            var mainstats = collection.Find(filter).ToList().ToArray();
            return mainstats[0];
        

        }

        public bool UpdateMainStats(MainApp.MainStats mainStats)
        {
            var collection = database.GetCollection<MainApp.MainStats>("MainStats");
            var filter = Builders<MainApp.MainStats>.Filter.Eq("_id", mainStats.Get_id());
            var update = Builders<MainApp.MainStats>.Update.Set("wordCount",mainStats.GetWordCount())
                                                    .Set("fullyTranslated", mainStats.GetFullyTranslated())
                                                    .Set("allLanguages", mainStats.GetAllLanguages())
                                                    .Set("registeredUsers", mainStats.GetRegisteredUsers())
                                                    .Set("totalTranslations", mainStats.GetTotalTranslations());
            UpdateOptions options = new UpdateOptions() {IsUpsert = true };
            var result = collection.UpdateOne(filter, update, options);

            return result.IsAcknowledged;
        }

    }
}
