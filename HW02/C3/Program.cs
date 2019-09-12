using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ex: C3-11

            //  setup first counter variable
            int iCounterOne = 1;
            //  setup facorial counter variable
            int iCounterFactorial = 1;

            //  loop while factorial is less than equal to 1000
            while (iCounterFactorial <= 1000)
            {
                //  print current factorial value
                Write(iCounterFactorial + " ");
                //  multiply current factorial value by incremeneted counter value.
                iCounterFactorial *= ++iCounterOne;

            }

            //  Ex: C3-12
            WriteLine("\n");

            //  setup counters
            int iLoopCounter = 0;
            int iCounterTwo = 0;
            int iCounterThree = 1;
            int iCounterFour = 0;
            //  print first two numbers
            Write(iCounterTwo + " " + iCounterThree + " ");
            //  lop while counter <= 25
            while (iLoopCounter <= 22)
            {
                //  display fib value
                Write((iCounterFour = iCounterTwo + iCounterThree) + " ");
                //  relocate values to store previous values
                iCounterTwo = iCounterThree;
                iCounterThree = iCounterFour;
                //  increase counter
                iLoopCounter++;
            }
            WriteLine("\n");
        }
    }
}
