//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Constructor Chaining:
//    This is an approach where a constructor calls another constructor in the same or base class.
//    The chained constructor is called first and then the caller constructor is called.
//    In order to chaining a constructor, it's used the keyword this/super with the parameters
//    the other constructor require after a ":", e.g. : this(10,'B') and  : super(7.6)
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

public class SampleClass
{
    private const int DEAFAULT_AGE = 18;

    public SampleClass(): this(DEAFAULT_AGE) => Console.WriteLine("age not inserted, using default age of 18 years");
   
    public SampleClass(int age)   
    {
        Console.WriteLine("age = " + age);
        if (age >= 18) Console.WriteLine("age >= 18, you can enter");
        else Console.WriteLine("age > 18, you cannot enter");
    }  
}  

//!Chaining Base Class Constructor
// If the base class has one implicit constructor it's mandatory to implement it in its subclass.
public class BaseClass
{
    protected BaseClass(int x, int y) => Console.WriteLine($"x: {x} \ny: {y}");
}
public class SubClass : BaseClass
{
    public SubClass(int x, int y) : base(x, y)
    {
        if (x < 0) x = 0;
        if (y < 0) y = 0;
    }
}

class Exec
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        new SampleClass();
        Console.WriteLine();
        new SampleClass(12);
        Console.WriteLine();
        new SubClass(-7, -3);
    }
}