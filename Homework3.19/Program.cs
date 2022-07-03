Console.Write("Write a 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    string str = num.ToString();
    if (str [0] == str [4] && str[1] == str[3])
    {
        Console.WriteLine("it is a palindrome");
    }
    else 
    {
    Console.WriteLine("It is not a palindrome");
    }
}
else 
{
    Console.WriteLine("Error, use only 5 digits");
}
   
  