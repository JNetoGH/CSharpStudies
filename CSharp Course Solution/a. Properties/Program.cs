//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ 
/*
PROPERTIES
Properties are kinda like a combination of a variable and a method, they are actually made of special methods, 
the get, set and init methods are called ACCESSORS.
The properties can be read-write/read-only/write-only/init-only.

TYPES OF PROPERTIES
Read-Write: Have both a get and a set accessor.
Read-Only:  Have a get accessor but no set accessor.
Write-Only: Have a set accessor, but no get accessor.
Init-Only:  Have a get accessor and an init accessor.

PROPERTIES FEATURES
Auto-Implemented Properties: They don’t need a backing field, the compiler implements a field for us.
They can also have initializers, while the regular properties can’t.
Value keyword: The value keyword is used to define the value being assigned by the set or init accessor.
Access Modifier: Properties get, set and init can have access modifiers like “private” and “protected”, therefore, 
a property can be public to get but private to set.
 */
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

namespace Properties;

public class Person
{
    //! BACKING FIELDS
    // A basic pattern for implementing properties is to use a private backing field for
    // setting and retrieving the property value.
    private string _firstName = "Default"; // Field also called as "backing field"
    
    //! PROPERTY
    // Access Modifiers "like private" can be used with the get, set and init accessors
    public string FirstName {
        get {
            // get: automatically capitalizes the name                                                   
            _firstName = _firstName.ToLower();
            char firstCharAsUpper = _firstName[0].ToString().ToUpper().ToCharArray()[0];
            _firstName = firstCharAsUpper + _firstName.Substring(1);
            return _firstName;
        }
        private set {
            // set: checks if its a null or empty string input
            if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Name");
            else _firstName = value;
        }
    }
    
    //! PROPERTY ACCESSORS WITH EXPRESSION BODY DEFINITIONS
    // The get and the set accessor can be implemented as expression-bodied members
    // OBS: E.B.Definitions don't use the return keyword for returning, for instance, "=> 12" returns 12.
    private int? _age;
    public int? Age {
        get => _age;
        set => _age = value >= 0 ? value : null;
    }

    //! GET-ONLY VS READ-ONLY VS READ-WRITE PROPERTY
    // Being read-write/read-only/write-only means basically, have both accessors or only one
    // Get-Only properties can be defined as expression bodied members, they don't need a backing field
    // when returning just a value, and not managing a field like properties with a set accessor. 
    public bool IsOverOr18 => Age >= 18;
    
    //?SAME THING
    // public bool IsAboveOr18 {
    //     get {
    //         return Age >= 18;
    //     }
    // };
   
    
    //! INIT ACCESSOR AND INIT-ONLY
    // This enforces immutability, allows a value assignment only once at object constructions
    // Init accessor cannot be used with static properties, and nor with set accessor.
    // Init-Only properties always have to have a get accessor as well
    private int _id;
    public int Id {
        get => _id;
        private init => _id = value > 100 ? value : new Random().Next(100, 999); 
    }
    
    //CONSTRUCTOR
    public Person(string firstName, int? age, int id) {
        FirstName = firstName;
        Age = age;
        Id = id;
    }
    public override string ToString() => $"name: {FirstName}\n" +
                                         $"age:  {(Age != null ? Age : "null")}\n" +
                                         $"18+y? {IsOverOr18}\n" +
                                         $"id:   {Id}";
}

internal class Exec {
    public static void Main(string[] args) {
        Person student1 = new Person("joao", 20, 151);
        Person student2 = new Person("Raul", null, 10);
        Console.WriteLine(student1);
        Console.WriteLine("================");
        Console.WriteLine(student2);
    }
}

