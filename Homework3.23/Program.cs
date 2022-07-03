Console.WriteLine("Write a number");
int number = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= number)
{
    Console.Write($"{a*a*a};");
    a++;
}
Console.Write("\b \b");

