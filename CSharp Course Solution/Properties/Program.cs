//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 
//  - Properties: they are actually special methods called ACCESSORS. They can be read-write/read-only/write-only
//          * Read-Write: Have both a get and a set accessor
//          * Read-Only:  Have a get accessor but no set accessor
//          * Write-Only: Have a set accessor, but no get accessor
//          * value: The value keyword is used to define the value being assigned by the set or init accessor.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

namespace Properties;
internal class Student {
    
    // BACKING FIELDS: A basic pattern for implementing properties is to use a private backing field for
    // setting and retrieving the property value. 
    private string _firstName = "Default"; // Field also called as "backing field" 
    public string FirstName { // Property            
        get { // get: automatically capitalizes the name                                                    
            _firstName = _firstName.ToLower();
            char firstCharAsUpper = _firstName[0].ToString().ToUpper().ToCharArray()[0];
            _firstName = firstCharAsUpper + _firstName.Substring(1);
            return _firstName;
        }
        set { // set: checks if its a null or empty string input 
            if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Name");
            else _firstName = value;
        }
    }

    // EXPRESSION BODY DEFINITIONS: the get and the set accessor can be implemented as expression-bodied members
    // An Expression Body Definition consist of the => followed by the expression "an assign, return, method call..." 
    // OBS: E.B.D don't use the return keyword for returning, for instance, "=> 12" returns 12.
    private int? _age; 
    public int? Age { // Access Modifiers "like private" can be used with the get, set and init accessors
        get => _age; 
        private set => _age = value >= 0 ? value : null; 
    }

    // PROPERTY AS EXPRESSION-BODIED MEMBER: read-only properties can implement the get accessor as an expression
    public bool IsAboveOr18 => Age >= 18;
   
    // AUTO-IMPLEMENTED PROPERTIES: a Property with a get and a (set or init) accessors that just assign a value to or
    // retrieve a value from a backing field, can be written as auto-implemented properties, by doing so, the compiler
    // will create the field, without the need to write the field
    public int Password { get; private set; }
    
    // INIT ACCESSOR: This enforces immutability, allows a value assignment only once at object constructions
    public int Id { get; init; }
    
    public Student(string firstName, int? age, int id) { FirstName = firstName; Age = age; Id = id; }
    public override string ToString() => 
        $"name: {FirstName} \nage: {(Age != null ? Age : "null")} \n" +
        $"is above or 18? {IsAboveOr18} \nId: {Id}";
}
internal class Exec {
    public static void Main(string[] args) {
        Console.WriteLine();
        Student student1 = new Student("joao", 20, 1010);
        Student student2 = new Student("Raul", null, 1011);
        Console.WriteLine(student1);
        Console.WriteLine("================");
        Console.WriteLine(student2);
    }
}

