Console.Write("Write the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Write the second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int GetMult(int numberA, int numberB)
{
int result = 1;
int i = 0;
for (i = 1; i <= numberB; i++)
{
      result = result * numberA;
}
return result;
}
int result = GetMult(numberA, numberB);
Console.WriteLine(result);