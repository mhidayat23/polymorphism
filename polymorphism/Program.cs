using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;
            Console.WriteLine(" Pilih Printer ");
            Console.WriteLine(" 1. Epson ");
            Console.WriteLine(" 2. Cannon ");
            Console.WriteLine(" 3. LaserJet\n");

            Console.Write(" Pilihan [1...3] : ");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (nomorPrinter == 1)
            {
                printer = new Epson();
                printer.print();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Cannon();
                printer.print();
            }
            else
            {
                printer = new LaserJet();
                printer.print();
            }
            Console.ReadKey();
        }
    }

}