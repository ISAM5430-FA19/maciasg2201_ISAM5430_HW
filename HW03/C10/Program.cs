using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            //  PROMPT USER to enter a number
            Write("Enter a number: ");
            //  accept the number
            int iNumber = int.Parse(ReadLine());

            //  start a counter
            for (int i = 0; i < iNumber; i++)
            {
                //  start another counter
                for (int j = 0; j < iNumber; j++)
                {
                    //  print X
                    Write("X");
                }
                //  print new line
                WriteLine();
            }
        }
    }
}
