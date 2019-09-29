using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  B2-4a
            for (char i = 'A'; i <= 'H'; i++)
            {
                int vowelA = (i == 'A' ? 1 : 0) + (i == 'E' ? 1 : 0);
                for (char j = 'A'; j <= 'H'; j++)
                {
                    int vowelB = (j == 'A' ? 1 : 0) + (j == 'E' ? 1 : 0);
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        int vowelC = (k == 'A' ? 1 : 0) + (k == 'E' ? 1 : 0);
                        if (vowelA + vowelB + vowelC == 1)
                        {
                            Write($"{i}{j}{k}, ");
                        }
                    }
                }
            }
            WriteLine("\n");

            //  B2-4b
            for (char i = 'A'; i <= 'H'; i++)
            {

                for (char j = 'A'; j <= 'H'; j++)
                {
                    int vowelB = (j == 'A' ? 1 : 0) + (j == 'E' ? 1 : 0);
                    for (char k = 'A'; k <= 'H'; k++)
                    {

                        if (vowelB == 1)
                        {
                            Write($"{i}{j}{k}, ");
                        }
                    }
                }
            }
            WriteLine("\n");

            //  B2-4c
            for (char i = 'A'; i <= 'H'; i++)
            {
                int vowelA = (i == 'A' ? 1 : 0) + (i == 'E' ? 1 : 0);
                for (char j = 'A'; j <= 'H'; j++)
                {
                    int vowelB = (j == 'A' ? 1 : 0) + (j == 'E' ? 1 : 0);
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        int vowelC = (k == 'A' ? 1 : 0) + (k == 'E' ? 1 : 0);
                        if (vowelA + vowelB + vowelC <= 2)
                        {
                            Write($"{i}{j}{k}, ");
                        }
                    }
                }
            }
            WriteLine("\n");

            //  B2-4d
            for (char i = 'A'; i <= 'H'; i++)
            {

                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    bool vowelB = j == 'A' || j == 'E';
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }
                        if (vowelB)
                        {
                            Write($"{i}{j}{k}, ");
                        }
                    }
                }
            }
        }
    }
}
