using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ask for user to enter a count
            Write("Enter a count: ");
            //  accept count from user into iCount variable.
            int iCount = Convert.ToInt32(ReadLine());
            //  setup variable to hold sum
            int iSum = 0;
            //  setup while loop founter
            int iWhileLoopCounter = 1;

            //  while look to loop for as many times as count
            while(iWhileLoopCounter <= iCount)
            {
                //  ask to enter an integer
                Write($"Enter integer number {iWhileLoopCounter}: ");
                iSum += Convert.ToInt32(ReadLine());

                //  increment while loop counter
                iWhileLoopCounter++;
            }

            //  check if Count is greater then 0 before calculating/displaying sum and average.
            if(iCount > 0)
            {
                //  display sum and average
                WriteLine($"The sum is: {iSum}\nThe average is: " + (double) iSum/iCount);
            }
        }
    }
}
