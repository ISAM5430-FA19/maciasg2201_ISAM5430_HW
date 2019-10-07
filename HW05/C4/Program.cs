using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park park = new Park("UHCL Letters", "Texas", "State", 7, 50, 7000, 50000m);

            WriteLine(park);
        }
    }
}
