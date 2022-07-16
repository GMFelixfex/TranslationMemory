using System.Runtime.InteropServices;
using
    TranslationMemoryForm.Code.DataHandling;
namespace TranslationMemoryForm
{
    public partial class Form1 : Form
    {
        private static Form1 instance = new Form1();
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetInstance()
        {
            return instance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetInfoLabel();
            this.Size = new System.Drawing.Size(343, 133);

        }

        private void ExitButtonStart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool isRegistration = false;
        private void LoginButtonStart_Click(object sender, EventArgs e)
        {
            EmailTextBox.Visible = false;
            EmailTextBox.Text = "";
            isRegistration = false;
            NameTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            SubmitButton.Visible = true;

            NameTextBox.Top = 96;
            PasswordTextBox.Top = 125;
            SubmitButton.Top = 154;
            InfoLabel.Top = 183;

            SubmitLevel[0] = true;
            this.Size = new Size(343, 246);
        }

        private void RegisterButtonStart_Click(object sender, EventArgs e)
        {
            EmailTextBox.Visible = true;
            NameTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            SubmitButton.Visible = true;
            isRegistration = true;
            SubmitLevel[0] = false;

            EmailTextBox.Top = 96;
            NameTextBox.Top = 125;
            PasswordTextBox.Top = 154;
            SubmitButton.Top = 183;
            InfoLabel.Top = 212;

            this.Size = new Size(343, 275);
        }

        bool[] SubmitLevel = new bool[] {false,false,false };

        private void UpdateSubmitButton()
        {
            if (SubmitLevel.All(x => x))
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void ResetInfoLabel()
        {
            InfoLabel.Text = "";
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DataChecker.CheckEmail(EmailTextBox.Text))
            {
                EmailTextBox.ForeColor = Color.Black;
                EmailTextBox.BackColor = Color.White;
                SubmitLevel[0] = true;
            }
            else
            {
                EmailTextBox.ForeColor = Color.Red;
                SubmitLevel[0] = false;
            }

            UpdateSubmitButton();
            ResetInfoLabel();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (DataChecker.CheckName(NameTextBox.Text))
            {
                NameTextBox.ForeColor = Color.Black;
                NameTextBox.BackColor = Color.White;
                SubmitLevel[1] = true;
            }
            else
            {
                NameTextBox.ForeColor = Color.Red;
                SubmitLevel[1] = false;
            }


            UpdateSubmitButton();
            ResetInfoLabel();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DataChecker.CheckPassword(PasswordTextBox.Text))
            {
                PasswordTextBox.ForeColor = Color.Black;
                SubmitLevel[2] = true;
            }
            else
            {
                PasswordTextBox.ForeColor = Color.Red;
                SubmitLevel[2] = false;
            }
            UpdateSubmitButton();
            ResetInfoLabel();
        }


        //Login Functionality when Clicking Submit
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string name = NameTextBox.Text;
            string password = PasswordTextBox.Text;
            DataHandler dataHandler = DataHandler.GetInstance();

            Code.User.User user;
            if (isRegistration)
            {
                if (dataHandler.CheckIfEmailUsed(email))
                {
                    InfoLabel.Text = "Email already in use";
                    EmailTextBox.BackColor = Color.Red;
                    return;
                }
                else if (dataHandler.CheckIfNameUsed(name))
                {
                    InfoLabel.Text = "Name already in use";
                    NameTextBox.BackColor = Color.Red;
                    return;
                }

                dataHandler.CreateUser(email, name, password);
                Tuple<Code.User.User, bool> isLoggedIn = dataHandler.GetUserViaLogin(name, password);
                if (!isLoggedIn.Item2)
                {
                    InfoLabel.Text = "Userdata is Incorrect";
                    return;

                }
                else
                {
                    user = isLoggedIn.Item1;
                }

            } else //When logging in
            {
                Tuple<Code.User.User,bool> isLoggedIn = dataHandler.GetUserViaLogin(name, password);
                if (!isLoggedIn.Item2)
                {
                    InfoLabel.Text = "Userdata is Incorrect";
                    return;
                    
                }
                else
                {
                    user = isLoggedIn.Item1;
                }
            }

            //Clears all Texts and resets all Variables
            isRegistration = false;
            EmailTextBox.Text = "";
            NameTextBox.Text = "";
            PasswordTextBox.Text = "";
            InfoLabel.Text = "";
            EmailTextBox.Visible = false;
            NameTextBox.Visible = false;
            PasswordTextBox.Visible = false;
            SubmitButton.Visible = false;
            this.Size = new System.Drawing.Size(343, 133);



            // Opens up a Second form
            Hide();
            MainMenu f2 = new MainMenu(user);
            f2.ShowDialog();
            


        }
    }
}