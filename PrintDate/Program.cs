using PrintDate;

EuropeanDatePrinter printer = new();
PrintDatePrefixDecorator prefixDecorator1 = new(printer, "prefix1: ");
PrintDatePrefixDecorator prefixDecorator2 = new(prefixDecorator1, "prefix2:  ");

PrintDatePostfixDecorator postfixDecorator1 = new(prefixDecorator2, " :post1:");
PrintDatePostfixDecorator postfixDecorator2 = new(postfixDecorator1, " :post2:");

Console.WriteLine(postfixDecorator2.PrintCurrentDateTime());
