// 1. Задайте массив, заполненный случайными положительными 
// трехзначными числами. Напишите программу, которая покажет 
// количество четных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int EvenNum(int[] arr)
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        count += 1;
    }
    return count;
}


int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
    
Print(arr_1);
Console.WriteLine(EvenNum(arr_1));
