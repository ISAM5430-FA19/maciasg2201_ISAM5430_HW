using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(10, 6, 2019);

            Write($"Date: {date.DisplayDate()}\n");

        }
    }
}
