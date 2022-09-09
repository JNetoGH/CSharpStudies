//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - ENUMS: An enumeration type (or enum type) is a value type defined by a set of named constants of the
//    underlying integral numeric type, an enum represents a group of constants (unchangeable/read-only variables),
//      * You just need the define the first constant, the rest will keep the order adding +1 to the next
//      * By default the first constant is 0.
//      * By default, the associated constant values of enum members are of type int; they start with zero and increase
//        by one following the definition text order. You can explicitly specify any other integral numeric type
//        as an underlying type of an enumeration type.
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

namespace Enums;

internal enum WeekDays {
    Monday = 14,
    Tuesday,
    Wednesday,
    Friday,
    Saturday,
    Sunday
}

internal enum OrderStatus : int {
    PendingPayment = 0,
    Processing,
    Shipped, 
    Delivered
}

internal class Order {
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public override string ToString() => $"ID: {Id}\nMoment: {Moment}\nStatus: {Status}";

}

internal static class Exec {
    public static void Main(string[] args) {
        
        // SHOWING THAT ENUM IS A VALUE TYPE
        Console.WriteLine();
        Console.WriteLine(typeof(WeekDays).BaseType.BaseType.Name);
        
        // WEEKEND
        Console.WriteLine();
        Console.WriteLine(WeekDays.Tuesday);        // OUTPUT: Tuesday
        Console.WriteLine((int)WeekDays.Wednesday); // OUTPUT: value
        
        // ORDER EXAMPLE
        Console.WriteLine();
        Order order1 = new Order
        {
            Id = 3080,
            Moment = DateTime.UtcNow,
            Status = OrderStatus.Processing
        };
        Console.WriteLine(order1);

        // PARSING STRING <=> ENUM
        Console.WriteLine();
        string txt = OrderStatus.PendingPayment.ToString();
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
        Console.WriteLine(txt);
        Console.WriteLine(os);
        
        // ignoreCase
        // OrderStatus os = Enum.Parse<OrderStatus>("DeliVEred"); when typed wrong, it throws an exception "value X was not found"
        Console.WriteLine(Enum.Parse<OrderStatus>("ShIPped", true)); 
        
        // TryParse
        // an option for avoiding all exceptions
        Console.WriteLine("Managed to parse? " + Enum.TryParse(typeof(OrderStatus), "neverSeen", true, out var resultOBJ));
    }
}


