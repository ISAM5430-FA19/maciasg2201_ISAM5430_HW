using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ex: C1-1
            //  establish a counter
            int iCounter = 20;

            //  loop while counter is greater than 0
            while (iCounter > 0)
            {
                //  print and decrement value.
                Write(iCounter-- + " ");
            }

            //  Ex: C1-2
            WriteLine("\n");
            int iCounterTwo = 1;

            while(iCounterTwo <= 10)
            {
                if(iCounterTwo % 2 == 0)
                {
                    Write(iCounterTwo + " ");
                }
                iCounterTwo++;
            }

            //  Ex: C1-3
            WriteLine("\n");
            //  create a counter
            int iCounterThree = 1;

            //  loop as long as counter is less than 100
            while(iCounterThree < 100)
            {
                //  check if divisible by 10
                if(iCounterThree % 10 == 0)
                {
                    //  print the counter value
                    Write(iCounterThree + " ");
                }
                //  increase counter
                iCounterThree++;
            }


            //  Ex: C1-4
            WriteLine("\n");
            //  create counter
            int iCounterFour = 0;

            //  loop while counter is less than equal to 20
            while (iCounterFour <= 20)
            {
                //  if counter value is not even and not divisible by 6
                if(iCounterFour % 2 != 0 && iCounterFour % 3 != 0)
                {
                    //  printer counter value
                    Write(iCounterFour + " ");
                 
                }
                //  increment counter
                iCounterFour++;
            }

            //  Ex: C1-5
            WriteLine("\n");
            //  create counter
            int iCounterFive = 0;

            //  loop while counter value is less than 100
            while (iCounterFive < 10)
            {
                if((iCounterFive * iCounterFive) > 10)
                {
                    Write(iCounterFive * iCounterFive + " ");
                }
                iCounterFive++;
            }


            //  Ex: C1-6
            WriteLine("\n");
            //  create counter
            int iCounterSix = 1;

            //  Lop whiel counter value is less than equal to 100
            while (iCounterSix <= 100)
            {
                //  if divisible by 15, it is also divisible by both 3 and 5
                if(iCounterSix % 15 == 0)
                {
                    //  display current counter value
                    Write(iCounterSix + " ");
                    
                    //  check if counter is divisible by 3 and not 5 or 5 and not 3
                } else if ((iCounterSix % 3 != 0 && iCounterSix % 5 == 0) || (iCounterSix % 3 == 0 && iCounterSix % 5 != 0))
                {
                    // do nothing
                } else
                {
                    //  display counter value
                    Write(iCounterSix + " ");
                }

                iCounterSix++;
            }

            //  Ex: C1-7
            WriteLine("\n");
            //set counter
            int iCounterSeven = 97;
            //  setup end value
            int iCounterSevenEnd = iCounterSeven + 25;
            //loop while counter value is less than equal to end counter (iCounterSevenEnd)
            while(iCounterSeven <= iCounterSevenEnd)
            {
                //  print char or value equal to counter
                Write((char)iCounterSeven);
                //  increment counter
                iCounterSeven++;
            }
            //  print a blank line
            WriteLine("\n");
        }
    }
}
