/*  Homework 02
 *  Guadalupe Macias
 *  ISAM 5430
 *  B1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Prompt for first integer
            Console.Write("Enter the first integer: ");
            //  Read in first entry integer to iOne
            int iOne = Convert.ToInt32(Console.ReadLine());

            //  prompt for second integer
            Console.Write("Enter the second integer: ");
            //  read in second integer entry to iTwo
            int iTwo = Convert.ToInt32(Console.ReadLine());

            if(iOne == iTwo)    //  are they equal?
            {
                //  print that they are the same
                Console.WriteLine($"Both numbers, {iOne} and {iTwo}, are the same.");
            } else if (iOne > iTwo)
            {
                //  print the first is greater than the second.
                Console.WriteLine($"{iOne} is greater than {iTwo}.");
            } else
            {
                //  print that two is greater
                Console.WriteLine($"{iTwo} is greater than {iOne}.");
            }
        }
    }
}
