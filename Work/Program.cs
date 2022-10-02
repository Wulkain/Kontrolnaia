System.Console.WriteLine();
System.Console.WriteLine($"Изначальный массив к обработке: 123 23 hello world res");
string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void ArrayOfSort(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayOfSort(array1, array2);
System.Console.WriteLine();
System.Console.Write("Массив из не более 3х элементов в ячейке:");
PrintArray(array2);
System.Console.WriteLine();