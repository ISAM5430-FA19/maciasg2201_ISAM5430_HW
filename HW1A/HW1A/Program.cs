using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumberOne, iNumberTwo;            //declare our working variables.
            String sOperation;                              //declare our operation variable
            Console.Write("Enter an integer: ");            //Ask for first number
            iNumberOne = int.Parse(Console.ReadLine());     //Accept first number from user
            Console.Write("Enter another integer: ");       //Ask for second number
            iNumberTwo = int.Parse(Console.ReadLine());     //Accept second number from user

            Console.Write("Enter operation ( * / + - ): ");     //Ask for operation
            sOperation = Console.ReadLine();                       //Accept operation


            if (sOperation == "*")
            {
                //multiplication
                int iMul = iNumberOne * iNumberTwo;
                Console.WriteLine($"Multiplying {iNumberOne} and {iNumberTwo} equals {iMul}");
            }

            if (sOperation == "/")
            {
                //division
                int iDiv = iNumberOne / iNumberTwo;
                Console.WriteLine($"Dividing {iNumberOne} by {iNumberTwo} equals {iDiv}");
            }

            if (sOperation == "+")
            {
                //addition
                int iSum = iNumberOne + iNumberTwo;
                Console.WriteLine($"Adding {iNumberOne} and {iNumberTwo} equals {iSum}");
            }

            if (sOperation == "-")
            {
                //subtraction
                int iSub = iNumberOne - iNumberTwo;
                Console.WriteLine($"Subtracting {iNumberTwo} from {iNumberOne} equals {iSub}");
            }
        }
    }
}
