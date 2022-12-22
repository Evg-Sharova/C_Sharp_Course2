// 4. Напишите программу, которая принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "yes";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()));
