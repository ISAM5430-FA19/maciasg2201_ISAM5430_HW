using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace C9
{
    class Program
    {
        static void Main(string[] args)
        {
            int iLetterCount = 0;
            char cPreviousLetter = '@';
            bool bIncreasing = true;
            bool bMusical = true;
            bool bIsSecondHalf = true;
            bool bPreviousVowel = false;
            bool bIsAlternating = true;

            Write("Type someting: ");
            while (true)
            {
                var keyInfo = ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                bool bCurrentIsVowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                iLetterCount++;
                

                if(cPreviousLetter >= letter) //    increasing orders
                {
                    bIncreasing = false;
                }

                if (letter > 'G') //    musical notes
                {
                    bMusical = false;
                }

                if(letter < 'M') // second half of the alphabet
                {
                    bIsSecondHalf = false;
                }

                if(iLetterCount%2 == 0 && bPreviousVowel == bCurrentIsVowel) // alternating vowels & consonants
                {
                    bIsAlternating = false;
                }


                cPreviousLetter = letter;
                bPreviousVowel = bCurrentIsVowel;



            }
            WriteLine($"\nIncreasing: " + (bIncreasing ? "True" : "False"));
            WriteLine($"Musical Notes: " + (bMusical ? "True" : "False"));
            WriteLine($"Is Second Half: " + (bIsSecondHalf ? "True" : "False"));
            WriteLine($"Is Alternating: " + (bIsAlternating ? "True" : "False"));
        }
    }
}
