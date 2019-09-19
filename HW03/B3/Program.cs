using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create current and largest variables
            int iCurrent, iLargest = int.MinValue;

            while (true)
            {
                //  prompt user to enter a number.
                Write("B3) Enter a number: ");

                //  accept user number
                iCurrent = int.Parse(ReadLine());

                //  check if if number entered is larger than previous.  if not, exit loop.
                if(iCurrent > iLargest)
                {
                    //  assign current entry to largest variable
                    iLargest = iCurrent;
                 
                } else
                {
                    WriteLine("Exiting");
                    //  break out of the loop
                    break;
                }
            }
            //  check if a larger number was saved.
            if(iLargest > int.MinValue)
            {
                //  display largest number saved.
                WriteLine("Largest number entered = " + iLargest);
            }
        }
    }
}
