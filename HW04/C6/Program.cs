using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iLetterCount = 0;
            while (true)
            {
                var keyInfo = ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;
                iLetterCount++;

            }
            WriteLine($"\nLetters: {iLetterCount}");
        }

    }
}
