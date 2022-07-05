// Я не уверена что по условию задачи требовалось именно это, но вот что получилось 
 int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(1, 100); 
 Console.WriteLine("[{0}]", string.Join(", ", array));