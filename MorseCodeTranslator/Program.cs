using System;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(":");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                string output = MorseCodeTranslator.ToMorse(input);
                Console.WriteLine(output);

            }
        }
    }
}
