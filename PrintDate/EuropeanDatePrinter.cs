using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    public class EuropeanDatePrinter : IPrinterDate
    {
        public EuropeanDatePrinter()
        {

        }
        public string PrintCurrentDateTime()
        {
            DateTime currentDateAndTime = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo("en-US");
            return currentDateAndTime.ToString("F", cultureInfo);
        }
    }
}
