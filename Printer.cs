using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Printer : PrinterWindows
    {
        public override void print()
        {
            Console.WriteLine("\n{0} Printer Printing...", merkPrinter);
        }

        public override void show()
        {
            string dimension;
            if (merkPrinter == "Epson")
                dimension = "10*11";
            else if (merkPrinter == "Canon")
                dimension = "9.5*12";
            else
                dimension = "12*12";
            Console.WriteLine("{0} printer display dimension : {1}", merkPrinter, dimension);
        }
    }
}
