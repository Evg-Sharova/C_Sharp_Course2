// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}


int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}


void RowSmallAmount(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int amount = 1000;
    int num;
    int smallest = 0;

    for (int i = 0; i < row; i++)
    {
        num = 0;
        for (int j = 0; j < column; j++)
            num += arr[i, j];
            Console.Write($"{num, 5} ");
        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
        Console.WriteLine();
        Console.Write($"The row with the lowest amount per position - {smallest + 1}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
RowSmallAmount(arr_1);
