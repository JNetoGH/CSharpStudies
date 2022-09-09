class MyClass
{
    public static void Main(string[] args)
    {
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        //  - TYPE PATTERN
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
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

        Console.WriteLine($"\nCheck1:\n{Check1(age)}\n{Check1(name)}\n{Check1(colors)}\n{Check1(nums)}");
        Console.WriteLine($"\nCheck2:\n{Check2(age)}\n{Check2(name)}\n{Check2(colors)}\n{Check2(nums)}\n\n");

        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        //  - RELATIONAL PATTERN
        //░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
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