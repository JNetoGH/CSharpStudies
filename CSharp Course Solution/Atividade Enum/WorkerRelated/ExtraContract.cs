namespace WorkerRelated;

public class ExtraContract
{
    public DateTime Date { get; init; }
    public decimal ValuePerHour { get; init; }
    public int Hours { get; init; }
   
    // its a get-only property
    public decimal TotalMoney => ValuePerHour * Hours;
    
    public ExtraContract(DateTime date, decimal valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }
}