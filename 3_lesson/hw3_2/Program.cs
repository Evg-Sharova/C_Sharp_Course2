// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

double Line3D(float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
}

Console.WriteLine(Line3D(3,4,5,1,6,7));
Console.WriteLine(Line3D(6,8,9,5,3,5));