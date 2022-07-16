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
    public partial class UserManageElement : UserControl
    {
        private DataHandler dataHandler = DataHandler.GetInstance();
        public UserManageElement()
        {
            InitializeComponent();
        }
        string searchedUser = "";
        User[] displayedUsers = new User[0];
        Code.MainApp.MainStats mainstats = new Code.MainApp.MainStats();
        User currentUser;
        Userdata userdata;

        private void UserManageElement_Load(object sender, EventArgs e)
        {
            ResetTables();
            SelectLanguageBox.Items.Clear();
            SelectLanguageBox.Items.AddRange(mainstats.GetAllLanguages());
            currentUser = displayedUsers[0];
            userdata = dataHandler.GetUserdata(currentUser.Get_id()).Item1;

        }

        private void SerachUserTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DataChecker.CheckIfWord(SerachUserTextBox.Text) || SerachUserTextBox.Text == "")
            {
                searchedUser = SerachUserTextBox.Text;
                SerachUserTextBox.ForeColor = Color.Black;
            }
            else
            {
                SerachUserTextBox.ForeColor = Color.Red;
            }
            Console.WriteLine(searchedUser);
            ResetTables();
        }


        private void UserTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ToggleOptions(true);
            currentUser = displayedUsers[e.RowIndex];
            userdata = dataHandler.GetUserdata(currentUser.Get_id()).Item1;
            SelectLanguageBox.Items.Clear();
            SelectLanguageBox.Items.AddRange(mainstats.GetAllLanguages());
        }

        string currentLanguage = "";
        private void SelectLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectLanguageBox.SelectedItem != null)
            {
                currentLanguage = (string)SelectLanguageBox.SelectedItem;
                if (userdata.GetConnectedLanguages().Contains(currentLanguage))
                {
                    AddLanguageButton.Enabled = false;
                    RemoveLanguageButton.Enabled = true;
                }
                else
                {
                    AddLanguageButton.Enabled = true;
                    RemoveLanguageButton.Enabled = false;
                }
            } else
            {
                currentLanguage = "";
            }
        }

        private void AddLanguageButton_Click(object sender, EventArgs e)
        {
            if(currentLanguage != "")
            {
                userdata.AddConnectedLanguage(currentLanguage);
                ResetTables();
                SelectLanguageBox.SelectedItem = null;
                RemoveLanguageButton.Enabled = false;
                AddLanguageButton.Enabled = false;
            }
            

        }

        private void RemoveLanguageButton_Click(object sender, EventArgs e)
        {
            if (currentLanguage != "")
            {
                userdata.RemoveConnectedLanguage(currentLanguage);
                ResetTables();
                SelectLanguageBox.SelectedItem = null;
                RemoveLanguageButton.Enabled = false;
                AddLanguageButton.Enabled = false;
            }
            
        }

        private void ConverToUserButton_Click(object sender, EventArgs e)
        {
            currentUser.SetPrivileges(UserRoles.User);
            ResetTables();
        }

        private void ConverTranslatorButton_Click(object sender, EventArgs e)
        {
            currentUser.SetPrivileges(UserRoles.Translator);
            ResetTables();
        }

        private void ConverAdminButton_Click(object sender, EventArgs e)
        {
            currentUser.SetPrivileges(UserRoles.Admin);
            ResetTables();
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            dataHandler.RemoveUserVia_Id(currentUser.Get_id());
            ResetTables();
        }
        private void ResetTables()
        {
            ToggleOptions(false);
            mainstats = dataHandler.GetMainStats();
            displayedUsers = dataHandler.GetAllUsers();
            UserTable.Rows.Clear();
            for (int i = 0; i < displayedUsers.Length; i++)
            {
                //Shows Words that contain the searched term, without case sensitivity
                if (displayedUsers[i].GetUsername().ToLower().Contains(searchedUser.ToLower()))
                {
                    Userdata preUserdata = dataHandler.GetUserdata(displayedUsers[i].Get_id()).Item1;
                    string[] fill = new string[] { displayedUsers[i].GetUsername(), displayedUsers[i].GetPrivileges().ToString(), preUserdata.GetWordsAdded().ToString(), preUserdata.GetWordsTranslated().ToString(), string.Join(", ", preUserdata.GetConnectedLanguages()) };
                    UserTable.Rows.Add(fill);
                }

            }

            //Resets Slection to first to avoid unwanted interactions
            currentUser = displayedUsers[0];
            UserTable.CurrentCell = UserTable.Rows[0].Cells[0];
            userdata = dataHandler.GetUserdata(currentUser.Get_id()).Item1;
            ToggleOptions(true);

        }

        private void ToggleOptions(bool toggle)
        {
            AddLanguageButton.Enabled = toggle;
            RemoveLanguageButton.Enabled = toggle;
            ConverToUserButton.Enabled = toggle;
            ConverTranslatorButton.Enabled = toggle;
            ConverAdminButton.Enabled = toggle;
            RemoveUserButton.Enabled = toggle;
            SelectLanguageBox.Enabled = toggle;
        }

    }
}
