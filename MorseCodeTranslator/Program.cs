using System;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to morse, enter 2 to demorse");
                string option = Console.ReadLine();

                if(option == "1")
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
                else if(option == "2")
                {
                    Console.Write(":");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break;
                    }
                    string output = MorseCodeTranslator.DeMorse(input);
                    Console.WriteLine(output);
                }



            }
        }
    }
}
