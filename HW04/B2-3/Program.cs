using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  B2
            for(char i = 'A'; i <= 'H'; i++)
            {
                Write($"{i}, ");
            }
            WriteLine("\n");

            //  B2-3a
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (j == 'A' || j == 'E' || i == 'A' || i == 'E')
                    {
                        if (i != j)
                        {
                            Write($"{i}{j}, ");
                        }
                    }
                }
            }
            WriteLine("\n");


            //  B2-3b
            for(char i = 'A'; i <= 'H'; i++)
            {
                for(char j = 'A'; j <= 'H'; j++)
                {
                    int vowels = (i == 'A' ? 1: 0) + (i == 'E' ? 1: 0) + (j == 'A' ? 1: 0) + (j == 'E' ? 1: 0);
                    if (vowels == 1)
                    {
                        Write($"{i}{j}, ");
                    }
                }
            }
            WriteLine("\n");

            //  B2-3c
            for(char i = 'A'; i <= 'H'; i++)
            {
                for(char j = 'A'; j <= 'H'; j++)
                {
                    if ((i != 'A' && i != 'E') && (j == 'A' || j == 'E'))
                    {
                        Write($"{i}{j}, ");
                    }
                }
            }
            WriteLine("\n");

           
        }
    }
}
