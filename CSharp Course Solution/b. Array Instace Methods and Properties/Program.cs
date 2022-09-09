GeneralRes.GResText.JumpLines();

GeneralRes.GResText.WriteTitle("Instance Properties");
GeneralRes.GResText.WriteSubTitle("Ordinary Array");

int[] array = {1,2,3,4};
Console.WriteLine("array: " + string.Join(", ", array));
Console.WriteLine("array.Length:         " + array.Length);
Console.WriteLine("array.Rank:           " + array.Rank);
Console.WriteLine("array.IsReadOnly:     " + array.IsReadOnly);
Console.WriteLine("array.IsFixedSize:    " + array.IsFixedSize);
Console.WriteLine("array.IsSynchronized: " + array.IsSynchronized);

GeneralRes.GResText.PrintLine();
//----------------------------------------------------------------

GeneralRes.GResText.WriteSubTitle("Multidimensional Array");
int[,] matrix2D = { {0,1,2}, {3,4,5}, {6,7,8} };
Console.WriteLine("int[,] matrix2D = {\n{0,1,2}\n{3,4,5}\n{6,7,8}\n}");
Console.WriteLine("matrix2D.Length: " + matrix2D.Length);
Console.WriteLine("matrix2D.Rank:   " + matrix2D.Rank);

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Jagged Array");
int[][] jaggedArray =
    { new int[] {0,2,3}, new int[] {4} };
Console.WriteLine("int[][] jaggedArray = \n{\nnew int[] {0,2,3},\nnew int[] {4}\n};");
Console.WriteLine("jaggedArray.Length: " + jaggedArray.Length);
Console.WriteLine("jaggedArray.Rank    " + jaggedArray.Rank);

//----------------------------------------------------------------

GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("Instance Methods");

int[] array2 = (int[])array.Clone();
Console.WriteLine("array2 = (int[])array.Clone(): " + string.Join(", ", array2));

// Copies but allowing to set a index to the copy
int[] array3 = new int[10]; 
array.CopyTo(array3, 2);
Console.WriteLine("array.CopyTo(array3, 2):       " + string.Join(", ", array3));

