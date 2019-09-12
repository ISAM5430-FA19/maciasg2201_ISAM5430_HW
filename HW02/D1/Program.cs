﻿using System;
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

            int iNumberOfPositive = 0, iNumberOfZeros = 0, iNumberOfEven = 0, iCurrentEntry;
            int iFirstHalfOne = 0, iSecondHalfOne = 0;
            int iLargest = int.MinValue, iSmallest = int.MaxValue;

            while (iWhileLoopCounter < iCount)
            {
                //  prompt user for that number
                Write($"Enter integer #{iWhileLoopCounter + 1}: ");

                //  accept user entry
                iCurrentEntry = Convert.ToInt32(ReadLine());

                //  check if even, zero
                if (iCurrentEntry == 0)
                {
                    iNumberOfZeros++;
                }
                else if (iCurrentEntry % 2 == 0) {
                    //  incremenet loop counter
                    iNumberOfEven++;
                }

                //  check if number is positive
                if(iCurrentEntry > 0)
                {
                    iNumberOfPositive++;
                }

                //  check if smallest
                if(iCurrentEntry < iSmallest)
                {
                    iSmallest = iCurrentEntry;
                }

                //  check if largest
                if(iCurrentEntry > iLargest)
                {
                    iLargest = iCurrentEntry;
                }

                if(iWhileLoopCounter == 1)
                {
                    iFirstHalfOne = iCurrentEntry;
                } else if (iWhileLoopCounter == 2)
                {
                    iFirstHalfOne += iCurrentEntry;
                } else if (iWhileLoopCounter == iCount - 1)
                {
                    iSecondHalfOne = iCurrentEntry;
                } else if (iWhileLoopCounter == iCount)
                {
                    iSecondHalfOne += iCurrentEntry;
                }



                //  increment loop counter
                iWhileLoopCounter++;
            }
            //  display results
            WriteLine($"Number of Zeros: {iNumberOfZeros}");
            WriteLine($"Number of Evens: {iNumberOfEven}");
            WriteLine($"Number of Positives: {iNumberOfPositive}");
            WriteLine($"Largest: {iLargest}");
            WriteLine($"Smallest: {iSmallest}");

            if(iFirstHalfOne == iSecondHalfOne)
            {
                WriteLine("First and Second halves are equal.");
            } else
            {
                WriteLine("First and Second havles are NOT equal.");
            }
            WriteLine("\n");
        }
    }
}
