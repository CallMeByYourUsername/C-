//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Write four coordinates in the following order(k1, k2, b1, b2): ");
double k1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine($"Lines match");
    else Console.WriteLine($"Lines are parallel");
}
else
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"intersection points: [{x};{y}]"); 
}


