Console.WriteLine("Insert a number: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 )
{
   string str = number.ToString();
   Console.WriteLine(str[2]);
}
else 
Console.WriteLine("You don't have the third number");