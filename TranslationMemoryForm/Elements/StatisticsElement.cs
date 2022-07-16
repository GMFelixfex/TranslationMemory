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

namespace TranslationMemoryForm.Elements
{
    public partial class StatisticsElement : UserControl
    {
        private DataHandler dataHandler = DataHandler.GetInstance();
        private Code.User.User user;
        public StatisticsElement(Code.User.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void StatisticsElement_Load(object sender, EventArgs e)
        {
            Code.MainApp.MainStats mainStats = dataHandler.GetMainStats();
            var preuserdata = dataHandler.GetUserdata(user.Get_id());
            Code.User.Userdata userdata = new Code.User.Userdata(user.Get_id());
            if (preuserdata.Item2)
            {
                userdata = preuserdata.Item1;
            }


            StatsGrid.Rows.Add("Total Word Count", mainStats.GetWordCount());
            StatsGrid.Rows.Add("Total Fully Translated Words", mainStats.GetFullyTranslated());
            StatsGrid.Rows.Add("All Languages",string.Join(", ", mainStats.GetAllLanguages())); 
            StatsGrid.Rows.Add("Total Registered Users", mainStats.GetRegisteredUsers());
            StatsGrid.Rows.Add("Total Translations", mainStats.GetTotalTranslations());

            StatsGrid.Rows.Add("Total Words Added by "+ user.GetUsername(), userdata.GetWordsAdded());

            if (user.GetPrivileges() > 0)
            {
                StatsGrid.Rows.Add("Total Translations Added by" + user.GetUsername(), userdata.GetWordsTranslated());
                StatsGrid.Rows.Add("Connected Languages", string.Join(", ", userdata.GetConnectedLanguages())); 
            }
            

        }
    }
}
