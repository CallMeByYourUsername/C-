//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,]GetMatrix(int m, int n, int min, int max) //заполняем массив случайными числами
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int  i = 0; i < matrix.GetLength(0); i++)
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
// среднеарифметическое 
void AverageNumber(int[ , ] mtrxNew)
{ 
   double average  = 0;
   double sum = 0;

    for (int j = 0; j < mtrxNew.GetLength(1); j++)
    {   
        for (int i = 0; i < mtrxNew.GetLength(0); i++)
        {   
            sum =+ mtrxNew[i,j];
        }
     average = sum / mtrxNew.GetLength(0); 
     Console.WriteLine($"Average of the column is {Math.Round(average, 2)}");
    }
}


int [ , ] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);
AverageNumber(result);