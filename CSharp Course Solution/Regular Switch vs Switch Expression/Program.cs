//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - SWITCH EXPRESSION
//    Are basically used to return a value to a variable or in a method body definition.
//    The switch expression provides for switch-like semantics in an expression context.
//    It provides a concise syntax when the switch arms produce a value.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

Console.Write("Insert a value (1->3): ");
var op = int.Parse(char.ToString(Console.ReadLine()[0]));

// regular switch statement
string result1;
switch (op) {
    case 1:  result1 = "hahaha"; break;
    case 2:  result1 = "kkkkkk"; break;
    case 3:  result1 = "rsrsrs"; break;
    default: result1 = "No case available"; break;
}

// switch expression
string result2 = op switch {
    1 => "hahaha",
    2 => "kkkkkk",
    3 => "rsrsrs",
    _ => "No case available"
};

// regular switch return in method
string Method1(int operation) {
    switch (operation) {
        case 1: return "hahaha";
        case 2: return "kkkkkk";
        case 3: return "rsrsrs";
        default: return "No case available";
    }
}

// switch expression return in method
string Method2(int operation) {
    return operation switch {
        1 => "hahaha",
        2 => "kkkkkk",
        3 => "rsrsrs",
        _ => "No case available"
    };
}

// just for demonstration with a body expression returning the result of the switch expression
string Method2ShortWay(int operation) => operation switch {
    1 => "hahaha",
    2 => "kkkkkk",
    3 => "rsrsrs",
    _ => "No case available"
};

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(Method1(op));
Console.WriteLine(Method2(op));

