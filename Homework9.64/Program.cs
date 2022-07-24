/*Новое ДЗ Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void FindSum(int m, int n, int sum = 0)
{

    if (m > n)
    {
        Console.WriteLine($"The sum of elements between {m} and {n} eqials: ");
        Console.WriteLine(sum);
        return;
    }
    sum = sum + m;
    m++;
    FindSum(m, n, sum);

}
FindSum(1, 15);