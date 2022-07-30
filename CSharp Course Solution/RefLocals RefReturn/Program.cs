class MyClass { internal int field; }
class Exec
{
    public static void Main(string[] args)
    {
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        //  - Ref Locals: links a var to another var, anything that happens with one, also happen to the other
        //          * A ref local variable needs to be always initialized
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        
        GeneralRes.GResText.JumpLines();
        GeneralRes.GResText.WriteTitle("Ref Locals");
       
        //----------------------------------------------------------------
       
        int[] array = {0, 1, 2, 3, 4};
        Console.WriteLine("Array: { " + string.Join(", ", array) + " }");
        
        //----------------------------------------------------------------
        Console.ForegroundColor = ConsoleColor.Cyan;
      
        ref int varRef = ref array[0];
        varRef = 99;
        Console.WriteLine("ref int varRef = ref array[0];");
        Console.WriteLine("varRef = " + varRef +";");
        
        int varRegular = array[1];
        varRegular = 24;
        Console.WriteLine("int varRegular = array[1];");       
        Console.WriteLine("varRegular = " + varRegular +";");
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Array: { " + string.Join(", ", array) + " }");
        GeneralRes.GResText.PrintLine();
      
        //----------------------------------------------------------------
      
        GeneralRes.GResText.WriteSubTitle("Changing the value on array also changes the ref var");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("array[0] = 32;");
        Console.ForegroundColor = ConsoleColor.White;
        array[0]  = 32;
        Console.WriteLine("varRef: " + varRef);
        GeneralRes.GResText.PrintLine();
        
        //----------------------------------------------------------------
       
        GeneralRes.GResText.WriteSubTitle("An instance of a class is always passed as reference");
        var obj1 = new MyClass(){field = 7};
        Console.WriteLine("obj1.field: "  + obj1.field);
        var obj2 = obj1;
        obj2.field = 10;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("var obj2 = obj1;\nobj2.field = 10;");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("obj1.field: "  + obj1.field);
        GeneralRes.GResText.PrintLine();
        
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        //  - Ref Return: it's possible to return a var as as ref variable in a method
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
       
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
    // Ref Return Method
    internal static ref string GetColorAsRef(string[] array, int index) { return ref array[index]; }
}