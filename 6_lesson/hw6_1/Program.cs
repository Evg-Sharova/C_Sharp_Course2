// 1. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел 
//    больше нуля ввел пользователь.


int CountNum()
{
    int count = 0;
    string word;

    while(true)
    {
        Console.Write("Введите число: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count +=1;
    }
}

Console.Write(CountNum());
