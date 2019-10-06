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
            Motorway motorway = new Motorway("Clearlake Motorway", "road", "blacktop", 4);
            motorway.Direction = "North";
            motorway.Toll = true;
            motorway.MaintainedBy = "UHCL";

            WriteLine(motorway);
            
        }
    }
}
