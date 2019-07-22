using System;

namespace Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            string userChoice = "y";
            do
            {
                Console.WriteLine("Please enter a word:");
                string userWord = Console.ReadLine().ToLower();

                PigLatin pig1 = new PigLatin(userWord);

                Console.WriteLine(pig1.PigLatinTRanslator(userWord));

                
                //Ask user if they want to enter another word
                Console.WriteLine("Would you like to enter another word? Y/N");
                userChoice = Console.ReadLine().ToLower();

            } while (userChoice == "y");
            Console.WriteLine("Hope your enjoyed translating!");
        }
    }
}
