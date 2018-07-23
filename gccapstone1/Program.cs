using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gccapstone1
{
    class Program
    {
        const char a = 'a';
        const char e = 'e';
        const char i = 'i';
        const char o = 'o';
        const char u = 'u';

        static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                //input and puts to lower
                Console.WriteLine("Hello user I am a Pig Latin converter, please enter a word: ");
                string userWords = Console.ReadLine();
                string lowerWords = userWords.ToLower();

                //checks to make sure the word has a a vowel and is not null or whitespace
                if (IsValid(lowerWords) && HasVowel(lowerWords))
                {
                    //checks to see if it starts with a vowel and adds way 
                    if (StartsWithVowel(lowerWords))
                    {
                        Console.WriteLine(lowerWords + "way");
                    }

                    //since we know the word does not start with a vowel, but has one, it goes here to get converted to pig latin 
                    //NOTE: will break if passed null or words with no vowels are passed to it.  Prob will also break with numbers. 
                    else
                    {
                        Console.WriteLine(StartsWithCons(lowerWords));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid");
                }

                //continue y/n
                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Continue? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                }
            }
        }

        //method to check for null or white space
        static bool IsValid(string lowerWords)
        {
            return !string.IsNullOrWhiteSpace(lowerWords);
        }

        //method to check if it has a vowel
        static bool HasVowel(string lowerWords)
        {
            return (lowerWords.Contains(a) || lowerWords.Contains(e) || lowerWords.Contains(i) || lowerWords.Contains(o) || lowerWords.Contains(u));
        }

        //method to check if it starts with a vowel
        static bool StartsWithVowel(string lowerWord)
        {
            return (lowerWord.StartsWith("a") || lowerWord.StartsWith("e") || lowerWord.StartsWith("i") || lowerWord.StartsWith("o") || lowerWord.StartsWith("u"));
        }

        //method to convert a word not starting with a vowel to pig latin
        static string StartsWithCons(string lowerWord)
        {
            int indexOfFirstVowel = lowerWord.Length + 1;
            for (int i = 0; i < vowels.Length; i++)
            {
                int indexOfVowel = lowerWord.IndexOf(vowels[i]);
                if (indexOfVowel > -1 && indexOfVowel < indexOfFirstVowel)
                {
                    indexOfFirstVowel = indexOfVowel;
                }
            }
            
            string firstBit = lowerWord.Substring(0, indexOfFirstVowel);
            string secondBit = lowerWord.Substring(indexOfFirstVowel);

            return secondBit + firstBit + "ay";
        }
    }
}