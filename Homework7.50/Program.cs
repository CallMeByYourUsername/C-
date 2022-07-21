/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
 возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет*/

int[,] GetMatrix(int m, int n, int min, int max) //заполняем массив случайными числами
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
// проверка есть ли нужный элемент массива
void CheckMatrix(int[,] matrix, int n, int m)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == matrix[n, m])
        {
        Console.Write($"value of elements on position row {n} and column {m}= {matrix[n - 1, m - 1]}");
        }
        else 
        {
            Console.WriteLine("There is no such element");
        }
    }
  }
}

void PrintMatrix(int[,] mtrx) // печатаем массив
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {

            Console.Write($"{mtrx[i, j],3}");
        }
        Console.WriteLine();
    }
}
int [ , ] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
Console.WriteLine();
CheckMatrix(result, 3, 3);


