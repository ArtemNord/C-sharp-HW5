// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

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

void PrintMaxAndMinArrayElementsAndDifference(int [] array)
{
    int max = array[0];
    int min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }

        if (min > array[i])
        {
            min = array[i];
        }
            
    }
    Console.WriteLine($"Max = {max}");
    Console.WriteLine($"Min = {min}");

    int Difference = max - min;
    Console.WriteLine($"Difference = {Difference}");

}

PrintMaxAndMinArrayElementsAndDifference(arr);
