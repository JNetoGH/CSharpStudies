GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("Static Property");
Console.WriteLine("Array.MaxLength: " + Array.MaxLength);
GeneralRes.GResText.JumpLines();

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.WriteTitle("Static Methods array: { 99,-65,7,8,10,25,7,-55 }");
int[] array = {99,-65,7,8,10,25,7,-55};

//----------------------------------------------------------------

// returns the index of or the first/last matching term
GeneralRes.GResText.WriteSubTitle("Find Index Related");
Console.WriteLine("Array.IndexOf(array, 7):               " + Array.IndexOf(array, 7));
Console.WriteLine("Array.BinarySearch(array, 8):          " + Array.BinarySearch(array, 8));
Console.WriteLine("Array.LastIndexOf(array, 7):           " + Array.LastIndexOf(array, 7));
Console.WriteLine("Array.FindIndex(array, Predicate):     " + Array.FindIndex(array, i => i is > 5 and < 10));
Console.WriteLine("Array.FindLastIndex(array, Predicate): " + Array.FindLastIndex(array, i => i is > 5 and < 10));

//----------------------------------------------------------------

GeneralRes.GResText.WriteSubTitle("Find Value Related");

// returns just the first/last matching term
Console.WriteLine("Array.Find(array, Predicate):      " + Array.Find(array, i => i < 0));
Console.WriteLine("Array.FindLast(array, Predicate):  " + Array.FindLast(array, i => i < 0));

// returns an array with all the matching terms
int[] matchingTerms = Array.FindAll(array, i => i < 0);
Console.WriteLine("Array.FindAll(array, Predicate):   " + "{ " + String.Join(", ", matchingTerms) + " }");

//---------------------------------------------------------------

GeneralRes.GResText.WriteSubTitle("Bool Result");

// returns true if every element of the array matches the Predicate
Console.WriteLine("Array.TrueForAll(array, Predicate): " + Array.TrueForAll(array, new Predicate<int>(i => i > 0)));

// returns true if at least one element of the array matches the Predicate
Console.WriteLine("Array.Exists(array, Predicate):     " + Array.Exists(array, new Predicate<int>( i => i < -30)));

//----------------------------------------------------------------
                                                           
GeneralRes.GResText.WriteSubTitle("ForEach");
void ShowSquares(int val) => Console.WriteLine("{0:d} squared = {1:d}", val, val*val);
Array.ForEach(array, new Action<int>(ShowSquares));

//----------------------------------------------------------------

GeneralRes.GResText.WriteSubTitle("Others");
Array.Reverse(array);
Console.WriteLine("Array.Reverse(array):              " + "{ " + string.Join(", ", array) + " }");
Array.Sort(array);
Console.WriteLine("Array.Sort(array):                 " + "{ " + string.Join(", ", array) + " }");
Array.Clear(array);
Console.WriteLine("Array.Clear(array):                " + "{ " + string.Join(", ", array) + " }");
Array.Resize(ref array, 15);
Console.WriteLine("Array.Resize(ref array, 15):       " + "{ " + string.Join(", ", array) + " }");
Array.Fill(array, 5);
Console.WriteLine("Array.Fill(array, 5):              " + "{ " + string.Join(", ", array) + " }");
Array.Fill(array, 7, 3, 9);
Console.WriteLine("Array.Fill(array, 7, 3, 9):        " + "{ " + string.Join(", ", array) + " }");

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Empty<T>()");

int[] array2 = Array.Empty<int>();
Console.WriteLine("int[] array2 = Array.Empty<int>(): "  + '{' + string.Join(", ", array2) + '}');
Console.WriteLine("array2.Lenght: " + array2.Length);

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.PrintLine();

Array array3 = Array.CreateInstance(typeof(int), 10);
Console.Write("Array array3 = Array.CreateInstance(typeof(int), 10): ");
foreach (var element in array3) Console.Write(element + ",");
Console.WriteLine();

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Array.Copy(Array sourceArray, Array destinationArray, int lenght \"tot elements to copy\")");

int[] arrayX = {99,-65,7,8,10,25,7,-55};
int[] arrayY = new int[arrayX.Length];
Console.WriteLine("int[] arrayX = {99,-65,7,8,10,25,7,-55};");
Console.WriteLine("int[] arrayY = new int[arrayX.Length];");
Array.Copy(arrayX, arrayY, arrayX.Length);
Console.WriteLine("arrayX: " + string.Join(", ", arrayX));
Console.WriteLine("arrayY: " + string.Join(", ", arrayY));

//----------------------------------------------------------------

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

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("ConvertAll<TOutput> (Converter<T,TOutput> converter)");
GeneralRes.GResText.WriteSubTitle("Converters Delegate: public delegate TOutput Converter<in TInput,out TOutput>(TInput input)");

int[] intArr = { 1, 2, 3, 5 };
char[] charArr = Array.ConvertAll(intArr, new Converter<int, char>(input => (char) input));
Console.WriteLine("intArr: { " + String.Join(",", intArr) + " }");
Console.WriteLine("charArr: { " + String.Join(",", charArr) + " }");

// ---------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.PrintLine();
int[] regularArray = { 1, 2, 3 };
var readOnlyArray = Array.AsReadOnly(regularArray);

regularArray[1] = 5;
// readOnlyArray[1] = 5;      Error [CS0200]
