// 1. Напишите программу, которая перевернёт одномерный массив
//    (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] NewArr(int[] arr)
{
    int to = arr.Length / 2;         // переменная середины массива
    int[] NewArr;                    // новый массив

    bool chet = arr.Length % 2 == 0; // переменная четности количества чисел в массиве(да/нет)

    if (chet)
        NewArr = new int[to];
    else
        NewArr = new int[to + 1];

    // заполнение нового массива произведением зеркальных элементов
    for (int i = 0; i < to; i++)
    {
        NewArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    // если массив с нечетным числом, выдираем серединку в новый
    if (!chet)
        NewArr[NewArr.Length - 1] = arr[to];

    return NewArr;
}

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

void RevMas(int[] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}



int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
RevMas(arr_1);
Print(arr_1);
