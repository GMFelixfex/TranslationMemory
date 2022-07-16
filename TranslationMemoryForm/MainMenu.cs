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
using TranslationMemoryForm.Code.Builder;

namespace TranslationMemoryForm
{
    public partial class MainMenu : Form
    {
        DataHandler dataHandler;
        Code.User.User currentUser;
        MainMenuBuilder mainMenuBuilder;

        public MainMenu(Code.User.User user)
        {
            InitializeComponent();
            dataHandler = DataHandler.GetInstance();
            currentUser = user;

            mainMenuBuilder = new MainMenuBuilder(this, currentUser, DisplayPanel, ButtonPanel);


            LoginNameText.Text = user.GetUsername();


            if (currentUser.GetPrivileges() == Code.User.UserRoles.User) //If User
            {
                RoleNameText.Text = "User";
                mainMenuBuilder.AddUserButtons();
            }

            if (currentUser.GetPrivileges() == Code.User.UserRoles.Translator) //If Translator
            {
                RoleNameText.Text = "Translator";
                mainMenuBuilder.AddUserButtons();
                mainMenuBuilder.AddTranslatorButtons();
            }

            if (currentUser.GetPrivileges() == Code.User.UserRoles.Admin) //if Admin
            {
                RoleNameText.Text = "Admin";
                mainMenuBuilder.AddUserButtons();
                mainMenuBuilder.AddTranslatorButtons();
                mainMenuBuilder.AddAdminButtons();

            }



        }

        public bool logout = false;

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = Form1.GetInstance();
            if (!logout)
            {
                f1.Close();
            } else
            {
                f1.Show();
            }
            
        }
    }
}
