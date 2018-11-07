namespace RobbersLang
{
    using System;
    using System.Linq;

    public class Translator
    {
        public string Encode(string input)
        {
            var data = input.Select(ToRobberish);
            return string.Join("", data);
        }

        private string ToRobberish(char c)
        {
            if (CharHelper.IsConsonant(c))
            {
                return c + ("o" + c).ToLower();
            }

            return c.ToString();
        }

        internal static class CharHelper
        {
            static char[] vowels = "AEIOUYÅÄÖ".ToCharArray();

            internal static bool IsConsonant(char c)
            {
                return char.IsLetter(c) && !vowels.Contains(c.ToString().ToUpper().First());
            }
        }
    }
}
