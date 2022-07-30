using GeneralRes;

void PrintDate(string str, DateTime d) => Console.WriteLine($"{str}: {d}  KIND = {d.Kind}");

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Date Time Kind: its a Enum which can be Local, UTC, or Unspecified.
//    Usually severs store dates as UTC and convert to local when showing to users.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.JumpLines();
GResText.WriteTitle("DATE TIME KIND ENUM");

GResText.WriteSubTitle("Diff Kinds of DateTimeKind");
DateTime d1 = new DateTime(2000, 10, 14, 8, 20, 50, DateTimeKind.Local);
PrintDate("d1", d1);
DateTime d2 = new DateTime(2000, 10, 14, 8, 20, 50, DateTimeKind.Utc);
PrintDate("d2", d2);
DateTime d3 = new DateTime(2000, 10, 14, 8, 20, 50, DateTimeKind.Unspecified);
PrintDate("d3", d3);
DateTime d4 = new DateTime(2000, 10, 14, 8, 20, 50); // the same of Unspecified
PrintDate("d4", d4);

GResText.PrintLine();

GResText.WriteSubTitle("Converting DateTimeKinds");
PrintDate("d1(LOCAL)", d1);
PrintDate("d1  (UTC)",  d1.ToUniversalTime());
PrintDate("d2  (UTC)", d2);
PrintDate("d2(LOCAL)", d2.ToLocalTime());

GResText.JumpLines();

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - ISO 8601 standard (yyyy-MM-ddTHH:mm:ssZ): it's a standard to represent dates.
//    Automatically sets the DateKind as UTF, but when printed, will be set as Local with the time converted
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.WriteTitle("ISO 8601 STANDARD");

DateTime date = DateTime.Parse("2100-3-24 13:05:58");
PrintDate("Regular Date", date);

DateTime isoDateUTF = DateTime.Parse("2000-08-15T13:05:58Z");
PrintDate("isoDateUTF  ", isoDateUTF);
Console.WriteLine("Iso Original: 13:05:58 \"the time as converted to UTC (-1 Portugal)\"");
