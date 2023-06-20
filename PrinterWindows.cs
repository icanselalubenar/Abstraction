using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class PrinterWindows
    {
        public string merkPrinter { get; set; }
        public string dimension { get; set; }

        public abstract void show();
        public abstract void print();
    }
}
