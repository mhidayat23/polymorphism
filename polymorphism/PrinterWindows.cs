using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string name { get; set; }

        public virtual void print()
        {
            Console.WriteLine(" Printer Printing.........");
        }
    }

}