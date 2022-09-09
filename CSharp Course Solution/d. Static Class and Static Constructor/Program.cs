//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Static Constructor
//    It's only called after the first insertion of the class in memory
//    It's used to initialize any static data, or to perform a particular action that needs to be performed only once.
//    It's called automatically before the first instance (ONLY) is created or any static members are referenced.
//    Works pretty similar to static block in java.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class SecondClass
{   
    
    static SecondClass() => Console.WriteLine("SecondClass static constructor");
    public SecondClass() => Console.WriteLine("SecondClass non-static constructor");
}

class ThirdClass
{
    public static int Prop { get; set; }
    static ThirdClass() => Console.WriteLine("ThirdClass static constructor");
}


class Exec
{
    static Exec() => Console.WriteLine("Exec static constructor");
    Exec() => Console.WriteLine("Exec non-static constructor");
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Exec's Main first instruction");
        
        new Exec();
        new Exec();

        Console.WriteLine();
        
        new SecondClass();
        new SecondClass();
        
        Console.WriteLine();

        Console.WriteLine(ThirdClass.Prop);
        Console.WriteLine(ThirdClass.Prop);
        
    }
}