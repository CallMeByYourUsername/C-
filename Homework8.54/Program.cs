//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortMatrixRow(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)

                {
                    if (matrix[i, k] > matrix[i, k + 1])
                    {
                        int temp = matrix[i, k + 1];
                        matrix[i, k + 1] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }
    }
}
int[,] result = GetMatrix(4, 4, 0, 10);
PrintMatrix(result);
Console.WriteLine();
SortMatrixRow(result);
PrintMatrix(result);

