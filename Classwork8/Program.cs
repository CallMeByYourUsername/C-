//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*int[,] GetMatrix(int m, int n, int min, int max) //заполняем массив случайными числами
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

void ChangeMatrix(int[,] mtrxNew)
{
    for (int i = 0; i < mtrxNew.GetLength(1); i++)
    {
        int temp = mtrxNew[0, i];
        mtrxNew[0, i] = mtrxNew[mtrxNew.GetLength(0) - 1, i];
        mtrxNew[mtrxNew.GetLength(0) - 1, i] = temp;
    }

}

int[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
Console.WriteLine();
ChangeMatrix(result);
Console.WriteLine();
PrintMatrix(result);

//Задача 55 
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
int[,] ChangeMatrix(int[,] mtrxNew)
{
    int[,] temp = new int[mtrxNew.GetLength(1), mtrxNew.GetLength(0)];
    for (int i = 0; i < mtrxNew.GetLength(1); i++)
    {
        for (int j = 0; j < mtrxNew.GetLength(0); j++)
        {
            temp[i, j] = mtrxNew[j, i];
        }

    }
    return temp;
}


int[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
Console.WriteLine();
PrintMatrix(ChangeMatrix(result));*/

//Задача 57 Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


/*int[,] GetMatrix(int m, int n, int min, int max) //заполняем массив случайными числами
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
void FindAmount(int [,] mtrxNew)
    {
        int[] count = new int[10];
 
        for (int i = 0; i < mtrxNew.GetLength(0); i++)
        {
            for (int j = 0; j < mtrxNew.GetLength(1); j++)
            {
               count[mtrxNew[i,j]]++; 
            }
            
        }
    for (int i = 0; i < count.Length; i++)
    {
        Console.WriteLine($"There are {count[i]} numbers {i}");
    }
    }


int[,] result = GetMatrix(3, 3, 0, 10);
PrintMatrix(result);
Console.WriteLine(); 
FindAmount(result);*/

//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

void FindMinElement(int[,] matrix, ref int indexI, ref int indexJ)
{
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = matrix[i, j];
            indexI = i;
            indexJ = j;
        }

    }
}
int[,] DeleteRowCol(int[,] matrix, int indexI, int indexJ)
{
    int[,] resultArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int offSetI = 0;
    int offSetJ = 0;
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {   
        if (i == indexI) offSetI++;
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            if(j ==indexJ) offSetJ++;
            resultArr[i,j] = matrix[i + offSetI, j + offSetJ];
        }
        offSetI = 0;
        offSetJ = 0;
    }

    return resultArr;
}

int[,] result = GetMatrix(4, 4, 0, 10);
PrintMatrix(result);
Console.WriteLine();
int minI = 0;
int minJ = 0;
FindMinElement(result, ref minI, ref minJ);
Console.WriteLine($"{minJ}, {minI}");
PrintMatrix(DeleteRowCol(result, minI, minJ));