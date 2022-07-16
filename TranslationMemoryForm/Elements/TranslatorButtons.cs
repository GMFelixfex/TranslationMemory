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
    public partial class TranslatorButtons : UserControl
    {
        private MainMenuBuilder mainMenuBuilder;
        public TranslatorButtons(MainMenuBuilder mainMenuBuilder)
        {
            InitializeComponent();
            this.mainMenuBuilder = mainMenuBuilder;
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            mainMenuBuilder.AddTranslationPanel();
        }
    }
}
