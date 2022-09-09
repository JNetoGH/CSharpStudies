//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - SWITCH EXPRESSION
//    Are basically used to return a value to a variable or in a method body definition.
//    The switch expression provides for switch-like semantics in an expression context.
//    It provides a concise syntax when the switch arms produce a value.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

// VALUE PATTERN
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Insert a vlaue (1->3): ");
        var op = int.Parse(char.ToString(Console.ReadLine()[0]));

        // regular switch statement
        string result1;
        switch (op)
        {
            case 1:  result1 = "hahaha"; break;
            case 2:  result1 = "kkkkkk"; break;
            case 3:  result1 = "rsrsrs"; break;
            default: result1 = "No case availabe"; break;
        }
        // switch expression
        string result2 = op switch  
        {  
            1 => "hahaha",  
            2 => "kkkkkk",  
            3 => "rsrsrs",
            _ => "No case availabe"  
        };

        // regular switch return in method
        string Method1(int operation)
        {
            switch (operation)
            {
                case 1:  return "hahaha"; 
                case 2:  return "kkkkkk"; 
                case 3:  return "rsrsrs"; 
                default: return "No case availabe";
            }
        }
        // switch expression return in method
        string Method2(int operation)
        {
            return operation switch
            {
                1 => "hahaha",
                2 => "kkkkkk",
                3 => "rsrsrs",
                _ => "No case availabe"
            };
        }
        // just for demonstration with a body expression returning the result of the switch expression
        string Method2ShortWay(int operation) => operation switch
        {
            1 => "hahaha",
            2 => "kkkkkk",
            3 => "rsrsrs",
            _ => "No case availabe"
        };
        
        Console.WriteLine(result1);  
        Console.WriteLine(result2);
        Console.WriteLine(Method1(op));
        Console.WriteLine(Method2(op));

        //----------------------------------------------------------------
        Console.WriteLine("\n\n");
        //----------------------------------------------------------------
        
        // TYPE PATTERN
        object Check1(object val)
        {
            switch (val)
            {
                case int: return "integer";
                case string: return "string";
                case List<string>: return "list of strings";
                case Array: return "array";
                default: return "unknown";
            }
        }
        object Check2(object val)
        {
            return val switch 
            {
                int => "integer",
                string => "string",
                List<string> => "list of strings",
                Array => "array",
                _ => "unknown"
            };
        }
        
        // just for demonstration with a body expression returning the result of the switch expression
        object Check2ShortWay(object val) => val switch 
        {
            int => "integer",
            string => "string",
            List<string> => "list of strings",
            Array => "array",
            _ => "unknown"
        };

        int age = 23;
        string name = "Peter";
        List<string> colors = new List<string> {"blue", "khaki", "orange"};
        int[] nums = new int[] {1, 2, 3, 4, 5};

        Console.WriteLine(Check1(age));
        Console.WriteLine(Check1(name));
        Console.WriteLine(Check1(colors));
        Console.WriteLine(Check1(nums));
        Console.WriteLine();
        Console.WriteLine(Check2(age));
        Console.WriteLine(Check2(name));
        Console.WriteLine(Check2(colors));
        Console.WriteLine(Check2(nums));

        //----------------------------------------------------------------
        Console.WriteLine("\n\n");
        //----------------------------------------------------------------

        // RELATIONAL PATTERN
        List<int> numsList = new List<int> {-3, 2, 0, 1, 9, -2, 7};
        foreach (int num in numsList)
        {
            string res = num switch 
            {
                < 0 => "negative",
                0 => "zero",
                > 0 => "positive"
            };
            Console.WriteLine($"{num} is {res}");
        }
    }
}

class Person { public string Name { get; set; } }
