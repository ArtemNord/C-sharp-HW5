// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int [] CreatArray()
{
    int [] array = new int [10];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (-10, 11);
        Console.Write($" {array[i]}");
    }
    return array;
}
int [] arr = CreatArray();
Console.WriteLine();

void PrintSummOddArrayElements(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine($"Sum odd array elements = {sum}");
}

PrintSummOddArrayElements(arr);