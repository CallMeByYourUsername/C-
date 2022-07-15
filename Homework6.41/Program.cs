// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Write some numbers with commas: ");
string[] text = Console.ReadLine()!.Split(',');

int count = 0;
for (int i = 0; i < text.Length; i++)
{
    int numbers = int.Parse(text[i]);
    if (numbers > 0) count++;
}
System.Console.WriteLine($"{count} numbers bigger than 0");