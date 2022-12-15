// 2. Напишите программу, которая найдет точку пересечения двух прямых, заданных 
//    уравнениями y=k1*x+b1, y=k2*x+b2; значения k1, b1, k2, b2 задаются 
//    пользователем.

void Intersection(double k1, double k2, double b1, double b2)
{
    double k_sub = (k1 - k2);
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Intersection point: ({x}, {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("There are an infinite number of intersection points.");
    else
        Console.WriteLine("There is no intersection point.");
}

Intersection(int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()));
