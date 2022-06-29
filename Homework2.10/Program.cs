

Console.WriteLine("Insert 3-digits number: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
Console.WriteLine(number / 10 % 10);
}
else 
{
Console.WriteLine("Error");
}