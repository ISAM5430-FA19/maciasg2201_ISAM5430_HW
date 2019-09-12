using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ask use to enter a number
            Write("Enter a count: ");
            int iCount = Convert.ToInt32(ReadLine());

            //  setup while loop counter
            int iWhileLoopCounter = 0;

            //  setup integer array, size is equal to count
            int[] iArrNumbers = new int[iCount];

            while (iWhileLoopCounter < iCount)
            {
                //  prompt user for that number
                Write($"Enter integer #{iWhileLoopCounter + 1}: ");
                iArrNumbers[iWhileLoopCounter] = Convert.ToInt32(ReadLine());

                //  incremenet loop counter
                iWhileLoopCounter++;
            }
            WriteLine("\n");
        }
    }
}
