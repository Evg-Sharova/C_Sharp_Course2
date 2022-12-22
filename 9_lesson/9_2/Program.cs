// 2. Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void Numbers(int m, int n)
{

    if (m > n) return;

    Console.Write($" {m} ");
    Numbers(m+1, n);
}

Console.Write("Enter the number m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter the number n: ");
int n = int.Parse(Console.ReadLine());;
Numbers(m, n);
