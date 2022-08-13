GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("Static Property/Methods");
Console.WriteLine("Array.MaxLength: " + Array.MaxLength);

// ----------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("{99,-65,7,8,10,25,7,-55}");
int[] array2 = {99,-65,7,8,10,25,7,-55};
GeneralRes.GResText.WriteSubTitle("int[] array2 = Array.Reverse(T[] array)");
Array.Reverse(array2);
Console.WriteLine("array: " + string.Join(", ", array2));
GeneralRes.GResText.WriteSubTitle("Array.Sort(Array array)");
Array.Sort(array2);
Console.WriteLine("array: " + string.Join(", ", array2));
GeneralRes.GResText.WriteSubTitle("Array.Clear(Array array)");
Array.Clear(array2);
Console.WriteLine("array: " + string.Join(", ", array2));

// ----------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Empty<T>()");
int[] array3 = Array.Empty<int>();
Console.WriteLine("int[] array3 = Array.Empty<int>();");
Console.WriteLine("array: " + string.Join(", ", array3));


// ----------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Resize(ref T[] array, T newSize)");
int[] array4 = new int[7];
Array.Resize(ref array4, 3);
Console.WriteLine("int[] array4 = new int[7];");
Console.WriteLine("Array.Resize(ref array4, 3);");
Console.WriteLine("array4: " + string.Join(", ", array4));

// ----------------------------------------------------------------------

Array arrayTest = Array.CreateInstance(typeof(int), 10);



// ----------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Fill(T[] array, T value)");
int[] arrayForFilling = new int[7];
Array.Fill(arrayForFilling, 9);
Console.WriteLine("int[] array4 = new int[7];");
Console.WriteLine("Array.Fill(arrayForFilling, 9);");
Console.WriteLine("arrayForFilling: " + string.Join(", ", arrayForFilling));
GeneralRes.GResText.WriteSubTitle("Array.Fill(T[] array, T value, int startIndex, int count \"tot of indexes\")");
Array.Fill(arrayForFilling, 7, 3, 2);
Console.WriteLine("Array.Fill(arrayForFilling, 7, 3, 2);");
Console.WriteLine("arrayForFilling: " + string.Join(", ", arrayForFilling));

// ----------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Copy(Array sourceArray, Array destinationArray, int lenght \"tot elements to copy\")");
int[] arrayX = {99,-65,7,8,10,25,7,-55};
int[] arrayY = new int[arrayX.Length];
Console.WriteLine("int[] arrayX = {99,-65,7,8,10,25,7,-55};");
Console.WriteLine("int[] arrayY = new int[arrayX.Length];");
Array.Copy(arrayX, arrayY, arrayX.Length);
Console.WriteLine("arrayX: " + string.Join(", ", arrayX));
Console.WriteLine("arrayY: " + string.Join(", ", arrayY));
GeneralRes.GResText.WriteSubTitle("Array.ConstrainedCopy(Array sourceArray, int sourceIndex \"start point in source\",\n" +
                                  "                      Array destinationArray, int destinationIndex \"start point in destination\",\n" +
                                  "                      int lenght \"tot elements to copy\")");
int[] arrayZ = { 0,8,4,6,5,8,2 };
Console.WriteLine("int[] arrayZ = = { 0,8,4,6,5,8,2 };");
// Copies a range of elements from an Array starting at the specified source index and pastes them to another Array
// starting at the specified destination index. Guarantees that all changes are undone if the copy does not succeed completely.
Array.ConstrainedCopy(arrayX, 2, arrayZ, 3, 4);
Console.WriteLine("Array.ConstrainedCopy(arrayX, 2, arrayZ, 3, 4);");
Console.WriteLine("arrayZ: " + string.Join(", ", arrayZ));

// delegates
// Array.Find()
// Array.FindAll()
// Array.FindIndex()
// Array.FindLast()
// Array.FindLastIndex()
// Array.ConvertAll()
// Array.ForEach
// Array.TrueForAll()
// Array.Exists()

/**
 * n implementados ainda
Array.IndexOf()
Array.LastIndexOf()
Array.AsReadOnly()
    */

               

// nao coloquei
// Binary Search 

