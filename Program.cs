using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows epson = new Printer();
            PrinterWindows canon = new Printer();
            PrinterWindows laserjet = new Printer();

            epson.merkPrinter = "Epson";
            canon.merkPrinter = "Canon";
            laserjet.merkPrinter = "LaserJet";

            Console.WriteLine("Beberapa printer yang online");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("\nPilih printer [1..3] : ");
            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                epson.print();
                epson.show();
            }
            else if (pilih == 2)
            {
                canon.print();
                canon.show();
            }
            else if (pilih == 3)
            {
                laserjet.print();
                laserjet.show();
            }
            else
                Console.WriteLine("Printer {0} tidak tersedia", pilih);

            Console.ReadKey();
        }
    }
}
