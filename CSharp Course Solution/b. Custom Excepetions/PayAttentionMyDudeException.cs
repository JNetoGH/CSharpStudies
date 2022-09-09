class PayAttentionMyDudeException : ApplicationException
{
    public PayAttentionMyDudeException(string msg) : base(msg)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("PAY ATTENTION");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
