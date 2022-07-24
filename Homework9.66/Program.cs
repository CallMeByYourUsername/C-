/*Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, (n - 1)));
    }
 return AkkermanFunc(m, n);
}
Console.WriteLine(AkkermanFunc(3, 2));

