using System;
using System.Linq;

namespace RobbersLang
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var translateAction = GetTranslateAction(args);

            var croppedArgs = CropArgs(args);

            var response = translateAction(string.Join(" ", croppedArgs));

            System.Console.WriteLine(response);
        }

        private static string[] CropArgs(string[] args)
        {
            if (args == null || args.Length == 0)
                return args;

            return (args.First() == "decode" || args.First() == "encode")
                    ? args.Skip(1).ToArray()
                    : args;
        }

        private static Func<string, string> GetTranslateAction(string[] args)
        {
            var translator = new Translator();

            if (args?.FirstOrDefault() == "decode")
            {
                return translator.Decode;
            }

            return translator.Encode;
        }
    }
}
