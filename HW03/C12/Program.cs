using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  prompt user to enter a number
            Write("Enter a number: ");
            //  accept number
            int iNumber = int.Parse(ReadLine());

            //  start counter to iterate through numbers beginning with 2 to number entered
            for(int i = 2; i< iNumber; i++)
            {
                //  assume number is prime unless found otherwise.
                bool bPrime = true;

                //  iterate through all numbers from 2 to the first counter value
                for (int j = 2; j < i; j++){
                    
                    //  check of modulus equals 0, means not prime
                    if(i % j == 0)
                    {
                        //  set prime marker to false
                        bPrime = false;
                        //  break from counter
                        break;
                    }
                    
                }
                
                //  if prime marger is still true, number is prime
                if (bPrime)
                {
                    //  display the prime number found.
                    Write(i + " ");
                }
            }
        }
    }
}
