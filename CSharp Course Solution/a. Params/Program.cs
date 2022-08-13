//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Params: It works just like "..." in java, by using the params keyword, you can specify a method parameter
//    that takes a variable number of arguments.
//          * The parameter type must be a single-dimensional array.
//          * No additional parameters are permitted after the params keyword in a method declaration.
//          * Only one params keyword is permitted in a method declaration.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

void Method1(params int[] varArgs) {
    Console.Write("params: { ");
    foreach (var value in varArgs) 
        Console.Write(value + " ");
    Console.WriteLine("}");
}

Console.WriteLine();
GeneralRes.GResText.WriteTitle("params keyword");
Method1(12, 323, 44, 83); // as vararg
Method1(new int[]{12,14,84});  // as array