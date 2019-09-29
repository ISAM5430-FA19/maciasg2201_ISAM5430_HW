using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  B1-a
            Write("B1-1a) ");
            for(int i = 1; i <= 5; i++)
            {
                Write($"{i}" + (i<5?", ":""));
            }
            WriteLine("\n");

            //  B1-1b
            Write("B1-1b) ");
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <=5; j++)
                {
                    if (i != j)
                    {
                        Write($"{i},{j} ");
                    }
                }
            }
            WriteLine("\n");

            //  B1-1c
            Write("B1-1c) ");
            int sumC = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        Write($"{i + j}, ");
                        sumC += i * j;
                    }
                }
            }
            Write($"Sum: {sumC}");
            WriteLine("\n");
        }

        
    }
}
