try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int result = n1 / n2;
    Console.WriteLine(result);
}
catch (System.DivideByZeroException e)
{
    Console.WriteLine($"Error: cannot divide by 0");
}
catch (System.FormatException)
{
    Console.WriteLine("Error: number only");
}
catch (System.Exception e) // catches all the exception (except the ones defined before), because it's the super class of all exceptions
{
    Console.WriteLine($"Error: {e.Message}");
}
finally // it's always executed, doesn't matter if an exception was caught or not
{
    Console.WriteLine("FINALLY EXECUTED");
}
