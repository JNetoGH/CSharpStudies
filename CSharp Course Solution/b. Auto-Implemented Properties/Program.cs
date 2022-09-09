//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - AUTO-IMPLEMENTED PROPERTIES
//    Added in C# 9, a Property with a get and/or a (set or init) accessors that just assigns or retrieve a value
//    from a backing field, can be written as an auto-implemented properties, by doing so, the compiler will create
//    the field, without the need to write the field, unlike regular properties.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

using System.Text;
using Properties;

class Student: Person
{
    //! AUTO-IMPLEMENTED PROPERTY
    public string Password { get; private set; }
    
    //! AUTO-IMPLEMENTED PROPERTY WITH INITIALIZER 
    public List<string> Subjects { get; internal init; } = new List<string>() { "English", "Math", "Physics" };
    
    //! AUTO-IMPLEMENTED READ-ONLY
    // set-only is not allowed, nor init-only
    public int JustATestWontBeUsed { get; } = 13132;

    public Student(string firstName, int? age, int id, string password) : base(firstName, age, id)
    {
        Password = password;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(base.ToString());
        builder.AppendLine("Subjects: " + string.Join(", ", Subjects));
        return builder.ToString();
    }
}

class Exec
{
    public static void Main(string[] args)
    {
        var student = new Student("Rafael", 23, 213, "ad145df");
        student.Subjects.Add("Art");
        Console.WriteLine(student);
    }
}