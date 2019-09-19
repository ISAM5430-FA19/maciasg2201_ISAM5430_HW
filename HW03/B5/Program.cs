using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create variable for item, user entry and lowest
            int iItem, iUserEntry, iLowest = 0, iLowestDifference = int.MaxValue;

            //  prompt for entry if item
            Write("Enter Item Number: ");
            //  accept user entry
            iItem = int.Parse(ReadLine());

            //  the loop to prompt, accept, and compare user provided numbers
            do
            {
                //  prompt for user entry
                Write("Enter a number: ");
                //  accept user entry
                iUserEntry = int.Parse(ReadLine());

                //  check if difference between new entry is closest to last closest number.  use absolute to make sure handle negatives.
                if(Math.Abs(iItem - iUserEntry) < iLowestDifference)
                {
                    //  save the lowest number
                    iLowest = iUserEntry;
                    //  save the distance to item number. use absolute values to resolve potential negative number issue.
                    iLowestDifference = Math.Abs(iItem - iLowest);
                }

                //  display closest nubmer and distanct to item number
                WriteLine("Closest number is " + iLowest + " and is " + iLowestDifference + " away.");

                //  while loop to exit once number entered matches the original item number.
            } while (iItem != iUserEntry);
        }
    }
}
