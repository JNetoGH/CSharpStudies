using System.Globalization;

namespace WorkerRelated;

public struct Department
{
    public string Name { get; init; }
}

public class Worker
{
    // Main Constructor
    public Worker(string name, Department department, WorkerLevel level, decimal baseSalary)
    {
         Name = name;
        _department = department;
        _level = level;
        _baseSalary = baseSalary;
        InitContracts();
    }

    // CLI Constructor
    public Worker()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("CREATING NEW WORKER");
        Console.ForegroundColor = ConsoleColor.White;
        
        Console.Write("Name: ");
        Name = Console.ReadLine() ?? "None";
        
        Console.Write("Department: ");
        _department = new Department{Name = Console.ReadLine() ?? "None"};
        
        Console.Write("Level (Junior/Pleno/Senior): ");
        string? rawLevel = Console.ReadLine();
        if (rawLevel is not null)
            Enum.TryParse(rawLevel.ToUpper(), out _level);

        Console.Write("Base Salary: $");
        _baseSalary = decimal.Parse(Console.ReadLine() ?? "0");
        
        InitContracts();
    }

    private void InitContracts()
    {
        Console.Write("How many extra contracts does this worker have? ");
        int tot = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < tot; i++)
        {
            Console.WriteLine($"\nExtra Contract {i+1}:");
           
            Console.Write("Date (MM/YYYY): ");
            DateTime date;
            string? rawDate = Console.ReadLine();
            if (rawDate is not null)
                date = DateTime.ParseExact(rawDate, "MM/yyyy", new CultureInfo("pt-BR"));
            else 
                date = new DateTime(0,0,0);
                
            Console.Write("Value per Hour: ");
            decimal valuePerHour = decimal.Parse(Console.ReadLine() ?? "0");
            
            Console.Write("Total Hours: ");
            int hours = int.Parse(Console.ReadLine() ?? "0");
            
            AddContract(new ExtraContract(date, valuePerHour, hours));
        }
    }

    public string Name;
    private Department _department;
    private WorkerLevel _level;
    private decimal _baseSalary;
    
    // initialized at the constructor
    private List<ExtraContract> _extraContractsList = new List<ExtraContract>();
    public void AddContract(ExtraContract extraContract) => _extraContractsList.Add(extraContract);
    public void RemoveContract(ExtraContract extraContract) => _extraContractsList.Remove(extraContract);

    // the total income is the base salary + extra contracts at thatMonth and Year
    public decimal GetTotalIncomeAtCertainMonth(DateTime requiredMoth)
    {
        decimal total = this._baseSalary;
        if (_extraContractsList.Count > 0)
            foreach (var contract in _extraContractsList)
                if(contract.Date.Month == requiredMoth.Month && contract.Date.Year == requiredMoth.Year)
                    total += contract.TotalMoney;
        return total;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Department: {_department.Name}\n" +
               $"Level: {_level}\n" +
               $"Base Salary: {_baseSalary}";
    }
    
    
}
