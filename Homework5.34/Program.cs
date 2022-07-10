// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

 int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(100, 1000); 
 Console.WriteLine("[{0}]", string.Join(", ", array));

 int count = 0;
 for (int i = 0; i < array.Length; i ++)
 {
    if (array[i] % 2 == 0)
    {
        count ++;
    }
 }
 Console.WriteLine(count);