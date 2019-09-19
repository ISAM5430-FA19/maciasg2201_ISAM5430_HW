using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create variable to store user entered score, store count, store sum, store best score.
            int iScore = 0;
            int iScoreCount = 0;
            int iScoreSum = 0;
            int iBestScore = 0;

            //  create an infinite loop
            do
            {
                //  ask user to enter a score
                Write("Enter a score: ");
                //  accept user entered store and store in score variable.
                iScore = int.Parse(ReadLine());
                //  check if score is within valid range, break out of loop if not.
                if (iScore >= 0 && iScore <= 100)
                {
                    //  add score value to score sum
                    iScoreSum += iScore;
                    //  compare score to see if it's highest.
                    if (iScore > iBestScore)
                    {
                        //  save score best score
                        iBestScore = iScore;
                    }
                }   //  break of score is not within valid range.
                else
                {
                    //  break out of the lop
                    break;
                }

                //  incremenet score count
                iScoreCount++;
            } while (true);

            //  display best and average score if score count > 0
            if(iScoreCount > 0)
            {
                //  display results.
                WriteLine("Best Score: " + iBestScore + "\nAverage: " + iScoreSum / iScoreCount);
            } else
            {
                //  display that no scores were entered.
                WriteLine("No scores entered.");
            }
        }
    }
}
