using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TranslationMemoryForm.Code.DataHandling
{
    public class DataChecker
    {
        public static bool CheckEmail(string email)
        {
            //Email-Pattern for C# from the Internet
            string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                + "@"
                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            Match emailRegex = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return emailRegex.Success;
        }

        public static bool CheckPassword(string password)
        {
            string pattern = @"^[\S+]{3,}$";
            Match passwordRegex = Regex.Match(password, pattern, RegexOptions.IgnoreCase);
            return passwordRegex.Success;
        }
        public static bool CheckName(string name)
        {
            string pattern = @"^[a-zA-Z1-9\s]{5,}$";
            Match passwordRegex = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            return passwordRegex.Success;
        }
        public static bool CheckIfWord(string input)
        {
            string pattern = @"^[\p{L}\s]+$";
            Match checkMenuInput = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            return checkMenuInput.Success;
        }
    }
}
