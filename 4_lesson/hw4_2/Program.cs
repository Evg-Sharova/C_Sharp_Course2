// 2. Напишите программу, которая принимает на вход число 
//    и выдает сумму цифр в числе.

int SumNums(int num)
{
    int n_sum = 0;

    while (num > 0)
    {
        n_sum += num % 10;
        num /= 10;
    }
    return n_sum;
}


Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
