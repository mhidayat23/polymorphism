using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cannon : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine("Cannon display dimension : 9.5*12");
            Console.WriteLine("Cannon Printer Printing......");
        }

    }
}