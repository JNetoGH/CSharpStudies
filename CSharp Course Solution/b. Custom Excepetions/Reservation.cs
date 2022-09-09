using System.Text;

class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int Duration { 
        get {
            TimeSpan diff = (CheckOut - CheckIn);
            return diff.Days;
        }
    }
    
    public Reservation() {
        Console.Write("Room Number: ");
        RoomNumber = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (mm/dd/yy): ");
        CheckIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (mm/dd/yy): ");
        CheckOut = DateTime.Parse(Console.ReadLine());
        if (CheckOut <= CheckIn)    throw new PayAttentionMyDudeException("Invalid Dates: Check-out <= Check-in");
        if (CheckIn < DateTime.Now) throw new ApplicationException("Invalid Dates: Check-in < today");
    }

    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("RESERVATION");
        builder.AppendLine($"Room:      {RoomNumber}");
        builder.AppendLine($"Check-in:  {CheckIn.ToString("MM/dd/yyyy (hh:mm)")}");
        builder.AppendLine($"Check-out: {CheckOut.ToString("MM/dd/yyyy (hh:mm)")}");
        builder.AppendLine($"Nights:    {Duration}");
        return builder.ToString();
    }
}
