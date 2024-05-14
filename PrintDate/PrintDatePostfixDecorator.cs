using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    public class PrintDatePostfixDecorator : IPrinterDate
    {
        private string postfix;
        private IPrinterDate printer;
        public PrintDatePostfixDecorator(IPrinterDate _printer, string _postfix)
        {
            printer = _printer;
            postfix = _postfix;
        }

        public string PrintCurrentDateTime()
        {
            StringBuilder sb = new(postfix);

            return sb.Insert(0,printer.PrintCurrentDateTime()).ToString();
        }
    }
}
