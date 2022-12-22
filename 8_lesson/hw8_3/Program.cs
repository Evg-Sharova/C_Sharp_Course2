// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MatrixProduct(int[,] arr_1, int[,] arr_2)
{
    int row = arr_1.GetLength(0);
    int column = arr_1.GetLength(1);
    int [,] pr_matrix = new int[row, column];

    if(row != arr_2.GetLength(0) || column != arr_2.GetLength(1)) return pr_matrix;


    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            pr_matrix[i, j] = arr_1[i, j] * arr_2[i, j];
            return pr_matrix;   
}

Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_2 = MassNums(row_2, column_2,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_2);

int[,] pr_matrix = MatrixProduct(arr_1, arr_2);
Print(pr_matrix);


