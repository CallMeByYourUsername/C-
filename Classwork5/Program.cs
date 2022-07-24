//Создаю двумерный массив с помощью функции, элемент массива A[m,n] = m + n
int [ , ] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
        }

    }
    return matrix;
}

void PrintMatrix (int [,] mtrx)
{
for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
           Console.Write(mtrx[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int [ , ] result = GetMatrix(3, 4);
PrintMatrix(result);