// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет колличество четных чисел в массиве.

int [] CreatArray()
{
    int [] array = new int [10];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next (100, 1000);
        Console.Write($" {array[i]}");
    }
    return array;
}
int [] arr = CreatArray();

// Console.WriteLine("Укажите длину массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void PrintEvenNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.WriteLine($"{i} = {array[i]}");
        }
    }
}

PrintEvenNumbers(arr);
