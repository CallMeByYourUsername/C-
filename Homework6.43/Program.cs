//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Write four coordinates in the following order(k1, k2, b1, b2): ");
float k1 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());
float b1 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());
float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;
float y1 = k2 * x + b2;
Console.Write($"{y}, {y1}");