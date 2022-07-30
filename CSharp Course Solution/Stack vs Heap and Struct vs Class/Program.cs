
internal struct MyStruct
{
    public int value1;
    public char value2;
}


internal class MyClass
{
    public int field1;
    public char field2;
    private MyStruct _myStruct = new MyStruct();
    private MySecondClass test = new MySecondClass();
    void method() {
        Console.WriteLine("oi");
    }
}
internal class MySecondClass { private int AnyValue; }


internal class Exec 
{
    public static void Main(string[] args)
    {
        // Value Type, allocated on stack
        Int32 num = 10;
        Console.WriteLine(num);
        
        // Value Type, allocated on stack
        MyStruct myStruct = new MyStruct();
        Console.WriteLine(myStruct.value1);
        
        // Reference Type, allocated on Heap
        MyClass myClass = new MyClass();
        Console.WriteLine(myClass.field1);

        // Array instantiation, the ints will be allocated at the array obj address on the heap
        int[] array = { 1, 2, 3, 4 };
        Console.WriteLine(String.Join(", ", array));
        
        // Array instantiation, the structs will be allocated at the array obj address on the heap.
        // each struct address will contain their own values, there will be just one address the address of the array obj
        MyStruct[] arrStructs = { new MyStruct(){value1 = 55}, new MyStruct(){value1 = 56}, new MyStruct(){value1 = 57} };
        foreach (MyStruct strc in arrStructs) Console.WriteLine(strc.value1);
        
        // Each obj address of MyClass will contain a reference to their obj on the heap, there will be the address of the array obj,
        // an address for each MyClass obj and one address for each MySecondClass field in each MyClass object,
        // because those fields will actually contain a reference to their own MySecondClass obj on the heap.
        MyClass[] arrClasses = { new MyClass(){field1 = 33}, new MyClass(){field1 = 34}, new MyClass(){field1 = 35} };
        foreach (MyClass obj in arrClasses) Console.WriteLine(obj.field1);
        
        // Search for the names Int32, MyStruct, MyClass, MySecondClass and MySecondClass on the memory view in debug mode
        
        
        Console.WriteLine("Oi");

    }
}
