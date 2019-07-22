using System;
using System.Text.RegularExpressions;

namespace Pig_Latin
{
    public class PigLatin
    {
        private readonly string userWord;

        public PigLatin(string userWord)
        {
            this.userWord = userWord;
        }

        public int VowelIndexer()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //int vowelIndexLocation;

            foreach (char letter in userWord)
            {
                if (userWord.IndexOfAny(vowels) != -1)
                {
                    return userWord.IndexOfAny(vowels);
                }
            }
            return 0;
        }


        public string ConsonantMover()
        {
            string wordStart;
            string wordEnd;
            int vowelLocation = VowelIndexer();

            if (vowelLocation != 0)
            {
                wordEnd = userWord.Substring(0, vowelLocation);
                wordStart = userWord.Substring(vowelLocation);
                return wordStart + wordEnd + "ay";
            }
            return userWord + "way";
        }

        //validates that the word is made up of letters
        public bool Validator()
        {
            foreach (char letter in userWord)
            {
                if (char.IsLetter(letter))
                {
                    return true;
                }
            }
            return false;
        }

        //checks to see if user input contains numbers or characters besides '
        public bool ContainsNumbersAndCharacters()
        {
            Regex wordCharacters = new Regex("[0-9\\W-[\']]");
           
            if (wordCharacters.IsMatch(userWord))
            {
                return true;
            }
            return false;

        }

        //translates text to pig latin assuming it has passed validaton and doesnt contain special characters
        // or numbers, besides ' 
        public string PigLatinTRanslator(string userWord)
        {
            if (Validator() && !ContainsNumbersAndCharacters())
            {
                return string.Join("", ConsonantMover());
            }
            else if (ContainsNumbersAndCharacters())
            {
                return userWord;
            }
            else
            {
                return "Invalid. Please try again";
            }
        }
    }
}






