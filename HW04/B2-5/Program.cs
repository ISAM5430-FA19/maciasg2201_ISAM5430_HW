using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  b2-5a
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1)
                    {
                        Console.Write($"{a}{b} ");

                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';

                        int vowels = vowels2 + (vowelC ? 1 : 0);
                        int consonants = (!vowelA ? 1 : 0) + (!vowelB ? 1 : 0) + (!vowelC ? 1 : 0);

                        if (vowels == 1 || vowels == 2 || vowels == 3)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }

                    }
                }
            }
            WriteLine("\n");

            //  b2-5b
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool firstVowel = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool secondVowel = b == 'A' || b == 'E';

                    if(!firstVowel && secondVowel)
                    {
                        Console.Write($"{a}{b} ");

                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool thirdVowel = c == 'A' || c == 'E';
                        if(!firstVowel && thirdVowel)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }

                    }
                }
            }
            WriteLine("\n");

            //  b2-5c
            for (char a = 'A'; a <= 'H'; a++)
            {
                bool firstVowel = a == 'A' || a == 'E';
                for (char b = 'A'; b <= 'H'; b++)
                {
                    if(b == a) { continue; }
                    bool secondVowel = b == 'A' || b == 'E';

                    if (secondVowel)
                    {
                        Console.Write($"{a}{b} ");

                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        if(c == a || c == b) { continue; }
                        bool thirdVowel = c == 'A' || c == 'E';
                        if (secondVowel)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }

                    }
                }
            }
            WriteLine("\n");
        }



    }
}
