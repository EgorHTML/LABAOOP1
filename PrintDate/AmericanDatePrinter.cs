using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    public class AmericanDatePrinter : IPrinterDate
    {
        public AmericanDatePrinter()
        {

        }
        public string PrintCurrentDateTime()
        {
            DateTime currentDateAndTime = DateTime.Now;
            CultureInfo cultureInfo = new CultureInfo("en-GB");
            return currentDateAndTime.ToString("F", cultureInfo);
        }
    }
}
