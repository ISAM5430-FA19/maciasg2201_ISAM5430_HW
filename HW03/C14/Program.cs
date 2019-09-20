using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C14
{
    class Program
    {
        static void Main(string[] args)
        {
            //  display pattern A
            WriteLine("(a)");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            //  display pattern B
            WriteLine("(b)");
            for(int i = 10; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }

            //  display pattern C
            WriteLine("(c)");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Write(" ");
                }
                for(int k = 0; k < 10 -i; k++)
                {
                    Write("*");
                }
                WriteLine();
            }

            //  display pattern D
            WriteLine("(d)");
            for(int i = 0; i < 10; i++)
            {
                for(int k = 0; k < (9 - i); k++)
                {
                    Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
