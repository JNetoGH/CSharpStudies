internal struct MyStruct { public int value; }
internal class MyClass { public int value; }

internal class Exec {
    public static void Main(string[] args) {
  
      
        DateTime startClassTimer = DateTime.Now;
        for (int i = 0; i < 100000; i++) {
            MyClass obj = new MyClass();
            obj.value = i;
        }
        DateTime endClassTimer = DateTime.Now;
        Console.WriteLine("class:  " + (endClassTimer - startClassTimer).TotalMilliseconds + "ms");
      
        DateTime startStructTimer = DateTime.Now;
        for (int i = 0; i < 100000; i++) {
            MyStruct obj = new MyStruct();
            obj.value = i;
        }
        DateTime endStructTimer = DateTime.Now;
        Console.WriteLine("struct: " + (endStructTimer - startStructTimer).TotalMilliseconds + "ms");

    }
}