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
            Student Me = new Student("Macias", "Guadalupe", 1515993);

            Write($"Full Name: {Me.FullName}\nGPA: {Me.GPA}\n");
        }
    }
}
