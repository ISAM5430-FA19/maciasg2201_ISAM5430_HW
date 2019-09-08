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
            //  prompt for a decimal number
            Write("Enter a decimal number between 0 and 4: ");
            //  accept GPA and assign to dGPA
            decimal dGPA = Convert.ToDecimal(ReadLine());
            
            //  verity entered value is within range.
            if(dGPA >= 0 && dGPA <= 4)

            {
                //  multiply gpa by 3 and add .5
                int iGPA = (int)(dGPA * 3 + 0.5m);

                //  check value and determine letter grade
                switch (iGPA)
                {
                    case 0:
                    case 1:
                    case 2:
                        //  for values of 0 = 2, print F
                        Write($"{dGPA} is a F");
                        break;

                    case 3:
                    case 4:
                        //  for values of 3 - 4, print D
                        Write($"{dGPA} is a D");
                        break;

                    case 5:
                    case 6:
                    case 7:
                        //  for values of 5 - 7, print C
                        Write($"{dGPA} is a C");
                        break;

                    case 8:
                    case 9:
                    case 10:
                        //  for values of 8 - 10, print B
                        Write($"{dGPA} is a B");
                        break;

                    case 11:
                    case 12:
                        //  for values of 11 - 12, print A
                        Write($"{dGPA} is an A");
                        break;
                }
                //  determine plus or minus
                if(iGPA == 11 || iGPA == 8)
                {
                    //  print minus
                    WriteLine("-");
                } else if (iGPA == 10 || iGPA == 7)
                {
                    //  print plus
                    WriteLine("+");
                } else
                {
                    //  print a new line
                    WriteLine("\n");
                }

            } else
            {
                //  print that entered GPS is not within the valid range.
                WriteLine("The GPA provided is not within the allowable range (0-4).");
            }

        }
    }
}
