/*  Homework 02
 *  Guadalupe Macias
 *  ISAM 5430
 *  B2
 */
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
            //  prompt for 1st integer
            Write("Enter first integer: ");
            //  accept first interger into iOne
            int iOne = Convert.ToInt32(ReadLine());

            //  prompt for 2nd integer
            Write("Enter second integer: ");
            //  accept second interger into iTwo
            int iTwo = Convert.ToInt32(ReadLine());

            // prmopt for 3rd integer
            Write("Enter third integer: ");
            //  accept third interger into iThree
            int iThree = Convert.ToInt32(ReadLine());

            //  compare first number to second and third
            if((iTwo < iOne && iOne < iThree) || (iTwo > iOne && iOne > iThree))
            {
                //  show that 1st number is between the second and third
                WriteLine($"{iOne} is in the middle of {iTwo} and {iThree}");
            } else if (iTwo == iThree)
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            } else
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            }

            //  see if second is in the middle
            if ((iOne < iTwo && iTwo < iThree) || (iOne > iTwo && iTwo > iThree))
            {
                //  print that second number is In the middle
                WriteLine($"{iTwo} is in the middle of {iOne} and {iThree}");
            }
            else if (iOne == iThree)
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            }
            else
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            }

            //  check if third number is between first and second
            if ((iTwo < iThree && iThree < iOne) || (iTwo > iThree && iThree > iOne))
            {
                //  print that the third is in the between the first and second
                WriteLine($"{iThree} is in the middle of {iTwo} and {iOne}");
            }
            else if (iTwo == iOne)
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            }
            else
            {
                //  print that there are two equal numbers
                WriteLine("You have two equal numbers");
            }

        }
    }
}
