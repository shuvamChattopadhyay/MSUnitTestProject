using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class PrintService : IPrinterService
    {
        public bool IsPrinterAvailable()
        {
            return true;
        }

        public void Print(string content)
        {
            
        }
    }
}
