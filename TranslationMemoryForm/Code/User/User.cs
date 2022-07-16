using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationMemoryForm.Code.User
{
    public class User
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public UserRoles privileges { get; set; }


        public User(string email, string username, string password)
        {
            _id = DataHandling.DataHandler.GenerateId();
            this.email = email;
            this.username = username;
            this.password = password;
            privileges = UserRoles.User;
        }

        public User()
        {
            _id = DataHandling.DataHandler.GenerateId();
            email = "";
            username = "";
            password = "";
            privileges = UserRoles.User;
        }
        public MongoDB.Bson.ObjectId Get_id()
        {
            return _id;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetUsername()
        {
            return username;
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public UserRoles GetPrivileges()
        {
            return privileges;
        }
        public void SetPrivileges(UserRoles privileges)
        {
            this.privileges = privileges;
            UpdateUser();
        }

        private void UpdateUser()
        {
            var dataHandler = DataHandling.DataHandler.GetInstance();
            dataHandler.UpdateUser(this);
        }
    }

    public enum UserRoles
    {
        User,
        Translator,
        Admin
    }
}
