using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C8
{
    class Program
    {
        static void Main(string[] args)
        {
            int iLetterCount = 0;
            bool bPreviousVowel = false;
            int iSyllableCount = 0;
            
            Write("Type someting: ");
            while (true)
            {
                var keyInfo = ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                iLetterCount++;
                bool bCurrentIsVowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';

                if (iLetterCount%2 == 0 && bCurrentIsVowel != bPreviousVowel)
                {
                    Write(".");
                    iSyllableCount++;
                }

                bPreviousVowel = bCurrentIsVowel;
                


            }
            WriteLine($"\nSyllable Count: {iSyllableCount}");

            //  b)
            //  This method apears to work excpet in some situations where the vowel is silent, such as the "e" in "something".
        }
    }
}
