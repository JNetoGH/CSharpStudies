class Member : IDisposable 
{  
    public Member() =>Console.WriteLine("Default Constructor was called.");
    public Member(string name) => Console.WriteLine("Parameterized Constructor was called.");
   
    ~Member()
    {
        ReleaseUnmanagedResources();
        Console.WriteLine("Destructor called");
    }

    private void ReleaseUnmanagedResources()
    {
        // TODO release unmanaged resources here
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }
}

class Exec
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nDefault constructor: ");
        Member member1 = new Member();
        member1.Dispose();
        
        Console.WriteLine("\nParameterized constructor: ");
        Member member2 = new Member("joao");
        member2.Dispose();
        
        GC.Collect(); }
}