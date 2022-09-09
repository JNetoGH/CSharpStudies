namespace Custom_Excepetions;

class Exec {
    public static void Main(string[] args) {
        Reservation? reservation = null;
        bool datesCollected = false;
        while (!datesCollected) {
            try {
                Console.WriteLine("\nMAKING RESERVATION\n");
                reservation = new Reservation();
                datesCollected = true;
            }
            catch (ApplicationException e) {
                Console.WriteLine(e.Message + "\n");
            }
        }
        Console.WriteLine("\nRESERVATION DETAILS\n" + reservation);
    }
}
