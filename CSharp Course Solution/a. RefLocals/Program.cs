//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Ref Locals: links a var to another var, anything that happens with one, also happen to the other
//          * A ref local variable needs to be always initialized
//          * only local variables can be ref locals
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class MyClass { internal int field; }
class Exec
{
    public static void Main(string[] args)
    {
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
        array[0]  = 32;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("array[0] = 32;");
        Console.ForegroundColor = ConsoleColor.White;
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
        

    }
}