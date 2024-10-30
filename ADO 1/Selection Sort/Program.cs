using Selection_Sort;

int[] array = { 5, 2, 4, 6, 1, 3 };
Console.WriteLine("Array Atual: ");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

SelectionSort sort = new SelectionSort(array);
Console.WriteLine("\nArray Ordenado:");
sort.Ordernar();