//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - DELEGATES: A delegate is a reference type that can be used to encapsulate a named or an anonymous method.
//    They are used to pass methods as arguments to other methods.
//    When you instantiate a delegate, you can associate its instance with any method with a compatible signature
//    and return type and you can invoke (or call) the method through the delegate instance.
//          * The instantiated delegate is an object of the Delegate class
//          * Event handlers are nothing more than methods that are invoked through delegates. 
//          * A delegate can carry multiple methods
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class MyClass
{
    // Delegate
    private delegate void MathOperationDelegate(float numA, float numB);
    
    // Method that implements our delegate
    private static void PrintMathOperation(MathOperationDelegate delegateObj, float x, float y)
    {
        //!delegateObj.GetInvocationList()
        // Returns all the methods passed in a Delegate[] array.

        //!delegateObj.Method
        // This property represents the method inside the delegate, can be used to get stuff like name, return type...
        // It's always about the last delegate method, iteration over GetInvocationList() required to access the others. 
        
        Console.WriteLine("\nTotal methods in delegate = " + delegateObj.GetInvocationList().Length + 
                          "\nMethod.name = " + delegateObj.Method.Name);

        // Running the list of methods in case the delegate has more than one Method
        if (delegateObj.GetInvocationList().Length > 1)
        {
            Console.Write("All methods names: ");
            foreach (var currentMethod in delegateObj.GetInvocationList())
                Console.Write(currentMethod.Method.Name + ", ");
            Console.WriteLine();
        }

        //!delegateName.Invoke(parameters)
        // calls the delegate methods, delegateName(parameters) does the same
       
        Console.WriteLine("Executing Delegate:");
        delegateObj(x, y);
    }
    
    public static void Main(string[] args)
    {
        //! WAYS TO DECLARE AND USE DELEGATES
        
        void Sum(float x, float y) => Console.WriteLine($"{x} + {y} = {x+y}");
        MathOperationDelegate delegateObj1 = new MathOperationDelegate(Sum);
        PrintMathOperation(delegateObj1, 8, 5);
        
        void Sum2(float x, float y) => Console.WriteLine($"{x} + {y} = {x+y}");
        MathOperationDelegate delegateObj2 = Sum2;
        PrintMathOperation(delegateObj2, 2, 2);
        
        void Sum3(float x, float y) => Console.WriteLine($"{x} + {y} = {x+y}");
        PrintMathOperation(Sum3, 7 ,8);

        MathOperationDelegate delegateObjLambda = (float x, float y) => Console.WriteLine($"{x} + {y} = {x+y}");
        PrintMathOperation(delegateObjLambda, 4, 6);
        
        PrintMathOperation((float x, float y) => Console.WriteLine($"{x} + {y} = {x+y}"), 9 , 20);

        //----------------------------------------------------------------
        Console.WriteLine("\n");
        Console.WriteLine("\n");
        
        //!DELEGATES WITH MULTIPLE METHODS
        // delegates can add and subtract functions just like they were values
        
        void Sub(float x, float y) => Console.WriteLine($"{x} - {y} = {x-y}");
        void Mult (float x, float y) => Console.WriteLine($"{x} * {y} = {x*y}");
        
        // with no variables
        MathOperationDelegate delegateObjMultipleMethods = Sub;
        delegateObjMultipleMethods += Mult;
        PrintMathOperation(delegateObjMultipleMethods, 7 , 3);
        delegateObjMultipleMethods -= Sub;
        PrintMathOperation(delegateObjMultipleMethods, 7 , 3);
        
        // with variables
        MathOperationDelegate d1 = Sub;
        MathOperationDelegate d2 = Mult;
        MathOperationDelegate allDelegates = d1 + d2;
        PrintMathOperation(allDelegates, 4, 1);
        allDelegates -= d2;
        PrintMathOperation(allDelegates, 4, 1);
        
        //----------------------------------------------------------------
        Console.WriteLine("\n");
        
        //!DELEGATES WITH MULTIPLE METHODS (LAMBDA VERSION)

        MathOperationDelegate delegateObjMultipleMethods2 = (float x, float y) => Console.WriteLine($"{x} - {y} = {x-y}");
        delegateObjMultipleMethods2 += (float x, float y) => Console.WriteLine($"{x} * {y} = {x*y}");
        PrintMathOperation(delegateObjMultipleMethods2, 8 , 2);
    }
}
