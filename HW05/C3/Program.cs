using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(326.91m);
            WriteLine($"Amount:\t\t{money}");
            WriteLine(money.Denominations());

            money.Dollars = 336;
            money.Cents = 23;

            WriteLine($"Amount:\t\t{money}");
            WriteLine(money.Denominations());

        }
    }
}
