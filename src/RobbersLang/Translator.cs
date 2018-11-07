namespace RobbersLang
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Translator
    {
        public string Encode(string input)
        {
            var encodedChars = input.SelectMany(ToRobberish).ToArray();
            return new string(encodedChars);
        }

        public string Decode(string encoded)
        {
            return new string(SkipEncodedChars(encoded).ToArray());
        }

        private IEnumerable<char> SkipEncodedChars(string encoded)
        {
            for (var i = 0; i < encoded.Length; i++)
            {
                yield return encoded[i];

                if (CharHelper.IsConsonant(encoded[i]) && i < encoded.Length - 1 && encoded[i + 1] == 'o')
                    i += 2;
            }
        }

        private IEnumerable<char> ToRobberish(char c)
        {
            yield return c;

            if (CharHelper.IsConsonant(c))
            {
                yield return 'o';
                yield return c.ToString().ToLower().First();
            }
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
