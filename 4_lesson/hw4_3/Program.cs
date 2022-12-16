// 3. Напишите программу, которая задает массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции.

void Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(10);
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите число:");
Massiv(int.Parse(Console.ReadLine()));
