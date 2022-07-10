// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

float [] array = new float [8];
Random rand = new Random();
for (int i = 0; i < array.Length; i ++)
array[i] = rand.Next(200);
Console.WriteLine(array);
Console.WriteLine("[{0}]", string.Join(", " , array));

float min = array[0]; 
float max = array[0]; 
for ( int i = 0; i < array.Length; i ++)
{ 
   if (array[i] < min)
   {
    min = array[i];
   }
   else if (array[i] > max) 
   {
    max = array [i];
   }
}
Console.WriteLine(max-min);