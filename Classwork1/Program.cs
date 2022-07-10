 int[] array = new int[123];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(200); 
 Console.WriteLine("[{0}]", string.Join(", ", array));

 int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] >= 10 && array[i] <= 99)
         count ++;
    }

    Console.WriteLine(count);