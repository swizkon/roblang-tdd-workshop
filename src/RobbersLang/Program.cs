using System;
using System.Linq;

namespace RobbersLang
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var translator = new Translator();

            Func<string, string> action = translator.Encode;

            if (args.Length > 0 && args[0] == "decode")
            {
                action = translator.Decode;
                args = args.Skip(1).ToArray();
            }

            if (args.Length > 0 && args[0] == "encode")
            {
                args = args.Skip(1).ToArray();
            }

            var response = action(string.Join(" ", args));

            System.Console.WriteLine(response);
        }
    }
}
