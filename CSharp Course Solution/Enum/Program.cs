
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - ENUMS:
//      * you just need the define the first constant, the rest will keep the order adding +1 to the next
//      * by default the first one is equals 0.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

enum WeekDays
{
    Monday = 14,
    Tuesday,
    Wednesday,
    Friday,
    Saturday,
    Sunday
}


class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(WeekDays.Tuesday);        // OUTPUT: Tuesday
        Console.WriteLine((int)WeekDays.Wednesday); // OUTPUT: value
    }
}