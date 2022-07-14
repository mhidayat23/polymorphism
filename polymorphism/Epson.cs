using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Epson : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine("Epson display dimension : 10*11");
            Console.WriteLine("Epson Printer Printing......");
        }

    }
}
