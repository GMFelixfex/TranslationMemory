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
    public partial class AdminButtons : UserControl
    {
        private MainMenuBuilder mainMenuBuilder;
        public AdminButtons(MainMenuBuilder mainMenuBuilder)
        {
            InitializeComponent();
            this.mainMenuBuilder = mainMenuBuilder;
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            mainMenuBuilder.AddUserManagerPanel();
        }

        private void ManageLanguagesButton_Click(object sender, EventArgs e)
        {
            mainMenuBuilder.AddLanguageManagerPanel();
        }
    }
}
