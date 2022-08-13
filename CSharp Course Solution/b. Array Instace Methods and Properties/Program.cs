GeneralRes.GResText.JumpLines();
GeneralRes.GResText.WriteTitle("Instance Properties/Methods");
GeneralRes.GResText.WriteSubTitle("Ordinary Array");
int[] array1 = {1,2,3,4};
Console.WriteLine("array1: " + string.Join(", ", array1));
Console.WriteLine("array.Length: " + array1.Length);
Console.WriteLine("array.Rank:   " + array1.Rank);

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Multidimensional Array");
int[,] matrix2D = { {0,1,2}, 
                    {3,4,5},
                    {6,7,8} };
Console.WriteLine("int[,] matrix2D = {\n{0,1,2}\n{3,4,5}\n{6,7,8}\n}");
Console.WriteLine("matrix2D.Length: " + matrix2D.Length);
Console.WriteLine("matrix2D.Rank:   " + matrix2D.Rank);

GeneralRes.GResText.PrintLine();
GeneralRes.GResText.WriteSubTitle("Jagged Array");
int[][] jaggedArray =
{
    new int[] {0,2,3},
    new int[] {4}
};
Console.WriteLine("int[][] jaggedArray = \n{\nnew int[] {0,2,3},\nnew int[] {4}\n};");
Console.WriteLine("jaggedArray.Length: " + jaggedArray.Length);
Console.WriteLine("jaggedArray.Rank    " + jaggedArray.Rank);

// ====================================================================================================================
// ====================================================================================================================
// ====================================================================================================================


