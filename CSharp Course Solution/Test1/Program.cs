namespace Tests;

internal struct MyStruct
{
    public int value;
}

internal class MyClass
{
    public int value;
    public MySecondClass obj;
}

internal class MySecondClass
{
    public int value;
}

internal class Exec 
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new MyStruct().GetType().BaseType);
        Console.WriteLine(new MyStruct().GetType().BaseType.BaseType);
        Console.WriteLine(new MyClass().GetType().BaseType);
        new MyClass();
        new MyStruct();
        Console.WriteLine("foi");
        
    }
}