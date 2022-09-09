using System.Globalization;
using WorkerRelated;

namespace ApplicationExecution;

public class Exec
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        
        Worker w1 = new Worker();
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nWORKER INFO\n" + w1);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nWish to calculated an income of a certain month [y/n]: ");
        char input  = Console.ReadLine().ToUpper()[0];
        if (input == 'Y')
        {
            Console.Write("Date (MM/YYYY): "); 
            var date = DateTime.ParseExact(Console.ReadLine() ?? "00/0000", "MM/yyyy", new CultureInfo("pt-BR"));
            Console.WriteLine($"Total Income at {date.Month}/{date.Year}: $" + w1.GetTotalIncomeAtCertainMonth(date));
        }
        
    }
}