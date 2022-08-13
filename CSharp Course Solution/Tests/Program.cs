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
        new MyClass();
        new MyStruct();
        Console.WriteLine("foi");
        
    }
}