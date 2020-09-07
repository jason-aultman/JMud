using System;

namespace JMud
{
    public static class InputHandler
    {
        static string GetUserInputAsString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static string ParseActionFromString(string stringToParse)
        {
            var parsedString = stringToParse.Substring(0, stringToParse.IndexOf(' '));
            return parsedString;
        }

        static string ParseObjectFromString(string stringToParse)
        {
            var parsedString = stringToParse.Substring(stringToParse.IndexOf(' '));
            return parsedString;

        }
    }
}