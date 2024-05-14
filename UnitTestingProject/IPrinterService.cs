using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public interface IPrinterService
    {
        bool IsPrinterAvailable();
        void Print(string content);
    }
}
