using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    public class PrintDatePrefixDecorator : IPrinterDate
    {
        private string prefix;
        private IPrinterDate printer;
        public PrintDatePrefixDecorator(IPrinterDate _printer, string _prefix)
        {
            printer = _printer;
            prefix = _prefix;
        }

        public string PrintCurrentDateTime()
        {
            StringBuilder sb = new(prefix);

            return sb.Append(printer.PrintCurrentDateTime()).ToString();
        }
    }
}
