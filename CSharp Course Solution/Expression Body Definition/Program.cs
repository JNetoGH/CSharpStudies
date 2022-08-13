//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Expression Body Definition: Let you provide a member's implementation in a very concise, readable form. You can
//    use an expression body definition whenever the logic for any supported member, such as a method or property,
//    consists of a single expression.
//        * EX: member => expression;
//        * Can be used with, Methods, Properties/Read-Only Properties, Constructors, Finalizers and Indexers
//        * E.B.Definitions don't use the return keyword for returning, for instance, "=> 12" returns 12.
//        * The use of the "return" keyword causes error, it'll return the result by default without an explicit return
//          when the member which the expression implements has a return type, such aa a get of a property,
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class MyClass
{
    
    //! Method
    void VoidMethod() => Console.WriteLine("hi"); 
    int ReturnMethod() => 5 + 5;                             // implicit return 
    
    //! Property
    private int _propertieBackingField;
    public int Property
    {
        get => _propertieBackingField - (int) Math.PI;       // implicit return         
        set => _propertieBackingField = value + 5;
    }
    
    //! AutoProperty
    public bool AutoProperty => _propertieBackingField > 0;  // implicit return 
  
    //! Indexer
    // work just like in properties
    public class Sports
    {
        private string[] types = { "Baseball", "Basketball", "Football", "Hockey", "Soccer", "Tennis", "Volleyball" };
        public string this[int i]
        {
            get => types[i];                                 // implicit return 
            set => types[i] = value + " user_made :)";
        }
    }
    
    //! Constructor
    // finalizer work in the same way
    public MyClass(int value) => Property = value;
    
}

class Exec
{
    public static void Main(string[] args)
    {
        MyClass obj = new MyClass(8);
        obj.Property = 70;
        Console.WriteLine("Is property bigger than 0? " + obj.AutoProperty);
        MyClass.Sports array = new MyClass.Sports();
        array[0] = "Polo";
        Console.WriteLine(array[0]);
    }
}
