namespace GeneralRes
{
    public static class GResText
    {
        public static void PrintLine() => Console.WriteLine("------------------------------------------------------------");
    
        public static void JumpLines()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    
        public static void WriteSubTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void WriteTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title.ToUpper());
            PrintLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        public static void Main(string[] args) { }
    }
    
}
