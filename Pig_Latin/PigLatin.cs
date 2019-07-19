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

        // Create a method to find the index of the first vowel
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
        

        // If VowelIndexer return something other than 0, substrings will be made before and after
        //the 
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

        public string CanTranslate()
        {
            Regex wordCharacters = new Regex("[0-9]");

            if (wordCharacters.IsMatch(userWord))
            {
                return userWord;
            }
            return null;
          
        }

    }

}






