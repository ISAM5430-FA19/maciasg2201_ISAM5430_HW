using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  B1-2
            Write("B1-2) ");
            for (int i = 1; i <= 5; i++)
            {
                for(int j = i; j <= 5; j++)
                {
                    if (i != j)
                    {
                        Write($"{i},{j} ");
                    }
                }
            }
            WriteLine("\n");

            //  B1-2a
            Write("B1-2a) ");

            for(int i = 1; i <= 5; i++)
            {
                for(int j = i+1; j <= 5; j++)
                {
                    for(int k = j+1; k <= 5; k++)
                    {
                        Write($"{i},{j},{k} ");
                    }
                }
            }
            WriteLine("\n");

            //  B1-2b
            Write("B1-2b) ");
            int sum2b = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    if (i != j)
                    {
                        sum2b += i * j;
                    }
                }
            }
            Write($"Sum: {sum2b}");
            WriteLine("\n");

            //  B1-2b-3numbers
            Write("B1-2b-3#s) ");
            int sum2c = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for(int k = j + 1; k <= 5; k++) 
                    {
                        sum2c += i * j * k;
                    }
                }
            }
            Write($"3# Sum: {sum2c}");
            WriteLine("\n");

            //  B1-2b-4numbers
            Write("B1-2b-4#s) ");
            int sum2d = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for(int l = k + 1; l <= 5; l++)
                        {
                            sum2d += i * j * k * l;
                        }
                    }
                }
            }
            Write($"4# Sum: {sum2d}");
            WriteLine("\n");

            //  B1-2b-5numbers
            Write("B1-2b-5#s) ");
            int sum2e = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {
                            for(int m = l + 1; m <= 5; m++)
                            {
                                sum2e += i * j * k * l * m;
                            }
                        }
                    }
                }
            }
            Write($"5#s Sum: {sum2e}");
            WriteLine("\n");

        }

    }
}
