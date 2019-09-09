using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Ex: C2-8
            // setup a counter variable, beginning at 1
            int iCounterOne = 1;

            //  loop while counter less than equal to 100
            while (iCounterOne <= 100)
            {
                //  print current counter value
                Write(iCounterOne + " ");
                //  increment counter by doubleing current value
                iCounterOne *= 2;
            }


            //  Ex: C2-9
            WriteLine("\n");

            //  setup a counter variable beginning at 100
            int iCounterTwo = 100;

            //  loop while counter is gerater than equal to 0
            while (iCounterTwo != 0)
            {
                //  print current counter value
                Write(iCounterTwo + " ");

                //  decrement counter
                iCounterTwo /= 2;
            }


            //  Ex: C2-10
            WriteLine("\n");

            //  setup a counter variable, beginning at 100
            decimal dCounterThree = 100;

            //  loop whiel counter is greater than equal to 1
            while (dCounterThree >= 1)
            {
                //  print current counter value
                Write(dCounterThree + " ");

                //  decremenet counter by half
                dCounterThree /= 2;
            }

        }

    }
}
