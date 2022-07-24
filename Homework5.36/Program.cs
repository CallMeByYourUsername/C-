//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [33];
Random rand = new Random();
for (int i =0; i < array.Length; i++)
array [i] = rand.Next(200);
Console.WriteLine("[{0}]", string.Join(", " , array));

int sum = 0;
for (int i = 1; i < array.Length; i +=2)
{
    sum += array[i];
}
Console.WriteLine(sum);