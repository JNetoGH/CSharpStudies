using System.Globalization;
using GeneralRes;

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - DateTime: a struct which represents dates
//  - Format: you can format the way the date will be shown at ToString call passing a string telling the format
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

Console.WriteLine();
GResText.WriteTitle("DATETIME STRUCT");

GResText.WriteSubTitle("Creating a DateTime");
DateTime d1 = new DateTime(2021, 10, 12, 10, 20, 33, 55);
Console.WriteLine("d1: " + d1);
GResText.PrintLine();

// formatting 
GResText.WriteSubTitle("Formatting a DateTime at ToString call");
Console.WriteLine("d1: " + d1.ToString("MM/yy"));
GResText.JumpLines();

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - IFormatProvider(Interface): tells the culture to be based, used to format things like dates and decimal number
//  - CultureInfo(Class): Defined at System.Globalization, holds a culture that is used in many ways,
//    the CultureInfo class implements the IFormatProvider Interface, and that's mostly used to set the formatting
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.WriteTitle("CultureInfo AND IFormatProvider");

GResText.WriteSubTitle("CultureInfo obj examples");
Console.WriteLine("CultureInfo.CurrentCulture: " + CultureInfo.CurrentCulture);
Console.WriteLine("Example of a new Culture: " + new CultureInfo("pt-BR"));
GResText.PrintLine();

GResText.WriteSubTitle("Manipulating DateTimes with IFormatProvider");

DateTime d2 = DateTime.ParseExact("15/10/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine("d2(en-US): " + d2.ToString(new CultureInfo("en-US")));

DateTime d3 = DateTime.ParseExact("10-18-2001 13:15:28", "MM-dd-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine("d3(pt-BR): " + d3.ToString(new CultureInfo("pt-BR")));
GResText.PrintLine();

GResText.WriteSubTitle("Manipulating Decimal Numbers with IFormatProvider");
Console.WriteLine("(2123.34).ToString(\"pt-BR\"): " + (2123.34).ToString(new CultureInfo("pt-br")));
GResText.JumpLines();

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - DateTime.Now: The property Now returns a DateTime struct that is set to the current moment    
//  - DateTIme.UtcNow: The property UtcNow returns a DateTime struct set to the current moment according to UTC
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.WriteTitle("DATETIME STRUCT FEATURES");

GResText.WriteSubTitle("DateTime Struct Properties");
DateTime thisMoment = DateTime.Now; 
Console.WriteLine("DateTime.Now: " + thisMoment);
Console.WriteLine("DateTime.Now.DayOfYear: " + thisMoment.DayOfYear);   // via variable
Console.WriteLine("DateTime.Now.DayOfWeek: " + DateTime.Now.DayOfWeek); // straight
GResText.PrintLine();

GResText.WriteSubTitle("DateTime Struct Methods");
DateTime d4 = DateTime.UtcNow;
Console.WriteLine("d4 (UtcNow): " + d4);
DateTime d5 = d4.AddDays(5);   // doesn't change the original DateTime, just returns a copy with the changes
Console.WriteLine("d5 = d4.AddDays(5)");
Console.WriteLine("d5 ********: " + d5);
Console.WriteLine("d4 (UtcNow): " + d4 + " \"Still the same\"");
