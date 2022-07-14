using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class LaserJet : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
            Console.WriteLine("LaserJet Printer Printing......");
        }

    }
}