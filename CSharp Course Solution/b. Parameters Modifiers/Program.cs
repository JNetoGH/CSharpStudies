namespace Parameters;

class MyClass { internal int Integerfield = 2; }
class Exec
{
    // OBS1: in, ref, and out keywords are not considered part of the method signature for the purpose of overload.
    // Therefore, methods cannot be overloaded if the only difference is that one method takes a ref or in argument
    // and the other takes an out argument.
    // OBS2: Properties are not variables and therefore cannot be passed as OUT or RED parameters
    // OBS: Constants are also not allowed
    // This constant and this property are used for error demonstration for the reasons explained above
    private static int Property { get; set; }
    private const int CONSTANT = 3;
    
    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    //  - Ref Parameter Modifier: The ref keyword indicates that a value is passed by reference not as value as usual
    //    the value type variable behaves as a reference type (object/instance) variable when passed as an argument
    //          * the Ref Parameter must be initialized before it is passed as arg
    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    private static void MethodAsRef(ref int value) => value = 2;
    private static void MethodAsValue(int value) => value = 5;
    // The methods with ref parameters will work just like this method with an obj as parameter
    private static void MethodAsClassInstance(MyClass obj) => obj.Integerfield = 99;

    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    //  - Out Parameter Modifier: Works just like ref parameters, makes the arg be passed as reference instead of
    //    as value, but the key point is, the variable doesn't need to be previously initialized.
    //          * the called method is required to assign a value before the method returns
    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    private static void OutParamExample(out int number) => number = 44;

    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    //  - In Parameter Modifier: Works just like ref parameters, makes the arg be passed as reference instead of
    //    as value, but ensures the argument is NOT modified, returning an error if done so.
    //          * the In Parameter must be initialized before it is passed as arg
    //          * Omitting the In at argument passage, overcome several restrictions.
    //          * In is the only modifier you can omit at argument passage in method calls 
    //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
    private static void InParamExample(in int example) => /*example =  2; "error CS8331"*/ Console.WriteLine(example);
  
    public static void Main(string[] args)
    {
        // REF PARAMETER MODIFIER
        Console.WriteLine();
        GeneralRes.GResText.WriteTitle("ref modifier");
        
        int variable1 = 10;
        Console.WriteLine("variable1(ref) = " + variable1);
        MethodAsRef(ref variable1);
        Console.WriteLine("variable1(ref) = " + variable1);

        int variable2 = 30;
        Console.WriteLine("variable2(value) = " + variable2);
        MethodAsValue(variable2);
        Console.WriteLine("variable2(value) = " + variable2);

        MyClass obj = new MyClass(){Integerfield = 10};
        Console.WriteLine("class int field = " + obj.Integerfield);
        MethodAsClassInstance(obj);
        Console.WriteLine("class int field = " + obj.Integerfield);
        
        // MethodAsRef(ref Prop);          // results in error CS0103
        // MethodAsRef(ref Exec.CONSTANT); // results in error CS 1510 "A ref or out value must be an assignable value"
        
        //----------------------------------------------------------------------------------
        
        // OUT PARAMETER MODIFIER
        Console.WriteLine();
        GeneralRes.GResText.WriteTitle("out modifier");
        
        int initializeInMethod;                                             // non-initialized variable
        OutParamExample(out initializeInMethod); 
        Console.WriteLine("out initializeInMethod = " + initializeInMethod);// value is now 44
        
        // Starting with C# 7.0, you can declare the out variable in the argument list of the method call,
        // rather than in a separate variable declaration, it will be available for using after the call
        OutParamExample(out int straightInMethod1);                         // Int32 non-initialized variable
        Console.WriteLine("out int straightInMethod1 = " + straightInMethod1); 
        OutParamExample(out var straightInMethod2)  ;                    // implicitly typed non-initialized variable
        Console.WriteLine("out var straightInMethod2 = " + straightInMethod2);
        
        // OutParamExample(out Prop);          // results in error CS0103
        // OutParamExample(out Exec.CONSTANT); // results in error CS1510 "A ref or out value must be an assignable value"
        
        //----------------------------------------------------------------------------------
        
        // IN PARAMETER MODIFIER
        Console.WriteLine();
        GeneralRes.GResText.WriteTitle("in modifier");
        
        int value = 10;
        InParamExample(in value);
        
        // InParamExample(in Property);       // results in error CS0103
        // InParamExample(in Exec.CONSTANT);  // results in error CS8156
        
        // omitting IN at the call site informs the compiler that you will allow it to create a temporary var to pass by
        // READ-ONLY reference to the method. The compiler creates a temporary variable to overcome several restrictions
        //      * A temporary variable allows compile-time constants as in parameters.
        //      * A temporary variable allows properties, or other expressions for in parameters.
        //      * A temporary variable allows arguments where there is an implicit conversion from 
        //        the argument type to the parameter type, like int to short.
        
        // In all the preceding instances, the compiler creates a temporary variable that stores the value of
        // the constant, property, or other expression, or constant.
        InParamExample(Property);      // Compiler: OK, temporary variable created.
        InParamExample(Exec.CONSTANT); // Compiler: OK, temporary variable created.
    }
}