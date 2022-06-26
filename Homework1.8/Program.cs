 Console.WriteLine("Write a number: ");
 int n = int.Parse(Console.ReadLine()!);
 int x = 2; 

 while (x < n) 
 {
    Console.WriteLine(x);
    x+=2;
 }
  Console.WriteLine(x);


// Я бы сделала так, но нельзя сделать массив со значением index:
/*int[] arr = new int[index];
int n = 8;
int index = 0;
int evenNumbers = 2;

if (evenNumbers < n) 
{
 arr[index] = evenNumbers;
 index ++;
 evenNumbers+=2;
}
else 
{
    Console.WriteLine(arr[index]);
} */ 



