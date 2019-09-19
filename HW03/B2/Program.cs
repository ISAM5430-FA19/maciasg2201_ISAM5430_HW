using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  set variable to hold sum, hold previous entry and current user entry
            int iSum = 0, iPrevious = int.MinValue, iEntry = int.MaxValue;

            //  create infinite loop. 
            while (true)
            {
                //  prompt for user entry
                Write("B2) Enter a number: ");

                //  accept user entry
                iEntry = int.Parse(ReadLine());

                //  check if entry is equal to previous
                if (iEntry == iPrevious)
                {
                    //  cue to break out of the loop
                    //  display sum
                    WriteLine("Exiting\nSum: " + iSum);
                    //  exit the loop.
                    break;
                }

                //  add user entry to the sum
                iSum += iEntry;

                //  save entry to previous entry for the next go around.
                iPrevious = iEntry;
            }


        }
    }
}
