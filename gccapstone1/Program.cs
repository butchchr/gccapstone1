using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gccapstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {
                
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                string firstBit = "";
                string firstVowel = "";
                Console.WriteLine("Hello user I am a Pig Latin converter: ");
                string userWords = Console.ReadLine();

                if (userWords.StartsWith("a") || userWords.StartsWith("e") || userWords.StartsWith("i") || userWords.StartsWith("o") || userWords.StartsWith("u"))
                {
                    Console.WriteLine(userWords + "way");
                }
                
                else for (int i = 0; i < userWords.Length; i++)
                    {

                        string[] words = userWords.Split(vowels, 2);

                        firstBit = userWords.Substring(0, 1);
                        firstVowel = userWords.Substring(1, userWords.Length - 1);

                    }
                Console.WriteLine(firstVowel + firstBit + "ay");

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
    }
}
