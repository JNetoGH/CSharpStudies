// classes need to be to be cleaned by the garbage collector
// structs when allocated on stack don't

internal struct MyStruct { public int value; }
internal class MyClass { public int value; }

internal class Exec {
    public static void Main(string[] args) {
        GeneralRes.GResText.WriteSubTitle("\nStruct vs Class Speed");
      
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

/*
internal struct MyStruct { public int value; }
internal class MyClass { public int value; }

internal class TestClassWithClassField { public MyClass classField; }
internal class TestClassWithStructField { public MyStruct structField; }

internal class Exec
{
   public static void Main(string[] args)
   {
       GeneralRes.GResText.WriteSubTitle("\nStruct vs Class Speed as Fields");
      
       DateTime startClassTimer = DateTime.Now;
       for (int i = 0; i < 100000; i++)
       {
           TestClassWithClassField obj = new TestClassWithClassField() {classField = new MyClass()};
          
       }
       DateTime endClassTimer = DateTime.Now;
       Console.WriteLine("class:  " + (endClassTimer - startClassTimer).TotalMilliseconds + "ms");
      
       DateTime startStructTimer = DateTime.Now;
       for (int i = 0; i < 100000; i++)
       {
           TestClassWithStructField obj = new TestClassWithStructField() {structField = new MyStruct()};
       }
       DateTime endStructTimer = DateTime.Now;
       Console.WriteLine("struct: " + (endStructTimer - startStructTimer).TotalMilliseconds + "ms");
   }
}


internal struct MyStruct { public int value; }
internal class MyClass { public int value; }

internal class Exec
{
   public static void Main(string[] args)
   {
       GeneralRes.GResText.WriteSubTitle("\nStruct vs Class Speed as Arrays");
      
       MyStruct[] myStructArray = new MyStruct[10000];
       MyClass[] myClassArray = new MyClass[10000];
      
       DateTime startClassTimer = DateTime.Now;
       for (int i = 0; i < 10000; i++)
       {
           myClassArray[i] = new MyClass();
       }
       DateTime endClassTimer = DateTime.Now;
       Console.WriteLine("class:  " + (endClassTimer - startClassTimer).TotalMilliseconds + "ms");
      
       DateTime startStructTimer = DateTime.Now;
       for (int i = 0; i < 10000; i++)
       {
           myStructArray[i] = new MyStruct();
       }
       DateTime endStructTimer = DateTime.Now;
       Console.WriteLine("struct: " + (endStructTimer - startStructTimer).TotalMilliseconds + "ms");
   }
}
 */