using GeneralRes;

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - TimeSpan: represents a duration of time, normally the diff between DateTimes                                      
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.JumpLines();
GResText.WriteTitle("TIME SPAN STRUCT");

GResText.WriteSubTitle("TimeSpan Range Properties, Return a TimeSpan");
Console.WriteLine($"TimeSpan.MinValue: {TimeSpan.MinValue}");
Console.WriteLine($"TimeSpan.MaxValue: {TimeSpan.MaxValue}"); 
Console.WriteLine($"TimeSpan.Zero:     {TimeSpan.Zero}");

GResText.PrintLine();

GResText.WriteSubTitle("Creating TimeSpan with Methods");
TimeSpan ts1 = TimeSpan.FromDays(1.5); // 1d and 15hrs
Console.WriteLine("ts1{TimeSpan.FromDays(1.5)}:  " + ts1);
TimeSpan ts2 = TimeSpan.FromHours(1.5); // 1h and 30min
Console.WriteLine("ts2{TimeSpan.FromHours(1.5)}: " + ts2);

GResText.PrintLine();
GResText.JumpLines();

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - DateTime and TimeSpan: Some of DateTime's features work with TimeSpans                                 
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GResText.WriteTitle("OPERATIONS WITH TIME SPAN STRUCT");

GResText.WriteSubTitle("Timer with TimeSpan");
Console.WriteLine("subtracting 2 DateTimes returns a TimeSpan");
DateTime start = DateTime.Now;
var aux = 0;
for (int i = 0; i < 10000000; i++) 
    aux = i;
DateTime end = DateTime.Now;
TimeSpan diff = end - start;
Console.WriteLine("Tot time taken: " + diff.TotalMilliseconds + "ms");

GResText.PrintLine();

GResText.WriteSubTitle("DateTime Methods and Properties Which Return a TimeSpan");
DateTime date = DateTime.Now;
Console.WriteLine("date:                                    " + DateTime.UtcNow);
Console.WriteLine("date.Subtract(TimeSpan.FromMinutes(20)): " + date.Subtract(TimeSpan.FromMinutes(20)));
Console.WriteLine("date.TimeOfDay:                          " + date.TimeOfDay);