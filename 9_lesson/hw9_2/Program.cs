// 2. Задайте значения M и N. Напишите программу, которая
//  найдет сумму натуральных элементов в промежутке от M до N.

int Summ(int m, int n)
{
    if (m > n) return 0;
    return Summ (m + 1, n) + m;
}

Console.WriteLine(Summ(2, 4));
