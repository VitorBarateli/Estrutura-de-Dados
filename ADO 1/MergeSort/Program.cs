using Merge_Sort;

int[] array = { 5, 2, 4, 6, 1, 3 };

Console.WriteLine("Array Atual:");
for(int i  = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("\nArray Ordenado:");
MergeSort sort = new MergeSort(array);
sort.Ordenar(array);

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(sort.array[i]);
}