//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - OBJECT INITIALIZER
//  Introduced in C# 6.0, In object initializer, you can initialize the value to the fields or properties of a class at
//  the time of creating an object without calling a constructor. In this syntax, you can create an object and then
//  this syntax initializes the freshly created object with its properties
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

class Car
{
    public int HeightInCentimeters { get; set; }
    public int TotSeats { get; set; }

    public override string ToString() => $"Height: {HeightInCentimeters}cm \nTotal of Seats: {TotSeats}";

    public Car() { }
    public Car(int heightInCentimeters, int totSeats) {
        HeightInCentimeters = heightInCentimeters;
        TotSeats = totSeats;
    }
}

class Exec {
    public static void Main(string[] args) {
        
        Car c1 = new Car(140, 2);
        Car c2 = new Car() {
            HeightInCentimeters = 148,
            TotSeats = 4,
        };
        Car c3 = new Car(125, 3) {
            TotSeats = 3
        };
        
        Console.WriteLine(c1);
        Console.WriteLine("==============");
        Console.WriteLine(c2);
        Console.WriteLine("==============");
        Console.WriteLine(c3);
    }
}