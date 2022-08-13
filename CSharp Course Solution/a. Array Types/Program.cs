// SIMPLE ARRAYS
GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("Simple array");

// Declare a single-dimensional array of 5 integers.
int[] array1 = new int[5];
array1[0] = 1;
// Declare and set array element values.
int[] array2 = new int[] { 1, 3, 5, 7, 9 };
// Alternative syntax, quick way.
int[] array3 = { 1, 2, 3, 4, 5, 6 };
// Fastest way to convert an array to string
Console.WriteLine("string.Join(\", \", array3): " + string.Join(", ", array3));

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - MultiDimensional vs Jagged Arrays: A jagged array is an array-of-arrays, so an int[][] is an array of int[] , 
//    each of which can be of different lengths and occupy their own block in memory. 
//    A multidimensional array ( int[,] ) is a single block of memory (essentially a matrix)

/*    Basically a matrix[lineIndex,columnIndex] will always follow a square proportion, eg. int[2,5]:
 *    {0,0,0,0,0}
 *    {0,0,0,0,0}
 *
 *    and a jagged array doesn't have to, eg. int[4][]:
 *    {0,0}
 *    {0,0,0,0,0,0,0}
 *    {0,0,0,0,}
 *    {0,0,0,0,0}                   */
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░

GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("MultiDimensional array");

// Declare a two dimensional array.
int[,] multiDimensionalArray1 = new int[2, 3];
// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6} };
// Looping trough a matrix in C#: we can pass the dimension of the required length
Console.WriteLine("multiDimensionalArray" + "\n{ ");
for (int i = 0; i < multiDimensionalArray2.GetLength(0); i++)
{
    Console.Write("    ");
    for (int j = 0; j < multiDimensionalArray2.GetLength(1); j++)
        Console.Write($"[{i},{j}]="+ multiDimensionalArray2[i,j] + " ");
    Console.WriteLine();
}
Console.WriteLine("}");

//----------------------------------------------------------------------------------------------------------------------

GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("jagged array");

// declaration
int[][] jaggedArray = new int[6][];
// index initialization
jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
jaggedArray[3] = new int[2] { 22, -33 };

// declaration + index initialization
int[][] jaggedArray2 =
{
    new int[] {0,2,3},
    new int[]{4}
};

// WAYS TO LOOP THROUGH A JAGGED ARRAY
// IF NULL REQUIRED: arrays are objects in c#, because of it trying to access a null obj results in this exception:
// "Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object."
GeneralRes.GResText.WriteSubTitle("if not null");
for (int i = 0; i < jaggedArray.Length; i++) {
    if (jaggedArray[i] is not null) {
        Console.Write($"jaggedArray[{i}]: ");
        for (int j = 0; j < jaggedArray[i].Length; j++)
            Console.Write(jaggedArray[i][j] + " ");
        Console.WriteLine();
    }
    else Console.WriteLine($"jaggedArray[{i}]: null");
}

Console.WriteLine();

// TRY CATCH ALTERNATIVE:
GeneralRes.GResText.WriteSubTitle("try catch");
for (int i = 0; i < jaggedArray.Length; i++) {
    try {
        Console.Write($"jaggedArray[{i}]: ");
        for (int j = 0; j < jaggedArray[i].Length; j++)
            Console.Write(jaggedArray[i][j] + " ");
        Console.WriteLine();
    }
    catch (Exception e) { Console.WriteLine("null "); }
}

Console.WriteLine();

// FOREACH ALTERNATIVE: 
GeneralRes.GResText.WriteSubTitle("foreach");
foreach (int[] arr in jaggedArray) 
    if (arr is not null) 
        Console.WriteLine(string.Join(", ", arr));

//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
//  - Array as parameter: new [] {1,2,3}
//░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
