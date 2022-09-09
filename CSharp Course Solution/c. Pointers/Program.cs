
class MyClass
{
    static unsafe void Main(string[] args) {
       
        int val = 50;
        int* x = &val;
        
        Console.WriteLine("Data: {0} ", val);
        Console.WriteLine("Address: {0}", (int)x);
        
        unsafe  // unsafe block is also an alternative to unsafe method modifier
        {
            
        }
    }
}
