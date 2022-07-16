using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationMemoryForm.Code.Builder;

namespace TranslationMemoryForm.Elements
{
    public partial class UserButtons : UserControl
    {
        MainMenuBuilder mainMenuBuilder;
        MainMenu mainMenu;

        public UserButtons(MainMenuBuilder mainMenuBuilder, MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenuBuilder = mainMenuBuilder;
            this.mainMenu = mainMenu;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            mainMenuBuilder.AddSatisticsPanel();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            mainMenuBuilder.AddWordPanel();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            mainMenu.logout = true;
            mainMenu.Close();
        }

        private void ExitButtonMain_Click(object sender, EventArgs e)
        {
            mainMenu.Close();
        }
    }
}
