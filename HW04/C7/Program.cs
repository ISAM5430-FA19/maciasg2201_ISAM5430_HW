using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVowels = 0, iConsonants = 0;
            bool bIsVowel;
            Write("Type someting: ");
            while (true)
            {
                var keyInfo = ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                bIsVowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                if (bIsVowel)
                {
                    iVowels++;
                } else
                {
                    iConsonants++;
                }


            }
            WriteLine($"\nVowels: {iVowels}\nConsonants: {iConsonants}");
        }
    }
}
