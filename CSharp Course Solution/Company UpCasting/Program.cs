namespace Company;

class Exec
{
    private static Employee InitEmployee()
    {
        Employee createdEmployee;
        
        Console.Write("Outsourced(y/n): ");
        char isOutsourced = Console.ReadLine().ToUpper()[0];
        
        Console.Write("Name: ");
        var name = Console.ReadLine() ?? "Undefined";
       
        Console.Write("Hours: ");
        var hours = int.Parse(Console.ReadLine() ?? "0");
     
        Console.Write("Value per hour: ");
        var valuePerHour = double.Parse(Console.ReadLine() ?? "0.0");
      
        if (isOutsourced.Equals('Y'))
        {
            Console.Write("Additional charge: ");
            var additionalCharge = double.Parse(Console.ReadLine() ?? "0.0");
            createdEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
        }
        else createdEmployee = new Employee(name, hours, valuePerHour);
        
        return createdEmployee;
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Total Employees: ");
        int totEmployees = int.Parse(Console.ReadLine() ?? "0");
        List<Employee> employeesList = new List<Employee>();
        
        for (int i = 0; i < totEmployees; i++)
        {
            Employee employee = InitEmployee();
            employeesList.Add(employee);
            Console.WriteLine();
        }

        Console.WriteLine("\nPAYMENT");
        foreach (Employee employee in employeesList)
            Console.WriteLine(employee.Name + ": $" + employee.Payment().ToString("F2"));
    }
}




