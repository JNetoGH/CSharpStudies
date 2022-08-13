//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Built-in Delegates: C# includes built-in delegates types Func, Action and Predicate, defined in the
//    System namespace, so that you don't need to define custom delegates manually in most cases.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//!   public delegate TResult Func<in T, out TResult>(T arg);
//    It takes from 0 to 16 input parameters.
//    The out parameter (last Generic) is the return type of the delegate.
//    If there is just one Generic, this generic will be the return type, and the delegate will not accept parameters.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

float Div(int x, int y) => x / (float)y;
Func<int, int, float> funcDelegate1 = new Func<int, int, float>(Div);
float resultDiv = funcDelegate1(5, 2);
Console.WriteLine("\nfuncDelegate1: " + resultDiv);

//----------------------------------------------------------------

int Sum(int x, int y, int z) => x + y + z;
Func<int, int, int, int> funcDelegate2 = Sum;
int resultSum = funcDelegate2(7, 5, 5);
Console.WriteLine("funcDelegate2 " + resultSum);

//----------------------------------------------------------------

Func<int> funcDelegate3 = () => new Random().Next(1, 100);
Console.WriteLine("funcDelegate3: " + funcDelegate3.Invoke());

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//!   public delegate void Action<in T>(T obj);
//    It Takes from 0 to 16 input parameters.
//    An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value.
//    In other words, an Action delegate can be used with a method that has a void return type.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

Console.Write("\nactionDel1: ");
static void ConsolePrint(int i) => Console.WriteLine(i);
Action<int> actionDel1 = ConsolePrint;
actionDel1(10);

//----------------------------------------------------------------

Console.Write("actionDel2: ");
Action<int, char> actionDel2 = delegate(int number , char letter) { Console.WriteLine(number + " " + letter); };
actionDel2(20, 'b');

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//!   public delegate bool Predicate<in T>(T obj); 
//    It Takes only 1 input parameter.
//    It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria.
//    A predicate delegate methods must take one input parameter and return a boolean.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

Console.WriteLine("\n----------------------------PREDICATES----------------------------");

//----------------------------------------------------------------

bool IsUpperCase(string str) => str.Equals(str.ToUpper());
Predicate<string> predicateDel = IsUpperCase;
bool result = predicateDel("hello world!!");
Console.WriteLine("\nIS UPPER CASE: " + result);

//----------------------------------------------------------------

// tests a str using the predicates passed as parameters
void MultipleTestsInString(Predicate<string>[] predicates, string str)
{
    Console.WriteLine("\nStarting tests");
    for (int i = 0; i < predicates.Length; i++)
    {
        bool hasPassed = predicates[i].Invoke(str);
        Console.WriteLine($"Test {i} ({predicates[i].Method}): {hasPassed}");
    }
}

bool IsFirstCharUpper(string str) => char.IsUpper(str[0]);
Predicate<string> predicate2 = IsFirstCharUpper;

bool areAllCharsLetters(string str)
{
    foreach (char letter in str)
        if (!char.IsLetter(letter))
            return false;
    return true;
}
Predicate<string> predicate3 = areAllCharsLetters;

MultipleTestsInString(new[] { predicate2, predicate3 }, "Joao2");

