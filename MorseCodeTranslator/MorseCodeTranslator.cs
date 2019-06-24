using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeTranslator
{
    static class MorseCodeTranslator
    {
        //static constructor 
        //no need access modifier since static constructor never been called, only init once bofore any member called
        static MorseCodeTranslator()
        {
            foreach(KeyValuePair<char, string> code in _textToMorse)
            {
                _morseToText.Add(code.Value, code.Key);
            }
        }

        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };
        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        public static string ToMorse(string input)
        {
            List<string> output = new List<string>(input.Length);

            foreach(char character in input.ToUpper())
            {
                try
                {
                    string morseCode = _textToMorse[character];
                    output.Add(morseCode);
                }
                catch(KeyNotFoundException)
                {
                    output.Add("!");
                }
            }

            return string.Join(" ", output);

        }

        public static string DeMorse(string input)
        {
            string result = "";
            string[] word = input.Split(" ");
            foreach (var code in word)
            {
                try
                {
                    char letter = _morseToText[code];
                    result += letter;
                }
                catch(KeyNotFoundException)
                {
                    result += "/!";
                }

            }

            return result;
        }


    }
}
