using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;    

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create holding variables for the 3 sides
            int iSideOne = int.MaxValue, iSideTwo = int.MaxValue, iSideThree = int.MaxValue;
            Boolean bExit = false;
            bool bValidTriangle = false;

            //  loop
            do
            {
                //  prompt user for first side
                Write("Enter Side 1: ");
                //  accept user entry for side 1
                iSideOne = int.Parse(ReadLine());
                //  check if positive, break otherwise
                if (iSideOne < 0)
                {
                    //  break loop
                    break;
                }

                //  prompt user for second side
                Write("Enter Side 2: ");
                //  accept user entry for side 2
                iSideTwo = int.Parse(ReadLine());
                //  check if positive, break otherwise
                if (iSideTwo < 0)
                {
                    //  break loop
                    break;
                }

                //  prompt user for third side
                Write("Enter Side 3: ");
                //  accept user entry for side 3
                iSideThree = int.Parse(ReadLine());
                //  check if positive, break otherwise
                if (iSideThree < 0)
                {
                    //  break loop
                    break;
                }

                //  check if valid, and set valid variable true causing loop to exit.
                if((iSideOne + iSideTwo) > iSideThree && (iSideOne + iSideThree) > iSideTwo && (iSideTwo + iSideThree) > iSideOne)
                {
                    //  display result
                    WriteLine("That is a VALID triangle.");

                } else
                {
                    //  display triangle is invalid
                    WriteLine("That is an INVALID triangle.");
                }
            } while (!bExit);

        }
    }
}
