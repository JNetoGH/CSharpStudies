//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Ref Return: it's possible to return a var as as ref variable in a method
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class Exec
{
    
    // Ref Return Method
    internal static ref string GetColorAsRef(string[] array, int index)
    {
        return ref array[index];
    }
    
    public static void Main(string[] args)
    {
        GeneralRes.GResText.JumpLines();
        GeneralRes.GResText.WriteTitle("Ref Return");
        string[] colors = { "green", "blue", "red" };
        Console.WriteLine("Colors: { " + string.Join(", ", colors) + " }");
        ref string holder = ref GetColorAsRef(colors, 2);
        holder = "yellow";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("ref string holder = ref GetColorAsRef(colors, 2); \nholder = \"yellow\";");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Colors: { " + string.Join(", ", colors) + " }");
    }

}