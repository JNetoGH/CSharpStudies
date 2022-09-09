//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Static Class
//    In C#, a static class is a class that cannot be instantiated.
//    The main purpose of using static classes in C# is to provide blueprints of its inherited classes.
//    A static class can contain static members only.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

static class StaticClass
{
    public static double Prop { get; set; }
   
    // void Method() => Console.WriteLine("hi"); error[CS0708] cannot declare instance member "non-static" in static class
    public static void Method() => Console.WriteLine("hi");
}

class Exec
{
    public static void Main(string[] args)
    {
        
    }
}