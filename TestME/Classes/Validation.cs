using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;



namespace TestME
{
    public static class Validation
    {
        static bool invalid = false;
       

        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper);
            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase);
        }

        public static bool IsValidSecurityCode(String str)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            if (regex.IsMatch(str))
            {
                return invalid = false;
            }
            else
                return invalid = true;
        }

        public static bool UsernameAvailibility(String str)
        {
          
                DB tDB = Utilities.AsyncDB();
                tDB.bind(new string[] { "Username", str });

                int result = tDB.nQuery("SELECT COUNT(*) FROM users WHERE  user = @Username");
                
                if (result >= 1)
                {
                    invalid = true;
                }
                else
                {
                    invalid = false;
                }

            return invalid;
        }

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

    }
}
