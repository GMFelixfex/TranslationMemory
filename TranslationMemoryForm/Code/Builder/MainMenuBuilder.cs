using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationMemoryForm.Code.Builder
{
    public class MainMenuBuilder
    {
        private MainMenu mainMenu;
        private User.User user;
        private Panel displayPanel;
        private Panel buttonPanel;

        public MainMenuBuilder(MainMenu mainMenu, User.User user, Panel displayPanel, Panel buttonPanel)
        {
            this.mainMenu = mainMenu;
            this.user = user;
            this.displayPanel = displayPanel;
            this.buttonPanel = buttonPanel; 
        }

        public void AddUserButtons()
        {
            Elements.UserButtons userButtons = new Elements.UserButtons(this, mainMenu);
            buttonPanel.Controls.Add(userButtons);
            userButtons.Top = 0;

        }

        public void AddTranslatorButtons()
        {
            Elements.TranslatorButtons translatorButtons = new Elements.TranslatorButtons(this);
            buttonPanel.Controls.Add(translatorButtons);
            translatorButtons.Top =150;
        }

        public void AddAdminButtons()
        {
            Elements.AdminButtons adminButtons = new Elements.AdminButtons(this);
            buttonPanel.Controls.Add(adminButtons);
            adminButtons.Top = 190;
        }

        public void AddSatisticsPanel()
        {
            DissableAllElements();
            Elements.StatisticsElement statisticsElement = new Elements.StatisticsElement(user);
            displayPanel.Controls.Add(statisticsElement);
        }

        public void AddWordPanel()
        {
            DissableAllElements();
            Elements.SearchWordElement searchWordElement = new Elements.SearchWordElement(user);
            displayPanel.Controls.Add(searchWordElement);
        }

        public void AddTranslationPanel()
        {
            DissableAllElements();
            Elements.TranslationElement translationElement = new Elements.TranslationElement(user);
            displayPanel.Controls.Add(translationElement);
        }

        public void AddUserManagerPanel()
        {
            DissableAllElements();
            Elements.UserManageElement userManageElement = new Elements.UserManageElement();
            displayPanel.Controls.Add(userManageElement);
        }

        public void AddLanguageManagerPanel()
        {
            DissableAllElements();
            Elements.LanguageManagementElement languageManagementElement = new Elements.LanguageManagementElement();
            displayPanel.Controls.Add(languageManagementElement);
        }

        private void DissableAllElements()
        {
            displayPanel.Controls.Clear();
        }
    }
}
